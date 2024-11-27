using NewsManagementSystem.APIs.Dtos;
using NewsManagementSystem.Infrastructure.Models;

namespace NewsManagementSystem.APIs.Extensions;

public static class AdminsExtensions
{
    public static Admin ToDto(this AdminDbModel model)
    {
        return new Admin
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static AdminDbModel ToModel(
        this AdminUpdateInput updateDto,
        AdminWhereUniqueInput uniqueId
    )
    {
        var admin = new AdminDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null)
        {
            admin.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            admin.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return admin;
    }
}
