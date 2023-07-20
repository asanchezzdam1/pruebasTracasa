namespace ejemploHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Aitor");
            Trabajador trabajador = new Trabajador("Uxue");
            Administrador administrador = new Administrador("Alain");
            var empleados = new List<Empleado>();
            empleados.Add(empleado);
            empleados.Add(trabajador);
            empleados.Add(administrador);
            foreach(var item in empleados)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}