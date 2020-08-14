using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ManejoArchivo.Paralelismo
{
    public class TamañoArchivosParalelismo
    {
        public string LeerArchivo()
        {
            long TamañoTotal = 0;

            String[] args = Environment.GetCommandLineArgs();
            if (args.Length == 1)
            {
                Console.WriteLine("No hay lineas de argumentos");
                
            }
            if (! Directory.Exists(args[1]))
            {
                Console.WriteLine("Este directorio no existe");
                
            }

            String[] archivos = Directory.GetFiles(args[1]);
            Parallel.For(0, archivos.Length,
                index =>
                {
                    FileInfo fi = new FileInfo(archivos[index]);
                    long tamaño = fi.Length;
                    Interlocked.Add(ref TamañoTotal, tamaño);
                });
            Console.WriteLine("Directorio '{0}':", args[1]);
            Console.WriteLine("{0:N0} archivos, {1:N0} bytes", archivos.Length, TamañoTotal);
            return "Hola";
        }
    }
}