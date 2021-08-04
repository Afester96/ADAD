using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AfroDungeonAndDragons.Models.CharacterCreator;
using Microsoft.Extensions.Configuration;

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
        public DbSet<CanCastSpells> CanCastSpellses { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<SpellCastingAbility> SpellCastingAbilities { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
    }
}
