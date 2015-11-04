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
    public class PersonaMap:EntityTypeConfiguration<Persona>
    {
        public PersonaMap()
        {
            //key
             this.HasKey(p => p.Id);
            
            //Properties
             this.Property(p => p.Id)
                 .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

             this.Property(p => p.DNI)
                 .HasMaxLength(8)
                 .IsRequired();

             this.Property(p => p.Nombres)
                 .HasMaxLength(250)
                 .IsRequired();

             this.Property(p => p.Apellidos)
                 .HasMaxLength(250)
                 .IsRequired();

             this.Property(p => p.Sexo)
                 .HasColumnType("bit")
                 .IsRequired();

             this.Property(p => p.FechaNacimiento)
                  .HasColumnType("date")
                  .IsRequired();

             this.Property(p => p.Direccion)
                  .HasMaxLength(250);
                  
             this.Property(p => p.Telefono)
                  .HasMaxLength(30);

             this.Property(p => p.Celular)
                  .HasMaxLength(250);


             this.Property(p => p.Email)
                  .HasMaxLength(150);

             //this.Property(p => p.Salario)
             //    .HasColumnType("decimal(6,2)")
             //    .IsRequired();

             //this.Property(p => p.Cargo)
             //    .HasMaxLength(200)
             //   .IsRequired();




             //Tabla

            this.ToTable("Personas");
             //Map<Cliente>(c=>c.Requires("Tipo").HasValue(0));

             //Map<Empleado>(e => e.Requires("Tipo").HasValue(1));

            //Relaciones

                   
        }
    }
}
