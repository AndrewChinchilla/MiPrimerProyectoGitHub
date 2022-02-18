using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyectoGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ANDREW HENRY STIVE CHINCHILLA CHINCHILLA
            //0905-21-11296
            //SECCIÓN "B"


            //Ejercicio 1
            Console.WriteLine("\t\tBIENVENIDO");
            Console.WriteLine("\n");
            byte edad;
            Console.WriteLine("\tEJERCICIO 1 - EDAD -");
            Console.WriteLine("\n\tPor Favor Ingresa tu edad:");
            edad = byte.Parse(Console.ReadLine());
            Console.WriteLine("\n\tUy!... No aparentas: "+edad+" años. :)");
            Console.WriteLine("\n");
            Console.WriteLine("\n");



            //Ejercicio 2

            byte num1, num2;
            ushort Result;
            Console.WriteLine("\tEJERCICIO 2 - MULTIPLICACIÓN DE NUMEROS -");
            Console.WriteLine("\n\tPor favor ingrese el primer numero a operar: ");
            num1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("\n\tPor favor ingrese el segundo numero a operar: ");
            num2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Result=(ushort)(num1 * num2);
            Console.WriteLine("\tEl resultado de su operación es :");
            Console.WriteLine("\t-> "+Result);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine();



            //Ejercicio 3

            long numero1, numero2,Osuma,Oresta,Oproducto;
            Console.WriteLine("\tEJERCICIO 3 - OPERACIONES - ");
            Console.WriteLine("\n");
            Console.WriteLine("\n\tPor favor ingrese un primer numero entero largo a operar : ");
            numero1=long.Parse(Console.ReadLine());
            Console.WriteLine("\n\tPor favor ingrese un segundo numero entero largo a operar : ");
            numero2 = long.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Osuma = (long)(numero1 + numero2);
            Oresta = (long)(numero1 - numero2);
            Oproducto = (long)(numero1 * numero2);
            Console.WriteLine("\tResultados:");
            Console.WriteLine("\n");
            Console.WriteLine("\n\tEl resultado de la suma es:   ->"+Osuma);
            Console.WriteLine("\n\tEl resultado de la resta es:  ->"+Oresta);
            Console.WriteLine("\n\tEl resultado del producto es: ->"+Oproducto);

            Console.WriteLine("\n\n\t\tGRACIAS!");
            Console.ReadKey();
            

        }
    }
}
