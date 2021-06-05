using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.BlogComment
{
    public class BlogCommentCreate
    {
        public int BlogCommentId { get; set; }

        public int? ParentBlogCommentId { get; set; }

        public int BlogId { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [MinLength(10, ErrorMessage = "Content must include at least 10 characters")]
        [MaxLength(300, ErrorMessage = "Content must include less than 300 characters")]
        public string Content { get; set; }
    }
}
