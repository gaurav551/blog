using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace blog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public Post Post {get; set;}
        public int PostId { get; set; }
        public string Text { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Username { get; set; }
        public string UserId {get;set;}
        public List<Reply> Replies {get; set;}

       
        public string PhotoName { get; set; }
    }
}
