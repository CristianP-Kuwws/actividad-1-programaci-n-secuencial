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

            Console.WriteLine("Ingrese su primer numero aqui: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su segundo numero aqui: ");
            num2 = int.Parse(Console.ReadLine());

            suma = (num1 + num2);
            producto = (num1 * num2);

            Console.WriteLine($"El resultado su suma es: {suma}");
            Console.WriteLine($"El resultado de su producto es: {producto}");

        }
    }
}

