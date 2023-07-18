namespace HolaMundoEjemploProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nom = "Juan".ToUpper();
            nom = nom.ToUpper();
            nom = null;
			try
			{
                Console.WriteLine("¡Hola, Mundo!".ToUpper() + " " + nom);
            }
            catch (Exception ex)
			{
                Console.WriteLine("Se ha producido un error: " + ex.Message.ToString());
                //throw;
            }
			
        }
    }
}