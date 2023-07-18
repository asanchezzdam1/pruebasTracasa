namespace Entidades
{
    /*
        * TIPOS DE CLASES * 
        * https://learn.microsoft.com/es-es/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
        * public - Visible en todo el proyecto
        * private - No es visible
        * protected -  
        * internal - 
     */
    public class Empleado
    {
        public Empleado()
        {

        }
        public Empleado(string nombre, double salario, DateTime fechaAlta, bool alta)
        {
            Nombre = nombre;
            Salario = salario;
            FechaAlta = fechaAlta;
            Alta = alta;
        }

        public string Nombre { get; set; }
        public double Salario { get; set; }
        public DateTime FechaAlta { get; }
        public DateTime FechaDeAlta { get; set; }
        public bool Alta { get; set; }

        public void calcularAumentoDeSalario()
        {
            throw new NotImplementedException();
        }

        public enum Nivel
        {
            normal,
            bueno,
            excelente
        }
        private Nivel nivel;
        public void fijarNivel(Nivel nivel)
        {
            this.nivel = nivel;
        }
    }
}
