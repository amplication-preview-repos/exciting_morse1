using Microsoft.EntityFrameworkCore;
using NewsManagementSystem.APIs;
using NewsManagementSystem.APIs.Common;
using NewsManagementSystem.APIs.Dtos;
using NewsManagementSystem.APIs.Errors;
using NewsManagementSystem.APIs.Extensions;
using NewsManagementSystem.Infrastructure;
using NewsManagementSystem.Infrastructure.Models;

namespace NewsManagementSystem.APIs;

public abstract class NewsItemsServiceBase : INewsItemsService
{
    protected readonly NewsManagementSystemDbContext _context;

    public NewsItemsServiceBase(NewsManagementSystemDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one News
    /// </summary>
    public async Task<News> CreateNews(NewsCreateInput createDto)
    {
        var news = new NewsDbModel
        {
            CreatedAt = createDto.CreatedAt,
            Description = createDto.Description,
            Image = createDto.Image,
            Title = createDto.Title,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            news.Id = createDto.Id;
        }

        _context.NewsItems.Add(news);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<NewsDbModel>(news.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one News
    /// </summary>
    public async Task DeleteNews(NewsWhereUniqueInput uniqueId)
    {
        var news = await _context.NewsItems.FindAsync(uniqueId.Id);
        if (news == null)
        {
            throw new NotFoundException();
        }

        _context.NewsItems.Remove(news);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many NewsItems
    /// </summary>
    public async Task<List<News>> NewsItems(NewsFindManyArgs findManyArgs)
    {
        var newsItems = await _context
            .NewsItems.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return newsItems.ConvertAll(news => news.ToDto());
    }

    /// <summary>
    /// Meta data about News records
    /// </summary>
    public async Task<MetadataDto> NewsItemsMeta(NewsFindManyArgs findManyArgs)
    {
        var count = await _context.NewsItems.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one News
    /// </summary>
    public async Task<News> News(NewsWhereUniqueInput uniqueId)
    {
        var newsItems = await this.NewsItems(
            new NewsFindManyArgs { Where = new NewsWhereInput { Id = uniqueId.Id } }
        );
        var news = newsItems.FirstOrDefault();
        if (news == null)
        {
            throw new NotFoundException();
        }

        return news;
    }

    /// <summary>
    /// Update one News
    /// </summary>
    public async Task UpdateNews(NewsWhereUniqueInput uniqueId, NewsUpdateInput updateDto)
    {
        var news = updateDto.ToModel(uniqueId);

        _context.Entry(news).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.NewsItems.Any(e => e.Id == news.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }
}
