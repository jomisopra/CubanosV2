using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubanoSystem.BusinessEntities
{
    public class Cliente:Persona
    {
      //public Usuario Usuario { get; set; }
       //public Int32 UsuarioId { get; set; }
       public List<Asistencia> Asistencia { get; set; }
       public List<Inscripcion> Inscripcion { get; set; }
    }
}
