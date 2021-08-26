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
            DefaultClassStringJoin(modelBuilder, dc => dc.Description);
            DefaultClassStringJoin(modelBuilder, dc => dc.DescriptionTitle);
            DefaultClassStringJoin(modelBuilder, dc => dc.Equipment);
            DefaultClassStringJoin(modelBuilder, dc => dc.ClassSpellTitle);
            DefaultClassStringJoin(modelBuilder, dc => dc.ClassSpellDescription);
            DefaultClassStringJoin(modelBuilder, dc => dc.VariantsTitle);
            DefaultClassStringJoin(modelBuilder, dc => dc.VariantDescription);
            DefaultClassStringJoin(modelBuilder, dc => dc.VariantSpellsTitle);
            DefaultClassStringJoin(modelBuilder, dc => dc.VariantSpellsDescription);
            DefaultRaceStringJoin(modelBuilder, dc => dc.SubraceTitle);
            DefaultRaceStringJoin(modelBuilder, dc => dc.SubraceDescription);
            DefaultRaceStringJoin(modelBuilder, dc => dc.Description);
            DefaultRaceStringJoin(modelBuilder, dc => dc.DescriptionTitle);
            DefaultRaceStringJoin(modelBuilder, dc => dc.RacialSpellTitle);
            DefaultRaceStringJoin(modelBuilder, dc => dc.RacialSpellDescription);
            DefaultRaceStringJoin(modelBuilder, dc => dc.SubraceTrait);
            DefaultRaceStringJoin(modelBuilder, dc => dc.SubraceFeatureTitle);
            DefaultRaceStringJoin(modelBuilder, dc => dc.SubraceFeatureDescription);
        }
        public static void DefaultClassStringJoin(ModelBuilder md, System.Linq.Expressions.Expression<Func<DefaultClass, string[]>> test)
        {
            md.Entity<DefaultClass>()
            .Property(test)
            .HasConversion(
                v => string.Join("<next>", v),
                v => v.Split("<next>", StringSplitOptions.RemoveEmptyEntries));
        }
        public static void DefaultRaceStringJoin(ModelBuilder md, System.Linq.Expressions.Expression<Func<DefaultRace, string[]>> test)
        {
            md.Entity<DefaultRace>()
            .Property(test)
            .HasConversion(
                v => string.Join("<next>", v),
                v => v.Split("<next>", StringSplitOptions.RemoveEmptyEntries));
        }
        public static void DefaultBackgroundStringJoin(ModelBuilder md, System.Linq.Expressions.Expression<Func<DefaultRace, string[]>> test)
        {
            md.Entity<DefaultRace>()
            .Property(test)
            .HasConversion(
                v => string.Join("<next>", v),
                v => v.Split("<next>", StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
