using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CubanoSystem.BusinessEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace CubanoSystem.Repository.Mapping
{
    public class InscripcionMap:EntityTypeConfiguration<Inscripcion>
    {
        public InscripcionMap()
        {
            this.HasKey(i => i.Id);
            //this.Property(i => i.Id)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(i => i.MontoTotal)
                .HasColumnType("decimal(6,2)")
                .IsRequired();

            this.Property(i => i.FechaIni)
                .HasColumnType("date")
                .IsRequired();

            this.Property(i => i.FechaFin)
               .HasColumnType("date")
               .IsRequired();

            this.ToTable("Inscripciones");

            //this.HasRequired(i => i.Persona)
            //    .WithMany(p => p.Inscripciones)
            //    .HasForeignKey(i => i.IdPersona)
            //    .WillCascadeOnDelete(false);
                
        }
    }
}
