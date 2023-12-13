using Blog.DataContext;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new BlogDataContext())
        {
            // var posts = context
            //             .Posts
            //             .AsNoTracking()
            //             .Include(x => x.Author)
            //             .Include(x => x.Category)
            //             .OrderByDescending(x => x.LastUpdateDate)
            //             .ToList();

            // foreach (var post in posts)
            //     Console.WriteLine($"{ post.Title } escrito por { post.Author.Name } em { post.Category.Name }");

            // var user = new User 
            // {
            //     Name = "Marcos",
            //     Slug = "marcosvinicius",
            //     Email = "marcosvinicius@gmail",
            //     Bio = "Desenvolvedor .NET",
            //     Image = "https: foto",
            //     PasswordHash = "123456"
            // };

            // var category = new Category
            // {
            //     Name = "Backend",
            //     Slug = "backend"
            // };

            // var post = new Post
            // {
            //     Author = user,
            //     Category = category,
            //     Body = "<p>Hello world <p>",
            //     Slug = "comecando-com-ef-core",
            //     Summary = "Neste artigo vamos aprender sobre EF Core",
            //     Title = "Começando com EF Core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now
            // };
            
            // context.Posts.Add(post);
            // context.SaveChanges();

            var post = context
                        .Posts
                        .Include(x => x.Author)
                        .Include(x => x.Category)
                        .OrderByDescending(x => x.LastUpdateDate)
                        .FirstOrDefault();

            post.Author.Name = "Marcos Vinicius";

            context.Posts.Update(post);
            context.SaveChanges();

        }
    }
}
