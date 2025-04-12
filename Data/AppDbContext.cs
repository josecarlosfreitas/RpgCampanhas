using Microsoft.EntityFrameworkCore;
using RpgCampanhas.Models;

namespace RpgCampanhas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Campanha> Campanhas { get; set; }
        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<NPC> NPCs { get; set; }
        public DbSet<Local> Locais { get; set; }
        public DbSet<Historia> Historias { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Ficha3det> Ficha3Dets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração dos relacionamentos
            modelBuilder.Entity<Campanha>()
                .HasOne(c => c.Mestre)
                .WithMany(u => u.Campanhas)
                .HasForeignKey(c => c.MestreId);

            modelBuilder.Entity<Personagem>()
                .HasOne(p => p.Jogador)
                .WithMany(u => u.Personagens)
                .HasForeignKey(p => p.JogadorId);

            modelBuilder.Entity<Personagem>()
                .HasOne(p => p.Campanha)
                .WithMany(c => c.Personagens)
                .HasForeignKey(p => p.CampanhaId);

            modelBuilder.Entity<NPC>()
                .HasOne(n => n.Campanha)
                .WithMany(c => c.NPCs)
                .HasForeignKey(n => n.CampanhaId);

            modelBuilder.Entity<Local>()
                .HasOne(l => l.Campanha)
                .WithMany(c => c.Locais)
                .HasForeignKey(l => l.CampanhaId);

            modelBuilder.Entity<Historia>()
                .HasOne(h => h.Campanha)
                .WithMany(c => c.Historias)
                .HasForeignKey(h => h.CampanhaId);

            modelBuilder.Entity<Nota>()
                .HasOne(n => n.Campanha)
                .WithMany(c => c.Notas)
                .HasForeignKey(n => n.CampanhaId);

            modelBuilder.Entity<Nota>()
               .HasOne(n => n.Autor)
               .WithMany(u => u.Notas)
               .HasForeignKey(n => n.AutorId);

            modelBuilder.Entity<Ficha3det>()
                .HasOne(f => f.Personagem)
                .WithMany(p => p.Ficha3Dets)
                .HasForeignKey(f => f.PersonagemId);

            modelBuilder.Entity<Ficha3det>()
                .HasOne(f => f.Npc)
                .WithMany(c => c.Ficha3Dets)
                .HasForeignKey(f => f.NpcId);
        }
    }
}
