using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubanoSystem.BusinessEntities
{
    public class Caja
    {
        public Int32 Id { get; set; }
        public string NombreCaja { get; set; }
        public decimal MontoInicial { get; set; }
        public decimal MontoFinal { get; set; }
        public DateTime HoraApertura { get; set; }
        public DateTime HoraCierre { get; set; }
    }
}
