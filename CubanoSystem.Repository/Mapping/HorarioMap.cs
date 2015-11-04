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
    public class HorarioMap:EntityTypeConfiguration<Horario>
    {
        public HorarioMap()
        {
            this.HasKey(h => h.Id);

            this.Property(h => h.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(h => h.Dias)
                .HasMaxLength(150)
                .IsRequired();

            this.Property(h => h.HoraIni)
                .HasColumnType("datetime")
                .IsRequired();

            this.Property(h => h.HoraFin)
               .HasColumnType("datetime")
               .IsRequired();

            this.ToTable("Horarios");

            
        
        }
    }
}
