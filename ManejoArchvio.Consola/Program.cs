using System;
using ManejoArchivo.Negocio;
using  ManejoArchivo.Paralelismo;

namespace ManejoArchvio.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.ReadLine();
            
            //Instanciando clases 
            var gestor = new GestionArchivo();
            var escribir = new EscribirArchivo();
            var enumerar = new  EnumerarArchivo();
            var crearDirectorio = new CrearDirectorios();
            var informar = new  InformarCaracteristicas();
            var escucharArchivo = new  EscucharArchivo();
            var tamañoArchivosParalelismo = new TamañoArchivosParalelismo();



            //Rutas definidas para cada método
            //Ruta del gestor
            var ruta = @"/home/elmer2210/Escritorio/POO/ManejoArchvio/Nuestro Juramento.txt";
            //Ruta del archivo a escribir 
            var archivoEcribir = @"/home/elmer2210/Escritorio/POO/ManejoArchvio/Escribe Aqui.txt";
            //Ruta para crear directorios
            var directorio = @"/home/elmer2210/Escritorio/POO/ManejoArchvio/";
            
            
            //Leer un archivo
            var contenido = gestor.Leer(ruta);
            Console.WriteLine("Nuestro Juramento");
            Console.WriteLine(contenido);
            
            //Agregar entradar a un archivo
            var crear = escribir.Escribir(archivoEcribir);
            Console.ReadLine();
            Console.WriteLine(crear);
            
            //enumerar los archivos de un directorio
            var enumerando = enumerar.Enumerar(directorio);
            Console.ReadLine();
            Console.WriteLine(enumerando);
            
            //crear directorio y subdirectorios
            var crearDirectorios = crearDirectorio.CrearDirectorio(); 
            Console.ReadLine();
            Console.WriteLine(crearDirectorios);
            
            //Dar caracteristicas de un archivo con drive
            var decirCaracteristicas = informar.Informar(directorio);

            //Usando el trace Listeners
            var escuchar = escucharArchivo.Escuchar();
            Console.ReadLine();
            Console.WriteLine(escuchar);

            //paralelismo para contar archivos
            Console.WriteLine(tamañoArchivosParalelismo.LeerArchivo());
            
        }
    }
}
