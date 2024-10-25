using System.ComponentModel.DataAnnotations;

namespace PostoSocial.Models
{
    public class Forum
    {
        [Required]
        public int ForumId { get; set; }
        [Required]
        public string ForumName { get; set; }

        public string? ForumDescription { get; set; }
        public string? ForumRules { get; set; }
        public string ForumIconPath { get; set; }
    }
}
