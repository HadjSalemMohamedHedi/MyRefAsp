using Core.Entities.Cours.DB;
using Core.Entities.Departement.DB;
using Core.Entities.Personnes.Etudiant.DB;
using Core.Entities.Personnes.Professeur.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Shared
{
    public class myDbContext : DbContext
    {
        public myDbContext(DbContextOptions<myDbContext> options):base(options) { 

        }

        public DbSet<Etudiant_C> Etudiant_C { get; set; }
        public DbSet<Cours_C> Cours_C { get; set; }
        public DbSet<Departement_C> Departement_C { get; set; }
        public DbSet<Professeur_C> Professeur_C { get; set; }

        public DbSet<ProfDeparts> ProfDeparts { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<ProfDeparts>()
                .HasOne(pd => pd.Professeur)
                .WithMany(p => p.ProfDeparts)
                .HasForeignKey(pd => pd.ID_Prof);

            modelBuilder.Entity<ProfDeparts>()
                .HasOne(pd => pd.Departement)
                .WithMany(d => d.ProfDeparts)
                .HasForeignKey(pd => pd.ID_Departement);


        
        }

   }
}
