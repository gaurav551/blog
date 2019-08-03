using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace blog.Models
{
    public class Reply
    {
        public int Id { get; set; }
        public string Message { get; set; }
         public Comment Comment {get; set;}
         public int CommentId {get; set;}
         public string Username { get; set; }

         
    }
}