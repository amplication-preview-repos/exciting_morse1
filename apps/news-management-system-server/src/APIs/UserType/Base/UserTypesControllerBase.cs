using Microsoft.AspNetCore.Mvc;
using NewsManagementSystem.APIs;
using NewsManagementSystem.APIs.Common;
using NewsManagementSystem.APIs.Dtos;
using NewsManagementSystem.APIs.Errors;

namespace NewsManagementSystem.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class UserTypesControllerBase : ControllerBase
{
    protected readonly IUserTypesService _service;

    public UserTypesControllerBase(IUserTypesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one UserType
    /// </summary>
    [HttpPost()]
    public async Task<ActionResult<UserType>> CreateUserType(UserTypeCreateInput input)
    {
        var userType = await _service.CreateUserType(input);

        return CreatedAtAction(nameof(UserType), new { id = userType.Id }, userType);
    }

    /// <summary>
    /// Delete one UserType
    /// </summary>
    [HttpDelete("{Id}")]
    public async Task<ActionResult> DeleteUserType([FromRoute()] UserTypeWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteUserType(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many UserTypes
    /// </summary>
    [HttpGet()]
    public async Task<ActionResult<List<UserType>>> UserTypes(
        [FromQuery()] UserTypeFindManyArgs filter
    )
    {
        return Ok(await _service.UserTypes(filter));
    }

    /// <summary>
    /// Meta data about UserType records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> UserTypesMeta(
        [FromQuery()] UserTypeFindManyArgs filter
    )
    {
        return Ok(await _service.UserTypesMeta(filter));
    }

    /// <summary>
    /// Get one UserType
    /// </summary>
    [HttpGet("{Id}")]
    public async Task<ActionResult<UserType>> UserType(
        [FromRoute()] UserTypeWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.UserType(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one UserType
    /// </summary>
    [HttpPatch("{Id}")]
    public async Task<ActionResult> UpdateUserType(
        [FromRoute()] UserTypeWhereUniqueInput uniqueId,
        [FromQuery()] UserTypeUpdateInput userTypeUpdateDto
    )
    {
        try
        {
            await _service.UpdateUserType(uniqueId, userTypeUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
