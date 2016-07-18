using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogContext blogContext = new BlogContext();

            ListPosts(blogContext);

            ListUsers(blogContext);

            ListPostTitleAndBody(blogContext);

            OrderUsersByUsername(blogContext);

            OrderUsersBy2Params(blogContext);

            ListUsersWithPosts(blogContext);

            ListUsersWithPostTitles(blogContext);

            ListAuthorOfSpecificPost(blogContext);

            OrderPostsAuthors(blogContext);

            CreatePost(blogContext);

            UpdateData(blogContext);

            DeleteComment(blogContext);

            DeletePost(blogContext);
        }

        private static void DeletePost(BlogContext blogContext)
        {
            Post postInfo = blogContext.Posts.Single(p => p.Id == 33);
            blogContext.Comments.RemoveRange(postInfo.Comments);
            postInfo.Tags.Clear();
            blogContext.Posts.Remove(postInfo);
            blogContext.SaveChanges();
            Console.WriteLine(@"Post #{0} deleted successfully", postInfo.Id);
        }

        private static void DeleteComment(BlogContext blogContext)
        {
            Comment commentInfo = blogContext.Comments.Single(c => c.Id == 1);
            blogContext.Comments.Remove(commentInfo);
            blogContext.SaveChanges();
            Console.WriteLine(@"Comment #{0} deleted", commentInfo.Id);
        }

        private static void UpdateData(BlogContext blogContext)
        {
            User userInfo = blogContext.Users.Single(u => u.UserName == "GBotev");
            string oldName = userInfo.FullName;
            userInfo.FullName = "Grozdan Botev";
            blogContext.SaveChanges();
            Console.WriteLine(@"User '{0}' has been renamed to '{1}'", oldName, userInfo.FullName);
        }

        private static void CreatePost(BlogContext blogContext)
        {
            Post post = new Post()
            {
                AuthorId = 2,
                Title = "Random Title",
                Body = "Random Content",
                Date = DateTime.Now
            };
            blogContext.Posts.Add(post);
            blogContext.SaveChanges();

            Console.WriteLine("Post #{0} created!", post.Id);
        }

        private static void OrderPostsAuthors(BlogContext blogContext)
        {
            List<User> users = blogContext.Users.Select(u => u)
                            .Where(user => user.Posts.Count > 0)
                            .OrderByDescending(user => user.Id)
                            .ToList();
            foreach (var user in users)
            {
                Console.WriteLine("Username: {0}", user.UserName);
                Console.WriteLine("Full name: {0}", user.FullName);
                Console.WriteLine();
            }
        }

        private static void ListAuthorOfSpecificPost(BlogContext blogContext)
        {
            var author = blogContext.Users
                            .SelectMany(user => user.Posts, (user, post) => new { user.UserName, user.FullName, post.Id })
                            .Single(post => post.Id == 4);
            Console.WriteLine("Username: {0}", author.UserName);
            Console.WriteLine("Full name: {0}", author.FullName);
            Console.WriteLine();
        }

        private static void ListUsersWithPostTitles(BlogContext blogContext)
        {
            var users = blogContext.Users
                .SelectMany(user => user.Posts, (user, post) => new { user.UserName, post.Title });
            foreach (var user in users)
            {
                Console.WriteLine("Username: {0}", user.UserName);
                Console.WriteLine("Post title: {0}", user.Title);
                Console.WriteLine();
            }
        }

        private static void ListUsersWithPosts(BlogContext blogContext)
        {
            List<User> users = blogContext.Users.Select(u => u)
                .Where(user => user.Posts.Count > 0)
                .ToList();
            foreach (var user in users)
            {
                Console.WriteLine("Username: {0}", user.UserName);
                Console.WriteLine("Full name: {0}", user.FullName);
                Console.WriteLine("Posts Count: {0}", user.Posts.Count);
                Console.WriteLine();
            }
        }

        private static void OrderUsersBy2Params(BlogContext blogContext)
        {
            var users = blogContext.Users.Select(user => new
            {
                user.UserName,
                user.FullName
            })
                          .OrderByDescending(user => user.UserName)
                          .ThenByDescending(user => user.FullName)
                          .ToList();

            foreach (var user in users)
            {
                Console.WriteLine("Username: {0}", user.UserName);
                Console.WriteLine("Full name: {0}", user.FullName);
                Console.WriteLine();
            }
        }

        private static void OrderUsersByUsername(BlogContext blogContext)
        {
            var users = blogContext.Users.Select(user => new
            {
                user.UserName,
                user.FullName
            })
            .OrderBy(user=>user.UserName)
            .ToList();

            foreach (var user in users)
            {
                Console.WriteLine("Username: {0}", user.UserName);
                Console.WriteLine("Full name: {0}", user.FullName);
                Console.WriteLine();
            }
        }

        private static void ListPostTitleAndBody(BlogContext blogContext)
        {
            var posts = blogContext.Posts.Select(p => new
            {
                p.Title,
                p.Body
            }
                        ).ToList();

            foreach (var post in posts)
            {
                Console.WriteLine("Title: {0}", post.Title);
                Console.WriteLine("Content: {0}", post.Body);
                Console.WriteLine();
            }
        }

        private static void ListUsers(BlogContext blogContext)
        {
            List<User> users = blogContext.Users.Select(u => u).ToList();
            foreach (var user in users)
            {
                Console.WriteLine("ID: {0}", user.Id);
                Console.WriteLine("Name: {0}", user.FullName);
                Console.WriteLine("Comments Count: {0}", user.Comments.Count);
                Console.WriteLine("Posts Count: {0}", user.Posts.Count);
                Console.WriteLine();
            }
        }

        private static void ListPosts(BlogContext blogContext)
        {
            List<Post> posts = blogContext.Posts.Select(p => p).ToList();
            foreach (var post in posts)
            {
                Console.WriteLine("Title: {0}", post.Title);
                Console.WriteLine("AuthorId: {0}", post.AuthorId);
                Console.WriteLine("Comments Count: {0}", post.Comments.Count);
                Console.WriteLine("Tags Count: {0}", post.Tags.Count);
                Console.WriteLine();
            }
        }
    }
}
