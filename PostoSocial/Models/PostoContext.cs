using Microsoft.EntityFrameworkCore;
namespace PostoSocial.Models
{
    public class PostoContext : DbContext
    {
        public PostoContext(DbContextOptions<PostoContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    AccountId = 1,
                    UserName = "samuraiofice",
                    Password = "ice",
                    Email = "andrew.honey@southeasttech.edu",
                    ProfilePicturePath = "butterfly.png"
                }
                );
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    PostId = 1,
                    PostTitle = "Yeet",
                    PostBody = "This is Posto Social Media",
                    ForumId = 1,
                    CategoryId = 1,
                    AccountId = 1,
                },
                new Post
                {
                    PostId = 2,
                    PostTitle = "Yo, second post",
                    PostBody = "welcome",
                    ForumId = 1,
                    CategoryId = 1,
                    AccountId = 1,
                },
                new Post
                {
                    PostId = 3,
                    PostTitle = "I make so many posts",
                    PostBody = "lorem ipsum",
                    ForumId = 1,
                    CategoryId = 1,
                    AccountId = 1,
                },
                new Post
                {
                    PostId = 4,
                    PostTitle = "dos amet",
                    PostBody = "To zanarkand",
                    ForumId = 1,
                    CategoryId = 1,
                    AccountId = 1,
                },
                new Post
                {
                    PostId = 5,
                    PostTitle = "Lol, I'm so random",
                    PostBody = "cheese",
                    ForumId = 1,
                    CategoryId = 1,
                    AccountId = 1,
                }
                );
            modelBuilder.Entity<Forum>().HasData(
                new Forum
                {
                    ForumId = 1,
                    ForumName = "Posto",
                    ForumDescription = "Forum for Posto...",
                    ForumRules = "There are no rules currently.",
                    ForumIconPath = "posto.png"
                },
                new Forum
                {
                    ForumId = 2,
                    ForumName = "TWEWY",
                    ForumDescription = "Built for the best of games",
                    ForumRules = "There are no rules currently.",
                    ForumIconPath = "posto.png"
                },
                new Forum
                {
                    ForumId = 3,
                    ForumName = "CIS236",
                    ForumDescription = "The MVC Template",
                    ForumRules = "There are no rules currently.",
                    ForumIconPath = "posto.png"
                },
                new Forum
                {
                    ForumId = 4,
                    ForumName = "Costco",
                    ForumDescription = "We love you",
                    ForumRules = "There are no rules currently.",
                    ForumIconPath = "posto.png"
                }
                );
        }
    }
}
