﻿using System;
using System.Data.Entity;
using PhotoSharingApp.Model;
namespace PhotoSharingApp.Models
{
    public class PhotoSharingContext : DbContext
    {

        public DbSet<Photo> Photos { get; set; }
      
        public DbSet <Comment> Comments { get; set; }

    };
}