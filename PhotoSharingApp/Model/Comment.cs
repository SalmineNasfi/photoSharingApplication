using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhotoSharingApp.Model
{
    public class Comment
    {
        [DataType(DataType.MultilineText)]
        public int CommentID { get; set; }
        public String UserName { get; set; }
        [Required]
        [StringLength(250)]
        public String Subject { get; set; }
        public String Body { get; set; }
        public int PhotosID { get; set; }
        public virtual Photo Photo
        {
            get; set;
        }
    }
}