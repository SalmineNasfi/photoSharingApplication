﻿using PhotoSharingApp.Model;
using PhotoSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;


namespace PhotoSharingApp.Models
{
    public class PhotoSharingInitializer : DropCreateDatabaseAlways<PhotoSharingContext>
    {
        protected override void Seed(PhotoSharingContext context)
        {
         
            Photo photo = new Photo();
            photo.Title = "Test Photo";
            photo.Description = "test";
            photo.Owner = "dd";
            photo.PhotoFile = System.IO.File.ReadAllBytes("C:/Users/ASUS/Pictures/flower.jpg");
            photo.ImageMimeType = "image/jpeg";
            photo.CreatedDate = DateTime.Now;
            context.Photos.Add(photo);
            context.SaveChanges();
            List<Comment> comments = new List<Comment>();
            Comment comment = new Comment();
            comment.PhotosID = 1; comment.UserName = "dd";
            comment.Subject = "Test Comment";
            comment.Body = "This comment should appear in photo 1";
            comments.Add(comment);
            foreach (var c in comments)
            {
                context.Comments.Add(c);
            }
            
            context.SaveChanges();
           // base.Seed(context);     

        }
    }
}