using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp8
{
    class Fichero
    {
        private string rutaFichero = "D:FicheroPrueba.txt";
        public Fichero() { }

        public void escribirFichero(string num, string producto, Boolean ficheroExiste)
        {
            using (StreamWriter sw = new StreamWriter(rutaFichero, ficheroExiste))
            {
                sw.Write(num.PadLeft(10, '0'));
                sw.Write('|');
                if (producto.Length > 50)
                    producto = producto.Substring(0, 50);

                sw.Write(producto.PadRight(50, ' '));
                sw.Write('|');
                sw.WriteLine();
            }
        }

        public string leerFichero()
        {
            string resultado = String.Empty;
            using StreamReader reader = new StreamReader(rutaFichero);
            string linea;
            do
            {
                linea = reader.ReadLine();
                if (linea != null)
                    resultado += "\n" + linea;
            } while (linea != null);

            return resultado;
        }

        public string borrarFichero()
        {
            string resultado = string.Empty;
            if (File.Exists(rutaFichero))
            {
                File.Delete(rutaFichero);
                resultado = "Fichero borrado correctamente";
            }
            else
                resultado = "Fichero no encontrado";

            return resultado;
        }

    }
}