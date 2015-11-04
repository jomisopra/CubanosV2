using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubanoSystem.BusinessEntities
{
    public class Asistencia
    {
        public Int32 Id { get; set; }
        public bool Asistio { get; set; }
        //public Curso Curso { get; set; }
        public  Cliente Cliente { get; set; }
    }
}
