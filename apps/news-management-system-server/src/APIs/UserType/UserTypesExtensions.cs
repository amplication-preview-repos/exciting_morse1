using NewsManagementSystem.APIs.Dtos;
using NewsManagementSystem.Infrastructure.Models;

namespace NewsManagementSystem.APIs.Extensions;

public static class UserTypesExtensions
{
    public static UserType ToDto(this UserTypeDbModel model)
    {
        return new UserType
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static UserTypeDbModel ToModel(
        this UserTypeUpdateInput updateDto,
        UserTypeWhereUniqueInput uniqueId
    )
    {
        var userType = new UserTypeDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null)
        {
            userType.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            userType.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return userType;
    }
}
