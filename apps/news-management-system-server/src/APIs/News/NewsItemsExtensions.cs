using NewsManagementSystem.APIs.Dtos;
using NewsManagementSystem.Infrastructure.Models;

namespace NewsManagementSystem.APIs.Extensions;

public static class NewsItemsExtensions
{
    public static News ToDto(this NewsDbModel model)
    {
        return new News
        {
            CreatedAt = model.CreatedAt,
            Description = model.Description,
            Id = model.Id,
            Image = model.Image,
            Title = model.Title,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static NewsDbModel ToModel(this NewsUpdateInput updateDto, NewsWhereUniqueInput uniqueId)
    {
        var news = new NewsDbModel
        {
            Id = uniqueId.Id,
            Description = updateDto.Description,
            Title = updateDto.Title
        };

        if (updateDto.CreatedAt != null)
        {
            news.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.Image != null)
        {
            news.Image = updateDto.Image;
        }
        if (updateDto.UpdatedAt != null)
        {
            news.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return news;
    }
}
