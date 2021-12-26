using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RepairApp.Models
{
    public class BlogComment
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string CommentSubject { get; set; }

        [Column(TypeName = "ntext")]
        public string Comment { get; set; }

        [MaxLength(100)]
        public string UserName { get; set; }

        [MaxLength(100)]
        public string UserEmail { get; set; }

        [MaxLength(100)]
        public string UserImg { get; set; }

        [ForeignKey("BlogComment")]
        public int CommentId { get; set; }
        public BlogComment blogComment { get; set; }
        public List<BlogComment> BlogComments { get; set; }

        [ForeignKey("Blog")]
        public int BlogId { get; set; }

    }
}
