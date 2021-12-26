using Microsoft.EntityFrameworkCore;
using RepairApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepairApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorToBlog> AuthorToBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<EstimateList> EstimateLists { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<SendedMessage> SendedMessages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagToBlog> TagToBlogs { get; set; }
        public DbSet<WoringProsessStep> WoringProsessSteps { get; set; }
        public DbSet<WorksCount> WorksCounts { get; set; }




    }
}
