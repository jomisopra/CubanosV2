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
    public class PromocionesMap:EntityTypeConfiguration<Promociones>
    {
        public PromocionesMap()
        {
            this.HasKey(p => p.Id);

            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Codigo)
                .HasColumnType("nchar(4)")
                .IsRequired();

            this.Property(p => p.Nombre)
                .HasMaxLength(200)
                .IsRequired();

            this.Property(p => p.Descripcion)
                .HasMaxLength(250)
                .IsRequired(); 
            
            this.Property(p => p.Precio)
                .HasColumnType("decimal(6,2)")
                .IsRequired();

            this.ToTable("Promociones");
        
        }
        
    }
}
