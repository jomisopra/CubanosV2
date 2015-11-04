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
    public class UsuarioMap:EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        { 
           this.HasKey(u => u.Id);

           this.Property(u => u.Id)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

           this.Property(u => u.CodigoUsuario)
               .HasColumnType("nchar(4)");
               //IsRequired();

           this.Property(u => u.NombreUsuario)
               .HasMaxLength(30);
              // .IsRequired();

           this.Property(u => u.Password)
              .HasMaxLength(30);
              //.IsRequired();

           this.HasRequired(u => u.CodigoUsuario);

           this.ToTable("Usuarios");

        }
    }
}
