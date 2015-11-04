using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubanoSystem.BusinessEntities
{
    public class Horario
    {
        public Int32 Id { get; set; }
        public string Dias { get; set; }
        public DateTime HoraIni { get; set; }
        public DateTime HoraFin { get; set; }

        //public Curso Curso { get; set; }
    }
}
