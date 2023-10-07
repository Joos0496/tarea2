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
       static float precio = 0f;
        static int cantidad = 0;
        static float total = 0f;
       static float precio1 = 20;
        static float precio2 = 15;
        static int Carnet = 0;
        static string Nombre;

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
                        Console.WriteLine("cual es el precio de la camisa");
                        precio = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite la cantidad");
                        cantidad = int.Parse(Console.ReadLine());
                        Ejercicio1(cantidad, precio);
                            break;

                    case 2: Console.Clear();
                        Console.WriteLine("Digite el numero de carnet");
                        Carnet = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nombre del estudiante");
                        Nombre = Console.ReadLine();
                        Ejercicio2();
                            break;

                    case 3: Console.Clear();
                        Console.WriteLine("Digite la cantidad");
                        cantidad = int.Parse(Console.ReadLine());
                       
                        Ejercicio3(cantidad);
                        break;
                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }

            } while (opcion!=4); // mientras la opcion sea diferente de 4
        }

        public static void Ejercicio1(int cantidad, float precio)
        {

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
            double Promedio1 = 0f, totalq = 0f, porq = 0f;
            double Promedio2 = 0f, totalt = 0f, porta = 0f;
            double Promedio3 = 0f, totale = 0f, porex = 0f;
            double promediofinal = 0f;

            double[] quiz = new double[3];
            double[] tarea = new double[3];
            double[] examen = new double[3];

            for (int i = 0; i < quiz.Length; i++)
            {
                Console.WriteLine("Ingrese la nota del quiz" + (i + 1));
                quiz[i] = double.Parse(Console.ReadLine());

                totalq = totalq + quiz[i];

            }
            for (int i = 0; i < tarea.Length; i++)
            {
                Console.WriteLine("Ingrese la nota de la tarea" + (i + 1));
                tarea[i] = double.Parse(Console.ReadLine());

                totalt = totalt + tarea[i];
            }
            for (int i = 0; i < examen.Length; i++)
            {
                Console.WriteLine("Ingrese la nota del examen" + (i + 1));
                examen[i] = double.Parse(Console.ReadLine());

                totale = totale + examen[i];
            }

            Promedio1 = totalq / quiz.Length;
            porq = Promedio1 * 25 / 100;

            Promedio2 = totalt / tarea.Length;
            porta = Promedio2 * 45/ 100;

            Promedio3 = totale / examen.Length;
            porex = Promedio3 * 30 / 100;

            promediofinal = porq + porta + porex;

            Console.Clear();

            Console.WriteLine($" El promedio final del estudiante: {Nombre} Carnet: {Carnet} es de : {promediofinal}");
            Console.WriteLine("El porcentaje de los quiz es: " + porq);
            Console.WriteLine("El porcentaje de las tareas es: " + porta);
            Console.WriteLine("El porcentaje de los examenes es: " + porex);

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
        public static void Ejercicio3(int cantidad)
        {

            if (cantidad <= 10) 
            {
                total = (cantidad * precio1);
                Console.WriteLine($" total a pagar es de {total}");

                Console.ReadKey();  
            }
            else if (cantidad > 10) 
            {
                total = (cantidad * precio2);
                Console.WriteLine($" total a pagar es de {total}");

                Console.ReadKey(); //para que no aparesca el menu//
                
            }
                {
            }
            
    }
}
}

