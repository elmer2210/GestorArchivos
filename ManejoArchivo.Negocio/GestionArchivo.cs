using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ManejoArchivo.Negocio
{
    public class GestionArchivo
    {
        public string Leer(string ruta)
        {
            try
            {
                return File.ReadAllText(ruta);
            }
            catch (FileNotFoundException f)
            {
                return $"No se encontró el archivo {f.FileName}";
            }
            catch (Exception e)
            {
                Trace.WriteLine("En la clase GstionArchivos en el metodo Leer se produjo un excepción");
                Trace.WriteLine(e.Message);
                throw;
            }
        }
    }
}
