using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_5_Skeleton2.Models;

namespace MVC_5_Skeleton2.DAL
{
    public class GameInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<GameContext>
    {
        protected override void Seed(GameContext context)
        {
            var games = new List<Game>
            {
                new Game{Name="World of Warcraft", Desc="MMORPG", Rating=4.5, Price=49.99},
                new Game{Name="StarCraft II", Desc="Strategy", Rating=4.0, Price=30.00},
                new Game{Name="Diablo III", Desc="RPG Dungeon Crawler", Rating=4.5, Price=29.99},
                new Game{Name="League of Legends", Desc="DOTA", Rating=4.0, Price=0.00},
                new Game{Name="Rocket League", Desc="Cars with rockets playing soccer", Rating=4.7, Price=19.99},
                new Game{Name="Terraria", Desc="2D Minecraft", Rating=4.5, Price=19.99},
                new Game{Name="Minecraft", Desc="Low Rez 3D Legos", Rating=4.5, Price=19.99},
                new Game{Name="World of Warcraft", Desc="MMORPG", Rating=4.5, Price=49.99},
                new Game{Name="World of Warcraft", Desc="MMORPG", Rating=4.5, Price=49.99},
            };

            games.ForEach(g => context.Games.Add(g));
            context.SaveChanges();
        }
    }
}