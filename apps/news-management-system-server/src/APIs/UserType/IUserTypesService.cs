using NewsManagementSystem.APIs.Common;
using NewsManagementSystem.APIs.Dtos;

namespace NewsManagementSystem.APIs;

public interface IUserTypesService
{
    /// <summary>
    /// Create one UserType
    /// </summary>
    public Task<UserType> CreateUserType(UserTypeCreateInput usertype);

    /// <summary>
    /// Delete one UserType
    /// </summary>
    public Task DeleteUserType(UserTypeWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many UserTypes
    /// </summary>
    public Task<List<UserType>> UserTypes(UserTypeFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about UserType records
    /// </summary>
    public Task<MetadataDto> UserTypesMeta(UserTypeFindManyArgs findManyArgs);

    /// <summary>
    /// Get one UserType
    /// </summary>
    public Task<UserType> UserType(UserTypeWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one UserType
    /// </summary>
    public Task UpdateUserType(UserTypeWhereUniqueInput uniqueId, UserTypeUpdateInput updateDto);
}
