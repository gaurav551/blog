using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace blog.Models
{
    public class Post
    {
    public int Id { get; set; } 

    public string UserId { get; set; }
    public string Category { get; set; }
    
    public string Heading { get; set; }
    public string Description { get; set; }
    public string PhotoName { get; set; }

      public string UserName {get; set;}
     
     public int Point {get; set;}
      public List<Comment> Comments { get; set; }
      public int CommentsId {get; set;}

     public DateTime Date { get; set; } = DateTime.Now; 

    
    }
}