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
    public class CronogramaPagosMap:EntityTypeConfiguration<CronogramaPagos>
    {
        public CronogramaPagosMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.NumeroTotalCuotas)
                .HasColumnType("int")
                .IsRequired();

            this.ToTable("CronogramaPagos");
        
        }
    }
}
