using System;
using System.IO;

namespace ManejoArchivo.Negocio
{
    public class InformarCaracteristicas
    {
        public string Informar(string ruta)
        {
            Console.WriteLine("-----VOY A DAR LAS CARACTERISTICAS---------");
            DriveInfo allDrive =new DriveInfo(ruta);
            Console.WriteLine("Unidad {0}", allDrive.Name);
            Console.WriteLine("unidad tipo: {0}", allDrive.DriveType);
            if (allDrive.IsReady == true)
            {
                Console.WriteLine("Nivel de volumen: {0}", allDrive.VolumeLabel);
                Console.WriteLine("System archivo; {0}", allDrive.DriveFormat);
                Console.WriteLine("Espacio usado: {0, 15} bytes", allDrive.AvailableFreeSpace);
                Console.WriteLine("Espacio Total usado: {0, 15} bytes", allDrive.TotalSize);
            }

            return "Caracteristicas de los archivos dadas";
        }
    }
}