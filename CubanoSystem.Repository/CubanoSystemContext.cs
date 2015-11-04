using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CubanoSystem.BusinessEntities;
using CubanoSystem.Repository.Mapping;

namespace CubanoSystem.Repository
{
    public class CubanoSystemContext:DbContext
    {
        public CubanoSystemContext()
        { 
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CubanoSystemContext>());
            
        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<CronogramaPagos> CronogramaPago { get; set; }
        //public DbSet<Curso> Curso { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        //public DbSet<Horario> Horario { get; set; }
        //public DbSet<Inscripcion> Inscripcion { get; set; }
        //public DbSet<Pagos> Pago { get; set; }
        //public DbSet<Promociones> Promociones { get; set; }
       // public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonaMap());
            modelBuilder.Configurations.Add(new EmpleadoMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new AsistenciaMap());
            modelBuilder.Configurations.Add(new CronogramaPagosMap());
            //modelBuilder.Configurations.Add(new CursoMap());
            //modelBuilder.Configurations.Add(new HorarioMap());
           //modelBuilder.Configurations.Add(new InscripcionMap());
            //modelBuilder.Configurations.Add(new PagosMap());
            //modelBuilder.Configurations.Add(new PromocionesMap());
            //modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}
