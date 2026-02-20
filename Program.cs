using System;
namespace ProgramacionEstructurada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int personas = 0;
            string nombre;
            do
            {
                Console.Write("Ingresa la cantidad de personas que deseas ingresar: ");
                string dato = Console.ReadLine();
                if (!int.TryParse(dato, out personas) || personas <= 0)
                {
                    Console.WriteLine("Ingrese un dato valido");
                    continue;
                }

            } while (personas <= 0);

            if (personas == 1)
            {
                Console.Write("Ingrese el nombre de la persona: ");
                nombre = Console.ReadLine();

                do {
                    Console.Write("Ingrese la edad de la persona: ");
                    string edadx = Console.ReadLine();
                    if (!int.TryParse(edadx, out edad) || edad <= 0)
                    {
                        Console.WriteLine("Ingrese un dato valido");
                        continue;
                    }
                } while(edad <= 0);
                if (edad >= 18)
                {
                    Console.WriteLine(nombre + " es mayor de edad con: " + edad + " años de edad");
                }
                else
                {
                    Console.WriteLine(nombre + " es menor de edad con: " + edad + " años de edad");
                }

            }
            else if (personas > 1)
            {
                string[] nombres = new string[personas];
                int[] edades = new int[personas];
                int edadparcial = 0;
                for (int cont = 0; cont < personas; cont++)
                {
                    Console.Write("Ingrese el nombre de la persona: ");
                    nombres[cont] = Console.ReadLine();
                    do
                    {
                        Console.Write("Ingrese la edad de la persona: ");
                        string entrada = Console.ReadLine();

                        if(!int.TryParse(entrada, out edadparcial) || edadparcial <= 0)
                        {
                            Console.WriteLine("Debes ingresar un número valido");
                            continue;
                        }
                        edades[cont] = edadparcial;
                    } while (edadparcial <= 0);
                    
                }
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Lista General");
                for (int i = 0; i < personas; i++)
                {
                    Console.WriteLine(nombres[i] + " " + +edades[i]);
                }


                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Mayores de edad");
                for (int i = 0; i < personas; i++)
                {
                    if (edades[i] >= 18)
                    {
                        Console.WriteLine(nombres[i] + " " + edades[i]);
                    }
                }

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Menores de edad");
                for (int i = 0; i < personas; i++)
                {
                    if (edades[i] < 18)
                    {
                        Console.WriteLine(nombres[i] + " " + edades[i]);
                    }
                }
            }
            else { Console.WriteLine("Ingresar un valor valido"); }

        }
    }
}