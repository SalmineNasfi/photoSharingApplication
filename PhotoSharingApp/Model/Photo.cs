﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PhotoSharingApp.Model
{
    public class Photo
    {

        public int PhotoID { get; set; }
        public String Title { get; set; }
        [DisplayName("Picture")]
        public String Description { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayName("Created Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
        public String Owner { get; set; }
        public byte[] PhotoFile { get; set; }
        [DataType(DataType.MultilineText)]
        ICollection<Comment> Commentaires { get; set; }
        public string ImageMimeType { get; set; }
        public string UserName { get; internal set; }
    }
}