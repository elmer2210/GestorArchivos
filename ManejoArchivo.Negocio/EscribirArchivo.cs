using System;
using System.IO;

namespace ManejoArchivo.Negocio
{
    public class EscribirArchivo
    {
        public string Escribir(string ruta)
        {
            Console.WriteLine("------VOY A ESCRIBIR EN EL ARCHIVO-------");
            //abrir o crear un archivo nuevo
            FileInfo archivo = new FileInfo(ruta);
            //Crear un escritor listo para agregar entradas al archivo
            StreamWriter streamWriter = archivo.AppendText();
            streamWriter.WriteLine("Mi nombre es elmer y esta es una nueva entrada para agregar al archivo");
            streamWriter.WriteLine("Esta es una nueva línea de entrada :)");
            streamWriter.Flush();
            streamWriter.Close();
            //Obteniendo información del archivo y mostrarla
            StreamReader streamReader = new StreamReader(archivo.OpenRead());
            while (streamReader.Peek() != -1)
            {
                Console.WriteLine(streamReader.ReadLine());
            }

            return "se ecribio en tu archivo";
        }
    }
}