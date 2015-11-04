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
    public class CursoMap:EntityTypeConfiguration<Curso>
    {
        public CursoMap()
        {
            this.HasKey(c => c.Id);
                

            this.Property(c => c.NombreCurso)
                .HasMaxLength(100)
                .IsRequired();

            this.Property(c => c.Descripcion)
               .HasMaxLength(250)
               .IsRequired();

            this.Property(c => c.FechaIni)
                .HasColumnType("date")
                .IsRequired();

            this.Property(c => c.FechaFin)
                .HasColumnType("date")
                .IsRequired();

            this.Property(c => c.Precio)
                .HasColumnType("decimal(6,2)")
                .IsRequired();

            this.ToTable("Cursos");
        
        
        

        
               
        
        }
    }
}
