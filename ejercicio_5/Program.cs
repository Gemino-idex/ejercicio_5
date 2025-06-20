using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esto es definir
            int n1, n2, suma, resta, multi;
            //esto es el texto pidiendo el primer número
            Console.WriteLine("Ingrese el primer número:");
            //esto es para pedir el primer valor
            n1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            n2 = Convert.ToInt32(Console.ReadLine());
            //estos son los procedimientos de los ejercicios
            suma = n1 + n2;
            resta = n1-n2;
            multi = n1 * n2;
            //esta forma es para poner la respuesta abajo
            Console.WriteLine("La suma es:");
            Console.WriteLine(suma);
            //esta es la forma en la que la respuesta salga seguida
            Console.WriteLine("La resta es: "+resta);
            //esta es la forma en la que puedes poner varias respuestas en una linea
            Console.WriteLine("La multiplicación es: {0}, la suma es: {1}", multi, suma);
        }
    }
}
