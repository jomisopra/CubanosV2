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
    public class PagosMap:EntityTypeConfiguration<Pagos>
    {
        public PagosMap()
        {
            this.HasKey(p => p.Id);

            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.FechaVencimiento)
                .HasColumnType("date")
                .IsRequired();

            this.Property(p => p.concepto)
               .HasMaxLength(100)
               .IsRequired();

            this.Property(p => p.NumeroCuota)
               .HasColumnType("int")
               .IsRequired();

             this.Property(p => p.Monto)
               .HasColumnType("decimal(6,2)")
               .IsRequired();

             this.Property(p => p.NumeroCuota)
               .HasColumnType("int")
               .IsRequired();

             this.Property(p => p.FechaPago)
                .HasColumnType("datetime")
                .IsRequired();

             this.ToTable("Pagos");
              
        }
        
    }
}
