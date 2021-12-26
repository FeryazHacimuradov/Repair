using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepairApp.Models
{
    public class WoringProsessStep
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Icon { get; set; }
    }
}
