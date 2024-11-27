using Microsoft.EntityFrameworkCore;
using NewsManagementSystem.APIs;
using NewsManagementSystem.APIs.Common;
using NewsManagementSystem.APIs.Dtos;
using NewsManagementSystem.APIs.Errors;
using NewsManagementSystem.APIs.Extensions;
using NewsManagementSystem.Infrastructure;
using NewsManagementSystem.Infrastructure.Models;

namespace NewsManagementSystem.APIs;

public abstract class UserTypesServiceBase : IUserTypesService
{
    protected readonly NewsManagementSystemDbContext _context;

    public UserTypesServiceBase(NewsManagementSystemDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one UserType
    /// </summary>
    public async Task<UserType> CreateUserType(UserTypeCreateInput createDto)
    {
        var userType = new UserTypeDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            userType.Id = createDto.Id;
        }

        _context.UserTypes.Add(userType);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<UserTypeDbModel>(userType.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one UserType
    /// </summary>
    public async Task DeleteUserType(UserTypeWhereUniqueInput uniqueId)
    {
        var userType = await _context.UserTypes.FindAsync(uniqueId.Id);
        if (userType == null)
        {
            throw new NotFoundException();
        }

        _context.UserTypes.Remove(userType);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many UserTypes
    /// </summary>
    public async Task<List<UserType>> UserTypes(UserTypeFindManyArgs findManyArgs)
    {
        var userTypes = await _context
            .UserTypes.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return userTypes.ConvertAll(userType => userType.ToDto());
    }

    /// <summary>
    /// Meta data about UserType records
    /// </summary>
    public async Task<MetadataDto> UserTypesMeta(UserTypeFindManyArgs findManyArgs)
    {
        var count = await _context.UserTypes.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one UserType
    /// </summary>
    public async Task<UserType> UserType(UserTypeWhereUniqueInput uniqueId)
    {
        var userTypes = await this.UserTypes(
            new UserTypeFindManyArgs { Where = new UserTypeWhereInput { Id = uniqueId.Id } }
        );
        var userType = userTypes.FirstOrDefault();
        if (userType == null)
        {
            throw new NotFoundException();
        }

        return userType;
    }

    /// <summary>
    /// Update one UserType
    /// </summary>
    public async Task UpdateUserType(
        UserTypeWhereUniqueInput uniqueId,
        UserTypeUpdateInput updateDto
    )
    {
        var userType = updateDto.ToModel(uniqueId);

        _context.Entry(userType).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.UserTypes.Any(e => e.Id == userType.Id))
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
