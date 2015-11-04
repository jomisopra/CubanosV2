using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubanoSystem.BusinessEntities
{
    public class Usuario
    {
        public Int32 Id { get; set; }
        public string CodigoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }

        //public Empleado Empleado { get; set; }
    }
}
