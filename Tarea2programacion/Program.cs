using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tarea2programacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0; 
            do
            {
                Console.WriteLine("1- ejercicio 1");
                Console.WriteLine("2- ejercicio 2");
                Console.WriteLine("3- ejercicio 3");
                Console.WriteLine("4- salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Console.Clear();
                        Ejercicio1();
                            break;

                    case 2: Console.Clear();
                        Ejercicio2();
                            break;

                    case 3: Console.Clear();
                        Ejercicio3();
                        break;
                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }

            } while (opcion!=4); // mientras la opcion sea diferente de 4
        }

        public static void Ejercicio1()
        {
            float precio = 0f;
            int cantidad = 0;
            float total = 0f;

            Console.WriteLine("cual es el precio de la camisa");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1) 
            {
                Console.WriteLine($"total a pagar: {cantidad * precio}");
            }
            else if (cantidad > 1 && cantidad <6) 
            {
                total = precio * 0.15f;
                total = precio - total;
                Console.WriteLine($"total a pagar; {total} con descuento de 15%");
            }
           else if (cantidad >=6) 
            {
                total = (cantidad * precio) * 0.2f;
                total = (cantidad * precio) - total;
                Console.WriteLine($"total a pagar {total} con descuento de 20%");
            }

        }
        public static void Ejercicio2()
        {
            int Carnet = 0;
            float quiz1 = 0f;
            float quiz2 = 0f;
            float quiz3 = 0f;
            float tarea1 = 0f;
            float tarea2 = 0f;
            float tarea3 = 0f;
            float examen1 = 0f;
            float examen2 = 0f;
            float examen3 = 0f;
            float Promedio1 = 0f;
            float Promedio2 = 0f;
            float Promedio3 = 0f;
            float porquiz = 0f;
            float portar = 0f;
            float porexa = 0f;
            float promediofinal = 0f;
       

            Console.WriteLine("Digite el numero de carnet");
            Carnet = int.Parse(Console.ReadLine());
            Console.WriteLine("cual es la nota del quiz 1");
            quiz1 = float.Parse(Console.ReadLine());
            Console.WriteLine("cual es la nota del quiz 2");
            quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine("cual es la nota del quiz 3");
            quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine("cual es la nota de la tarea 1");
            tarea1 = float.Parse(Console.ReadLine());
            Console.WriteLine("cual es la nota de la tarea 2");
            tarea2 = float.Parse(Console.ReadLine());
            Console.WriteLine("cual es la nota de la tarea 3");
            tarea3 = float.Parse(Console.ReadLine());
            Console.WriteLine("cual es la nota del examen 1");
            examen1 = float.Parse(Console.ReadLine());
            Console.WriteLine("cual es la nota del examen 2");
            examen2 = float.Parse(Console.ReadLine());
            Console.WriteLine("cual es la nota del examen 3");
            examen3 = float.Parse(Console.ReadLine());

            Promedio1 = (quiz1 + quiz2 + quiz3);
            Promedio1 = Promedio1 / 3;
            porquiz = Promedio1 * 25 / 100;

            Promedio2 = (tarea1 + tarea2 + tarea3);
            Promedio2 = Promedio2 / 3;
            portar = Promedio2 * 30 / 100;

            Promedio3 = (examen1 + examen2 + examen3);
            Promedio3 = Promedio3 / 3;
            porexa = Promedio3 * 45 / 100;

            promediofinal = (porquiz + portar + porexa);

            Console.WriteLine($" El promedio final de: {Carnet} es: {promediofinal}");

            if (promediofinal >= 70)
            {
                Console.WriteLine($" El estudiante esta Aprobado");
            }
            else if (promediofinal >= 50 && promediofinal < 70)
            {
                Console.WriteLine($" El estudiante esta Aplazado");
            }
            else if (promediofinal < 50)
            {
                Console.WriteLine($" El estudiante esta Reprobado");
            }

           
        }
        public static void Ejercicio3()
        {
            int precio1 = 20;
            int precio2 = 15;
            int cantidad = 0;
            float total = 0f;

            Console.WriteLine("Digite la cantidad");
            cantidad = int.Parse (Console.ReadLine());

            if (cantidad <= 10) 
            {
                total = (cantidad * precio1);
                Console.WriteLine($" total a pagar es de {total}");
            }
            else if (cantidad > 10) 
            {
                total = (cantidad * precio2);
                Console.WriteLine($" total a pagar es de {total}");
                
            }
                {
            }
            
    }
}
}

