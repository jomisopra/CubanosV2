using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CubanoSystem.BusinessEntities;
using CubanoSystem.Repository;

namespace GenerateDB
{
     class Program
    {
        static void Main(string[] args)
        {
            var empleado = new Empleado()
            {
               Nombres = "fredy",
               Apellidos = "chilon",
               DNI = "85555559",
               Salario= 2000,
               Sexo = true,
               Cargo="Instructor",
               FechaNacimiento = DateTime.Parse("15-03-1991"),
               Direccion = "av heroes del cenepa",
               Telefono = "076-792941",
               Celular = "955915732",
               Email = "manu.vasquez@outlook.com",
               
            };

            var curso = new Curso()
            {
                
                NombreCurso="Aerobicos",
                Descripcion="Rutinas Varias de ejercicios",
                FechaIni=DateTime.Parse("15-10-2015"),
                FechaFin = DateTime.Parse("15-12-2015"),
                Precio=230


            };
            var cliente = new Cliente()
            {
                Id = 6,
                DNI = "85555559",
                Nombres = "fredy",
                Apellidos = "chilon",
                Sexo = true,
                FechaNacimiento = DateTime.Parse("15-03-1991"),
                Direccion = "av heroes del cenepa",
                Telefono = "076-792941",
                Celular = "955915732",
                Email = "manu.vasquez@outlook.com"
                
            };

            Console.WriteLine("Generando base de datos");
            var context = new CubanoSystemContext();
            context.Cliente.Add(cliente);
            context.SaveChanges();
            Console.WriteLine("Base de datos creada ...OK!!!");
            Console.ReadLine();

            //var contexto = new CubanoSystemContext();
            //contexto.Database.Create();
            //contexto.SaveChanges();
            //Console.WriteLine("Base de datos creada ...OK!!!");
            //Console.ReadKey();
        }
    }
}

