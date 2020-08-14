using System;
using System.IO;
using System.Linq;

namespace ManejoArchivo.Negocio
{
    public class EnumerarArchivo
    {
        public string Enumerar(string ruta)
        {
            Console.WriteLine("--------VOY A ENUMERAR LOS ARCHIVOS ENCONTRADOS------");
            try
            {
                var archivo = from arch in Directory.EnumerateFiles(ruta)
                    where arch.ToLower().Contains("juramento")
                    select arch;
                foreach (var arch in archivo)
                {
                    Console.WriteLine("{0}", arch);
                }

                Console.WriteLine("{0} Archivos encontrados", archivo.Count<string>().ToString());
            }
            catch (UnauthorizedAccessException accessException)
            {
                Console.WriteLine(accessException.Message);
            }
            catch (PathTooLongException longException)
            {
                Console.WriteLine(longException.Message);
            }
            return "Archivos enumerados";
        }
    }
}