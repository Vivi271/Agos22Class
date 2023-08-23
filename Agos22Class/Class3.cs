using System;

namespace Agos22Class
{
    public class Class3
    {
        public static void ExecuteExercise3()
        {
            int num;

            while (true)
            {
                Console.WriteLine("Por favor ingrese un número entre 10 y 50:");
                num = int.Parse(Console.ReadLine());

                if (num >= 10 && num <= 50)
                {
                    Console.WriteLine("El número que usted ingresó es: " + num);
                    Console.WriteLine();

                    double dismin = num * 0.85;

                    Console.WriteLine("Al disminuir el número en un 15%, nos da: " + dismin);
                    break; // Salir del bucle cuando el número sea válido
                }
                else
                {
                    Console.WriteLine("El número debe estar en el rango de 10 a 50. Por favor, ingrese nuevamente.");
                }
            }
        }
    }
}
