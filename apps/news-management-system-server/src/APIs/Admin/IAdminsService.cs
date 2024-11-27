using NewsManagementSystem.APIs.Common;
using NewsManagementSystem.APIs.Dtos;

namespace NewsManagementSystem.APIs;

public interface IAdminsService
{
    /// <summary>
    /// Create one Admin
    /// </summary>
    public Task<Admin> CreateAdmin(AdminCreateInput admin);

    /// <summary>
    /// Delete one Admin
    /// </summary>
    public Task DeleteAdmin(AdminWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Admins
    /// </summary>
    public Task<List<Admin>> Admins(AdminFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Admin records
    /// </summary>
    public Task<MetadataDto> AdminsMeta(AdminFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Admin
    /// </summary>
    public Task<Admin> Admin(AdminWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Admin
    /// </summary>
    public Task UpdateAdmin(AdminWhereUniqueInput uniqueId, AdminUpdateInput updateDto);
}
