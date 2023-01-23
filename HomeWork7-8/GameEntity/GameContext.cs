using BECodeFirst;
using System;
using System.Data.Entity;
using System.Linq;

namespace GameEntity
{
    public class GameContext : DbContext
    {
        public DbSet<Game> Game { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<StyleGame> GameStyle { get; set; }
        public DbSet<GameMode> GameMode { get; set; }

        public GameContext(string connection) : base(connection)
        {

        }

    }
}