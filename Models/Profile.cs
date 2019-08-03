using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace blog.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PhotoName { get; set; }

        public string NickName { get; set; }

        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Biography { get; set; }
        public string PostType { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        public string Interests { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

     
    }
}
