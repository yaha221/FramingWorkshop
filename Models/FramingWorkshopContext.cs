using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace FramingWorkshop.Models
{
    public class FramingWorkshopContext : DbContext
    {
        public FramingWorkshopContext() : base("DeafultConnection") { }
        public DbSet<Frame> Frames { get; set; }
        public DbSet<Cardboard> Cardboards { get; set; }
        public DbSet<Hanger> Hangers { get; set; }
        public DbSet<Periphery> Peripheries { get; set; }
    }
}
