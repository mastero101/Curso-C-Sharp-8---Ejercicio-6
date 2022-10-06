using Curso_C_Sharp_8___Ejercicio_6;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp8
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcionElegida = 0;
            do
            {
                Console.WriteLine("                                  ");
                Console.WriteLine("Elige una opcion: ");
                Console.WriteLine("1) Dime 2 numeros para operar con ellos");
                Console.WriteLine("2) Dime una palabra. Te dire las vocales que tiene");
                Console.WriteLine("3) Numeros Aleatorios");
                Console.WriteLine("4) Palindromos");
                Console.WriteLine("5) Serie Fibonacci");
                Console.WriteLine("6) Generar Lista con cosas y acabara poniendo fin");
                Console.WriteLine("7) Generar Fichero de Texto");
                Console.WriteLine("8) Ver Fichero");
                Console.WriteLine("9) Añadir lineas al Fichero");
                Console.WriteLine("10) Borrar Fichero");
                Console.WriteLine("0) Salir");
                Console.WriteLine("                          ");

                Numero numero = new Numero();
                Palabra p = new Palabra();
                Fichero f = new Fichero();

                opcionElegida = Convert.ToInt32(Console.ReadLine());
                switch (opcionElegida)
                {
                    case 0:
                        {
                            Environment.Exit(0);
                        }
                        break;
                    case 1:
                        {
                            int x = 0;
                            int y = 0;
                            Console.WriteLine("                          ");
                            Console.WriteLine("Dime el 1er Numero");
                            x = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Dime el 2do Numero");
                            y = Convert.ToInt32(Console.ReadLine());

                            if (x > 0 && y > 0)
                                Console.WriteLine("El resultado de la suma es: " + numero.sumar(x,y));
                            else if ((x > 0 && y < 0) || (x < 0 && y > 0))
                                Console.WriteLine("El resultado de la multiplicacion es: " + numero.multiplicar(x,y));
                            else if (x < 0 && y < 0)
                                Console.WriteLine("El resultado de la division es: " + numero.dividir(x,y));
                            else
                                Console.WriteLine("Operacion no disponible");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("                          ");
                            Console.WriteLine("Dime una palabra");
                            string palabra = Console.ReadLine();
                            Console.WriteLine("Esta palabra contiene las vocales:" + p.dimeVocales(palabra));

                        }
                        break;
                    case 3:
                        Console.WriteLine("                          ");
                        Console.WriteLine("Los numeros generados son " + numero.generarNumAleatorio(0,8).ToString() + " y " + numero.generarNumAleatorio(0,8).ToString());
                        break;
                    case 4:
                        {
                            Console.WriteLine("                          ");
                            Console.WriteLine("Dime una palabra:");
                            string palabra = Console.ReadLine();

                            if (p.palabrasPalindromo(palabra))
                                Console.WriteLine("Es un palindromo");
                            else
                                Console.WriteLine("No es un palindromo");
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Introduzca hasta que valor calcular la serie:");
                            int num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(numero.dameFibonacci(num));
                            Console.WriteLine("                            ");
                        }
                        break;
                    case 6:
                        {
                            List<string> lista = new List<string>();
                            string cosas = String.Empty;

                            do
                            {
                                Console.WriteLine("Introduzca cosas que hacer:");
                                cosas = Console.ReadLine();
                                if (cosas.ToLower() != "fin")
                                    lista.Add(cosas);

                            } while (cosas.ToLower() != "fin");

                            Console.WriteLine("Cosas apuntadas: ");
                            foreach (string x in lista)
                                Console.WriteLine(x);
                            Console.WriteLine("                     ");
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Dime su identificador numerico:");
                            string num = Console.ReadLine();
                            Console.WriteLine("Dime el nombre del producto");
                            string producto = Console.ReadLine();

                            if (num.ToString().Length >= 10)
                                Console.WriteLine("El identificador no puede tener mas de 10 digitos");
                            else
                                f.escribirFichero(num, producto, false);
                        }
                        break;
                    case 8:
                        Console.WriteLine(f.leerFichero());
                        break;
                    case 9:
                        {
                            Console.WriteLine("Dime lineas a añadir:");
                            int numLineas = Convert.ToInt32(Console.ReadLine());

                            int cont = 0;
                            while (cont < numLineas)
                            {
                                Console.WriteLine("Dimer su identificado numerico");
                                string num = Console.ReadLine();
                                Console.WriteLine("Dime el nombre del producto");
                                string producto = Console.ReadLine();
                                f.escribirFichero(num, producto, true);

                                cont++;
                            }
                        }
                        break;
                    case 10:
                        {
                            Console.WriteLine(f.borrarFichero());
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Operacion No Permitida");
                            Environment.Exit(0);
                        }
                        break;
                }
            } while (opcionElegida != 0);
        }
    }
}