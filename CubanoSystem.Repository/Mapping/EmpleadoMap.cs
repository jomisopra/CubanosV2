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
    public class EmpleadoMap : EntityTypeConfiguration<Empleado>
    {
        public EmpleadoMap() 
        {
           
            //this.Property(p => p.Salario)
            //    .HasColumnType("decimal(6,2)")
            //    .IsRequired();

            //this.Property(p => p.Cargo)
            //    .HasMaxLength(200)
            //    .IsRequired();

           
            this.ToTable("Empleados");
         
        }
    }
}
