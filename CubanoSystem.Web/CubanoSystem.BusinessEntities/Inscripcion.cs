using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubanoSystem.BusinessEntities
{
    public class Inscripcion
    {
        public Int32 Id { get; set; }

        public decimal MontoTotal { get; set; }
        
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }

        //public List<Curso> Curso { get; set; }
        public Cliente Cliente { get; set; }
        //public Promociones Promocion { get; set; }
        //public CronogramaPagos Cronograma { get; set; }

    }
}
