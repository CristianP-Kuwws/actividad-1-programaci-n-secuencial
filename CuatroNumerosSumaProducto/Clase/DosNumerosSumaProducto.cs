using System;

namespace CalcularNumerosSumaProducto.Clase
{
    public class DosNumerosSumaProducto
    {
        public void NumerosSumaProducto()
        {
            int num1 = 0;
            int num2 = 0;
            decimal suma = 0;
            decimal producto = 0;

            try
            {
                Console.WriteLine("Ingrese su primer numero aquí: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su segundo numero aquí: ");
                num2 = int.Parse(Console.ReadLine());

                suma = (num1 + num2);
                producto = (num1 * num2);

                Console.WriteLine($"El resultado de la suma es: {suma}");
                Console.WriteLine($"El resultado del producto es: {producto}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo un error inesperado: {ex.Message}");
            }
        }
    }
}