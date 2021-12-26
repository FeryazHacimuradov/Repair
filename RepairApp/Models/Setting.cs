using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepairApp.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Logo { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        [MaxLength(100)]
        public string OpenTime { get; set; }

        [MaxLength(200)]
        public string FooterAboutText { get; set; }

        [MaxLength(200)]
        public string HomeSubHeader { get; set; }

        [MaxLength(200)]
        public string HomeHeader { get; set; }

        [MaxLength(500)]
        public string HomeDescription { get; set; }

        [MaxLength(50)]
        public string HomeImage { get; set; }

        [MaxLength(50)]
        public string HomeBgImage { get; set; }
    }
}
