using System.Diagnostics;
using System.IO;

namespace ManejoArchivo.Negocio
{
    public class EscucharArchivo
    {
        public string Escuchar()
        {
            //Creamos el archivos
            var archivo = @"/home/elmer2210/Escritorio/POO/ManejoArchvio/ArchivosParaEscribir.txt";
            
            Stream miArchivo = File.Create(archivo);
            //Creamos un nuevvo texto escrito usando output 
            TextWriterTraceListener miArchivoEcribir = new TextWriterTraceListener(miArchivo);
            Trace.Listeners.Add(miArchivoEcribir); 
            //Escribimos en el archivo 
            Trace.Write("Test de salida");
            //Vaciar la salida 
            Trace.Flush();
            return "0";
        }
    }
}