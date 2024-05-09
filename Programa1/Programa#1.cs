using System;

namespace Programa1
{
    public class Programs
    {
        public static void Main(string[] args)
        {
            double lado;
            double perimetro;

            try
            {
                Console.WriteLine("Ingresar la longitud del lado del cuadrado: ");
                lado = Convert.ToDouble(Console.ReadLine());

                perimetro = lado * 4;
                Console.WriteLine("El perimetro del cuadrado es :" + perimetro);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"El programa dejo de funcionar por esta razon: {ex.Message}");
             
            }
        }
    }
}