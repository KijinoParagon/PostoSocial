namespace PostoSocial.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostBody { get; set; }
        public int ForumId { get; set; }
        public int CategoryId { get; set; }
        public int AccountId { get; set; }
        public Account? User { get; set; }
        public Forum? Forum { get; set; }

    }
}
