using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agos22Class
{
    public class Class1
    {
        public static void ExecuteExercise() {
            // EJERCICIO 8: Diseñar un algoritmo que, dados tres números enteros, calcule e imprima el promedio entre ellos. 

            Console.WriteLine("Ingrese por favor el primer numero entero");
            int ent1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese por favor el segundo numero entero");
            int ent2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese por favor el tercer numero entero");
            int ent3 = int.Parse(Console.ReadLine());

            int total = ent1 + ent2 + ent3;

            int prom = total/3;

            Console.WriteLine("El promedio de los tres numeros es: " + prom);


        }
    }
}
