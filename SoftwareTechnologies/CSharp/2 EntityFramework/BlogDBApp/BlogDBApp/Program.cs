using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDBApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BlogDBContext();

            //Problem 1
            ListUsers(db);

            //Problem 2
            ListPosts(db);

            //Problem 3
            CreateNewPost(db);

            //Problem 4
            CascadingInsert(db);

            //Problem 5
            UpdateData(db);

            //Problem 6
            DeleteData(db);

            //Problem 7
            NativeSQL(db);

        }

        private static void NativeSQL(BlogDBContext db)
        {
            var startDate = new DateTime(2016, 05, 19);
            var endDate = new DateTime(2016, 06, 14);

            var posts = db.Database.SqlQuery<PostData>(
                @"SELECT Id, Title, Date FROM Posts WHERE CONVERT(date, Date) BETWEEN {0} AND {1} ORDER BY Date", startDate, endDate);
            foreach (var p in posts)
            {
                Console.WriteLine($"#{p.Id}: {p.Title} ({p.Date})");
            }
        }

        private static void DeleteData(BlogDBContext db)
        {
            var lastPost = db.Posts.OrderByDescending(p => p.Id).First();
            db.Comments.RemoveRange(lastPost.Comments);
            lastPost.Tags.Clear();
            db.Posts.Remove(lastPost);
            db.SaveChanges();
            Console.WriteLine($"Deleted post #{lastPost.Id}");
        }

        private static void UpdateData(BlogDBContext db)
        {
            var user = db.Users.Where(u => u.UserName == "Mariika").First();
            user.PasswordHash = Guid.NewGuid().ToByteArray();
            db.SaveChanges();
            Console.WriteLine("User #{0} ({1}) has a new random password.", user.Id, user.UserName);
        }

        private static void CascadingInsert(BlogDBContext db)
        {
            var post = new Post()
            {
                Title = "New Title",
                Body = "New post with comments and tags",
                Date = DateTime.Now,
                Comments = new Comment[]
                {
                    new Comment() {Text = "Comment 1", Date = DateTime.Now},
                    new Comment() {Text = "Comment 2", Date = DateTime.Now, User = db.Users.First()}
                },
                Tags = db.Tags.Take(3).ToList()
            };
            db.Posts.Add(post);
            db.SaveChanges();
            Console.WriteLine("Post #{0} created.", post.Id);
        }

        private static void CreateNewPost(BlogDBContext db)
        {
            var post = new Post()
            {
                Title = "New Title",
                Body = "New Post Body",
                Date = DateTime.Now
            };
            db.Posts.Add(post);
            db.SaveChanges();
            Console.WriteLine("Post #{0} created.", post.Id);
        }

        private static void ListPosts(BlogDBContext db)
        {
            var posts = db.Posts.Select(
                p => new
                {
                    PostId = p.Id,
                    PostTitle = p.Title,
                    TagsCount = p.Tags.Count(),
                    CommentsCount = p.Comments.Count(),
                });
            foreach (var p in posts)
                Console.WriteLine($"{p.PostId} - {p.PostTitle} ({p.CommentsCount} comments, {p.TagsCount} tags)");
        }

        private static void ListUsers(BlogDBContext db)
        {
            foreach (var user in db.Users)
            {
                Console.WriteLine(user.UserName);
            }
        }
    }
}
