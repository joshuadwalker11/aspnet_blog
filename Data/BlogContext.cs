using Microsoft.EntityFrameworkCore;
using blazor_blog.Models;

namespace blazor_blog.Data;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options) : base(options)
    {
        // empty body, necessary
    }

    public DbSet<BlogEntry> Entries { get; set; } = default!;
}