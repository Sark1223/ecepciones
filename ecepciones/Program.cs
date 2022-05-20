﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                //Obtencion de datos 
                Console.Write("Ingrese un numero: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese otro numero: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                //Impresion de datos con operacion 
                Console.WriteLine(num1 / num2);
                Console.ReadLine();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Errorasjbdahbchja");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
