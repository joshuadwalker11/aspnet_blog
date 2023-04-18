namespace blazor_blog.Models;

public class BlogEntry
{
    public uint BlogEntryId { get; set; }
    public string Title { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public DateTime PostedTime { get; set; } = DateTime.Now;






}