using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompararCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ****************************************************************************************************************
            // Ejercicio 1: Comparación de correos electrónicos
            // Este ejercicio solicita al usuario que ingrese su correo electrónico y luego lo confirme. Luego, compara ambos correos
            // electrónicos para asegurarse de que coincidan y muestra un mensaje de éxito o error en consecuencia.

            // Solicitar al usuario que ingrese su correo electrónico
            Console.Write("Ingresa tu correo electrónico: ");
            string correoElectronico1 = Console.ReadLine();

            // Solicitar al usuario que confirme su correo electrónico
            Console.Write("Confirma tu correo electrónico: ");
            string correoElectronico2 = Console.ReadLine();

            // Comprobar si los correos electrónicos coinciden
            bool coincidenCorreos = correoElectronico1.Equals(correoElectronico2);

            // Mostrar mensaje de éxito o error dependiendo del resultado de la comparación
            if (coincidenCorreos)
            {
                Console.WriteLine("Registro exitoso."); // Si los correos coinciden
            }
            else
            {
                Console.WriteLine("Error: Los correos electrónicos no coinciden."); // Si los correos no coinciden
            }

            // Separador****************************************************************************************************************
            Console.WriteLine("// ****************************************************************************************************************");

        
            // Ejercicio 2: Comparación de números
            // En este ejercicio, se proporciona un número original. El usuario debe memorizarlo, ingresarlo y se verifica si coincide
            // con el número original.

            // Definir un número original para comparar
            string numeroOriginal = "123456";

            // Solicitar al usuario que memorice y presione una tecla cuando esté listo
            Console.Write($"Memoriza el siguiente número: {numeroOriginal} y presiona enter cuando estés listo");
            Console.ReadKey();
            Console.Clear();

            // Solicitar al usuario que ingrese un número
            Console.Write("Ingresa el número: ");
            string numeroIngresado = Console.ReadLine();

            // Comprobar si el número ingresado coincide con el número original
            if (numeroOriginal.Equals(numeroIngresado))
            {
                Console.WriteLine("Muy bien, has ingresado el número correctamente."); // Si el número ingresado es correcto
            }
            else
            {
                Console.WriteLine("¡Error! El número ingresado no coincide."); // Si el número ingresado no es correcto
            }

            // Separador****************************************************************************************************************
            Console.WriteLine("// ****************************************************************************************************************");

            // ****************************************************************************************************************
            // Ejercicio 3: Comparación ordinal de correos electrónicos
            // Similar al primer ejercicio, pero en este caso, la comparación de los correos electrónicos se realiza sin tener en cuenta
            // las diferencias de mayúsculas y minúsculas.

            // Solicitar al usuario que ingrese su correo electrónico
            Console.Write("Ingresa tu correo electrónico: ");
            string correo1 = Console.ReadLine();

            // Solicitar al usuario que confirme su correo electrónico
            Console.Write("Ingresa tu correo electrónico nuevamente: ");
            string correo2 = Console.ReadLine();

            // Comprobar si los correos electrónicos coinciden, ignorando mayúsculas/minúsculas
            bool correosIguales = correo1.Equals(correo2, StringComparison.OrdinalIgnoreCase);

            // Mostrar mensaje de éxito o error dependiendo del resultado de la comparación
            if (correosIguales)
            {
                Console.WriteLine("¡Registro exitoso! ¡Has ingresado correctamente tus correos electrónicos!"); // Si los correos coinciden (ignorando mayúsculas/minúsculas)
            }
            else
            {
                Console.WriteLine("¡Error! Los correos electrónicos ingresados no coinciden."); // Si los correos no coinciden
            }


        }
    }
}
