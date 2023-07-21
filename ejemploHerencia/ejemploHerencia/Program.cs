namespace ejemploHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Aitor");
            Trabajador trabajador = new Trabajador("Uxue");
            Trabajador trabajador1 = new Trabajador("Aimar", "Mañana", false);
            Trabajador trabajador2 = new Trabajador("Julen", "Noche", true, "Conasa");
            Administrador administrador = new Administrador("Alain");
            Administrador administrador1 = new Administrador("Amaia", false);
            Administrador administrador2 = new Administrador("Beñat", true, 23);
            var empleados = new List<Empleado>();
            empleados.Add(empleado);
            empleados.Add(trabajador);
            empleados.Add(trabajador1);
            empleados.Add(trabajador2);
            empleados.Add(administrador);
            empleados.Add(administrador1);
            empleados.Add(administrador2);
            var resultado = from emp in empleados where emp.nombre.ToLower().StartsWith("j") orderby emp.nombre ascending select emp;
            foreach(var emp  in resultado)
                emp.CalculoVacaciones();
            foreach (var emp in empleados)
                Console.WriteLine(emp.ToString());
            try
            {
                if (administrador2.plaza)
                {
                    Console.WriteLine(administrador2.PlazaParking());
                }
            }
            catch (Exception ex)
            {

                //throw;
            }
            Administrador administrador3 = new Administrador("Julene", false);
            empleados.Add(administrador3);
            var resultado1 = from emp in empleados where emp.nombre.ToLower().StartsWith("j") orderby emp.nombre ascending select emp;
            foreach (var emp in resultado1)
                emp.CalculoVacaciones();
            foreach (var emp in empleados)
                Console.WriteLine(emp.ToString());


        }
    }
}