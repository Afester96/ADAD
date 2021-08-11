using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AfroDungeonAndDragons.Models.CharacterCreator;
using Microsoft.Extensions.Configuration;
using AfroDungeonAndDragons.Data;
using AfroDungeonAndDragons.Models.DefaultInformation;

namespace AfroDungeonAndDragons.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Background> Backgrounds { get; set; }
        public DbSet<Alignment> Alignments { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<DefaultRace> DefaultRaces { get; set; }
        public DbSet<DefaultClass> DefaultClasses { get; set; }
        public DbSet<DefaultBackground> DefaultBackgrounds { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DefaultRace>().HasData(DefaultRaceList.GetRaceList());
            modelBuilder.Entity<DefaultClass>().HasData(DefaultClassList.GetClassList());
            modelBuilder.Entity<DefaultBackground>().HasData(DefaultBackgroundList.GetBackgroundList());
        }
    }
}
