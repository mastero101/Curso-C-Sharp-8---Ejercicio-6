using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp8
{
    public class Numero
    {

        int num;
        int num2;

        public Numero()
        {

        }

        //public Numero(int x,int y)
        //{
        //    num = x;
        //    num2 = y;
        //}

        //public int sumar()
        //{
        //    return this.num + this.num2;
        //}

        public int sumar(int x, int y)
        {
            return x + y;

        }

        public int multiplicar(int x, int y)
        {
            return x * y;
        }

        public int dividir(int x, int y)
        {
            return x / y;
        }

        public int generarNumAleatorio(int desde, int hasta)
        {
            Random aleatorio = new Random();
            return aleatorio.Next(desde, hasta);

        }

        public string dameFibonacci(int num)
        {
            string cadenaMostrar = "0";
            int a = 0;
            int b = 1;
            int suma = 0;

            while (suma <= num)
            {
                suma = a + b;
                a = b;
                b = suma;

                if (suma <= num)
                    cadenaMostrar += " " + suma;
            }

            return cadenaMostrar;
        }
    }



}
