using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RepairApp.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [MaxLength(50)]
        public string CoverImg { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public DateTime CreateDate { get; set; }

        public List<BlogImage> BlogImages { get; set; }
        public List<BlogComment> BlogComments { get; set; }
        public List<TagToBlog> TagToBlogs { get; set; }


    }
}
