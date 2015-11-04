using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubanoSystem.BusinessEntities
{
    public class Pagos
    {
        public Int32 Id { get; set; }
                
        
        public DateTime FechaVencimiento { get; set; }
        public string concepto { get; set; }
        public int NumeroCuota { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }

        //public CronogramaPagos Cronograma { get; set; }
    }
}
