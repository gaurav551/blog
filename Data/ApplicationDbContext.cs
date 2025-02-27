﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using blog.Models;
using Microsoft.AspNetCore.Identity;

namespace blog.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Post> Posts {get; set; }
        public DbSet<Comment> Comments {get; set;}

        public DbSet<Contact> Contacts {get; set;}

        public DbSet<Reply> Replies {get; set;}

        public DbSet<Profile> Profiles {get; set;}
        }
    }

