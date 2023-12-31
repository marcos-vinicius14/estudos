


namespace Blog.Models;

public class Post
{
    // [Key]
    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Title { get; set; }   
    public string Summary { get; set; }
    public string Body { get; set; }
    public string Slug { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public Category Category { get; set; }
    public User Author { get; set; }
    public IList<Tag> Tags { get; set; }

    // public Post()
    // {
    //     Tags = new List<Tag>();
    // }
}