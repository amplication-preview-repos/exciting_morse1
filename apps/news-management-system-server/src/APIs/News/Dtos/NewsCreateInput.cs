namespace NewsManagementSystem.APIs.Dtos;

public class NewsCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? Description { get; set; }

    public string? Id { get; set; }

    public string Image { get; set; }

    public string? Title { get; set; }

    public DateTime UpdatedAt { get; set; }
}
