using System;
using System.ComponentModel.Design;

namespace nota
{
    class progra
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" \n Este es un programa de notas\n ");

            int nota;

            Console.WriteLine("\n Ingrese la nota\n ");
            nota = int.Parse(Console.ReadLine());

            
            if (nota > 100)
            {
                Console.WriteLine("La nota ingresada No es valida");
            }
            else
            {
                if (nota >= 90)
                {
                    Console.WriteLine("Exelente");
                }
                else
                {
                    if (nota >= 80)
                    {
                        Console.WriteLine("Muy bien");
                    }
                    else
                    {
                        if (nota >= 70)
                        {
                            Console.WriteLine("Bien");
                        }
                        else
                        {
                           if(nota < 70)
                            {
                                Console.WriteLine("Reprobado");
                            }
                        }
                       
                    }
                }
              
            }
            
        }
       
    }
}

