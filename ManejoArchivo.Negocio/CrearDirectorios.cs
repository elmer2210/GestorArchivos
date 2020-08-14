using System;
using System.IO;

namespace ManejoArchivo.Negocio
{
    public class CrearDirectorios
    {
        public string CrearDirectorio()
        {
            DirectoryInfo directorio = new DirectoryInfo(
                @"/home/elmer2210/Escritorio/POO/ManejoArchvio/DirectorioEjemplo");
            DirectoryInfo subdirectorio = new DirectoryInfo(
                @"/home/elmer2210/Escritorio/POO/ManejoArchvio/DirectorioEjemplo/Subdirectorio");
            try
            {
                Console.WriteLine("--------VOY A CREAR DIRECTORIOS Y SUDIRECTORIOS------");
                //Creamos los directorios 
                if (directorio.Exists && subdirectorio.Exists)
                {
                    Console.WriteLine($"El directorio {directorio.Name} y el subdirectorio {subdirectorio.Name} ya se encuentran creados ");
                }
                else
                {
                    directorio.Create();
                    subdirectorio.Create();
                    Console.WriteLine($"Se crearon el directorio {directorio.Name} y el {subdirectorio.Name}");  
                }
                
                //Como tenemos subdirectorios la operación delete no funcionara 
                Console.WriteLine("Voy a intentar borrar un dorectorio", directorio.Name);
                directorio.Delete();
                Console.WriteLine("La operación de borrado fue un exito");
            }
            catch (Exception )
            {
                Console.WriteLine($"La operación de eliminar el directorio {directorio.Name} fallo como se esperaba");
            }
            finally{}
            return "Directorio y subdirectorio creados";
        }
    }
}