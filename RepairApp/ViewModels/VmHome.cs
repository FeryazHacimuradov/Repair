using RepairApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepairApp.ViewModels
{
    public class VmHome:VmLayout
    {
        public List<Blog> Blogs { get; set; }
        public Blog Blog { get; set; }
    }
}
