using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [MinLength(10, ErrorMessage = "Title must be at least 10 characters")]
        [MaxLength(50, ErrorMessage = "Title must be less than 50 characters")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Content is required")]
        [MinLength(300, ErrorMessage = "Content must include at least 300 characters")]
        [MaxLength(3000, ErrorMessage = "Content must include less than 3000 characters")]
        public string Content { get; set; }

        public int? PhotoId { get; set; }
    }
}
