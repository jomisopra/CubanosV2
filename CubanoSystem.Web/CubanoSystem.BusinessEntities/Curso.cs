using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubanoSystem.BusinessEntities
{
    public class Curso
    {
        public Int32 Id { get; set; }
        public string NombreCurso { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public Decimal Precio { get; set; }
        
        //public List<Asistencia> Asistencia { get; set; }
        //public Horario Horario { get; set; }
        //public Empleado Empleado { get; set; }
    }
}
