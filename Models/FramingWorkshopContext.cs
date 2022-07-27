using System.Data.Entity;

namespace FramingWorkshop.Models
{
    /// <summary> Контекст данных приложения Framing Worckshop </summary>
    internal class FramingWorkshopContext : DbContext
    {
        internal FramingWorkshopContext() : base("DefaultConnection") { }
        internal DbSet<Frame> Frames { get; set; }
        internal DbSet<Cardboard> Cardboards { get; set; }
        internal DbSet<Hanger> Hangers { get; set; }
        internal DbSet<Periphery> Peripheries { get; set; }

    }
}
