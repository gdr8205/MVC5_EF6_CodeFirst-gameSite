using MVC_5_Skeleton2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVC_5_Skeleton2.DAL
{
    public class GameContext : DbContext
    {
        public GameContext(): base("GameContext")
        {

        }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}