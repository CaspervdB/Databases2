using System.Data.Entity;

namespace Databases2_Eindopdracht
{
    class EntityFramework : DbContext
    {
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Episode> Episodes { get; set; }
        public virtual DbSet<Prefrences> Prefrences { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<Subtitles> Subtitles { get; set; }
        public virtual DbSet<Title> Title { get; set; }
        public virtual DbSet<User_Account> User_Accounts { get; set; }
        public virtual DbSet<Userview> Userviews { get; set; }
        public virtual DbSet<Watchlist> Watchlists { get; set; }
        public virtual DbSet<Wrong_Attempt> Wrong_Attempts { get; set; }

        public EntityFramework() : base("ConnectionName")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<EntityFramework>());
        }
    }
}
