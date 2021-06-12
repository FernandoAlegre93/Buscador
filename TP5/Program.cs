using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nombre , apellido, telefonos, correo, dni;
            string aux;
            int i = 0;

            dni= new string [2];
            nombre = new string [2];
            apellido = new string [2];
            telefonos = new string[2];
            correo = new string [2];

            for (;i < 3 ;)
            {
                Console.WriteLine("Ingrese numero DNI");
                dni[i] = Console.ReadLine();
                Console.Clear();

                if (dni[i] != "0")
                {
                    Console.WriteLine("Nombre");
                    nombre[i] = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Apellido");
                    apellido[i] = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Telefono");
                    telefonos[i] = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Correo");
                    correo[i] = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    break;
                    
                    i++;
                }
            }
            Console.WriteLine("Ingrese el DNI que desea buscar");
            aux = Convert.ToString( Console.ReadLine());

            for (int a = 0; a <= i;a++)
            {
                if (aux == dni[i])
                {
                    Console.WriteLine("Nombre: {0}", nombre[i]);
                    Console.WriteLine("Apellido: {1}", apellido[i]);
                    Console.WriteLine("Telefono: {2}", telefonos[i]);
                    Console.WriteLine("Correo: {3}", correo[i]);
                    break;
                }

            }

            Console.ReadKey();
        }
    }
}
