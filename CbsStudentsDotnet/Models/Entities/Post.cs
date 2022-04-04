using System.ComponentModel.DataAnnotations;

namespace cbsStudents.Models.Entities;

public class Post {
    public int Id { get; set; }

    [MinLength(3, ErrorMessage = "Mininum length of the title is 3 characters")]
    [Required (ErrorMessage = "Title is required")]
    public string? Title {get; set;}

    [MinLength(10, ErrorMessage = "Mininum length of the text is 10 characters")]
    [Required (ErrorMessage = "Text is required")] 
    public string? Text { get; set; }

    [DataType(DataType.Date)]
    public DateTime Created { get; set; }

    [Required (ErrorMessage = "Post status is required")]
    public PostStatus Status { get; set; }

    public string? Media {get; set;}

    public int? AmountOfLikes {get; set;}
    public int? AmountOfComments {get; set;}

    public List<Comment> Comments { get; set; }

}
