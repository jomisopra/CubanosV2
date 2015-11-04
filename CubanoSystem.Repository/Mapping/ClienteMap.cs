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
    public class ClienteMap:EntityTypeConfiguration<Cliente>
    {
        public ClienteMap() 
        {

            

            /*this.HasRequired(u => u.Usuario)
                .WithRequiredDependent();*/

            this.ToTable("Clientes");
        
        
        }
    }
}
