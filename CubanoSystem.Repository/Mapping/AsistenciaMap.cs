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
    public class AsistenciaMap:EntityTypeConfiguration<Asistencia>
    {
        public AsistenciaMap()
        {
            this.HasKey(a => a.Id);

            this.Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a => a.Asistio)
                .HasColumnType("bit");

            this.ToTable("Asistencias");
        }
        
    }
}
