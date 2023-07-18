using Entidades;
using System.Linq.Expressions;

namespace ejemploClasesProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crear y asignar propiedades mediante la instancia
            var jose = new Empleado();
            jose.Nombre = "Jose";
            jose.FechaDeAlta = new DateTime(2021, 01, 10);
            jose.Salario = 20000;
            jose.Alta = true;
            jose.fijarNivel(Empleado.Nivel.bueno);
            
            //Crear y asignar propiedades directamente
            var maria = new Empleado()
            {
                Nombre = "Maria",
                FechaDeAlta = new DateTime(2022, 03, 01),
                Salario = 20000,
                Alta = true
            };
            maria.fijarNivel(Empleado.Nivel.bueno);

            //Crear intancias y pasarle parametros al constructor
            var juan = new Empleado("Juan",
                                    20000, 
                                    new DateTime(2023,01,15), 
                                    true);
            juan.fijarNivel(Empleado.Nivel.excelente);
            
            var lista = new List<Empleado>();
            lista.Add(jose);
            lista.Add(maria);
            lista.Add(juan);

            foreach (var empleado in lista)
            {
                 empleado.calcularAumentoDeSalario();
            }
        }
    }
}