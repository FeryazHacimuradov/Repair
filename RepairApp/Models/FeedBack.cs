using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepairApp.Models
{
    public class FeedBack
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string FullName { get; set; }

        [MaxLength(100)]
        public string Position { get; set; }

        [MaxLength(100)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string Message { get; set; }
    }
}
