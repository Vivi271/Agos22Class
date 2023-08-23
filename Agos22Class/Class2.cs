using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agos22Class
{
    public class Class2
    {
        public static void ExecuteExercise2()
        //Diseñe un algoritmo para ingresar dos palabras (A, B) y luego realice el intercambio de sus valores. Finalmente mostrar el contenido de A y de B. 
        {
            Console.WriteLine("Ingrese por favor la palabra A");
            string A = Console.ReadLine();
            Console.WriteLine("Ingrese por favor la palabra B");
            string B = Console.ReadLine();
            Console.WriteLine();    

            Console.WriteLine("El contenido actual de A es: " + A);
            Console.WriteLine("El contenido actual de B es :" + B);
            Console.WriteLine();
            Console.WriteLine();

            string A1 = A;

            A = B;
            B = A1;

            Console.WriteLine("El contenido actualizado de A es: " + A);
            Console.WriteLine("El contenido actualizado de B es: " + B);

        }
    }
}
