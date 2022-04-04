#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cbsStudents.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace cbsStudents.Data;

public class CbsStudentContext : IdentityDbContext
{
    public CbsStudentContext(DbContextOptions<CbsStudentContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        this.SeedPosts(builder);
        this.SeedComments(builder);
    }

    public DbSet<cbsStudents.Models.Entities.Post> Post { get; set; }

    public DbSet<cbsStudents.Models.Entities.Comment> Comment { get; set; }

    private void SeedPosts(ModelBuilder builder)
    {
        builder.Entity<Post>().HasData(
            new Post() { Id = 1, Title = "This is my first post", Text = "This is the description of my first post", Created = DateTime.Now, Status = PostStatus.DRAFT, Media = "Image", AmountOfLikes = 5, AmountOfComments = 7 },
            new Post() { Id = 2, Title = "This is my second post", Text = "This is the description of my second post", Created = DateTime.Now, Status = PostStatus.DRAFT, Media = "Video", AmountOfLikes = 10, AmountOfComments = 12 },
            new Post() { Id = 3, Title = "This is my third post", Text = "This is the description of my third post", Created = DateTime.Now, Status = PostStatus.DRAFT, Media = "Image", AmountOfLikes = 3, AmountOfComments = 1 }
        );

    }

    private void SeedComments(ModelBuilder builder)
    {
        builder.Entity<Comment>().HasData(
            new Comment() { CommentId = 1, Text = "This is a comment on post 1", TimeStamp = DateTime.Now, PostId = 1 },
            new Comment() { CommentId = 2, Text = "This is also a comment on post 1", TimeStamp = DateTime.Now, PostId = 1 },
            new Comment() { CommentId = 3, Text = "This is a comment on post 2", TimeStamp = DateTime.Now, PostId = 2 },
            new Comment() { CommentId = 4, Text = "This is also a comment on post 2", TimeStamp = DateTime.Now, PostId = 2 },
            new Comment() { CommentId = 5, Text = "This is a comment on post 3", TimeStamp = DateTime.Now, PostId = 3 },
            new Comment() { CommentId = 6, Text = "This is also a comment on post 3", TimeStamp = DateTime.Now, PostId = 3 }
        );
    }
}

