using OnlineGuide_Server.Entities;
using System.Data.Entity;

namespace OnlineGuide_Server
{
    class OnlineGuideContext : DbContext
    {
        public DbSet<AccessType> AccessTypes { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Advertising> Advertisings { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
        public DbSet<TypeOfAdvertising> TypeOfAdvertisings { get; set; }
        public DbSet<TypeOfLocation> TypeOfLocations { get; set; }
        public DbSet<User> Users { get; set; }

        static OnlineGuideContext()
        {
            Database.SetInitializer(new OnlineGuideInitializer());
        }

        public OnlineGuideContext()
            : base("OnlineGuide_DB")
        { }
    }
}
