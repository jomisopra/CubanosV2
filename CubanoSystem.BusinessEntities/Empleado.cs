using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubanoSystem.BusinessEntities
{
    public class Empleado:Persona
    {
       public decimal Salario { get; set; }
       public string Cargo { get; set; }

       public Usuario Usuario { get; set; }
       
    }
}
