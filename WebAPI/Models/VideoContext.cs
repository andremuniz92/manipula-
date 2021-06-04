using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class VideoContext : DbContext
    {
        public VideoContext(DbContextOptions<VideoContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Video> Videos { get; set; }
    }
}
