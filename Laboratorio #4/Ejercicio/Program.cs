using System;
using System.IO;

class Program
{
     //Menu principal 
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Crear archivo");
            Console.WriteLine("2. Agregar contenido a archivo");
            Console.WriteLine("3. Leer archivo");
            Console.WriteLine("4. Leer archivo completo");
            Console.WriteLine("5. Mover archivo");
            Console.WriteLine("6. Crear otra carpeta");
            Console.WriteLine("7. Eliminar archivo");
            Console.WriteLine("8. Listar archivos");
            Console.WriteLine("9. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    CrearArchivo();
                    break;
                case "2":
                    AgregarContenidoArchivo();
                    break;
                case "3":
                    LeerArchivo();
                    break;
                case "4":
                    LeerArchivoCompleto();
                    break;
                case "5":
                    MoverArchivo();
                    break;
                case "6":
                    CrearOtraCarpeta();
                    break;
                case "7":
                    EliminarArchivo();
                    break;
                case "8":
                    ListarArchivos();
                    break;
                case "9":
                    return;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
    //Crear un archivo 
    static void CrearArchivo()
    {
        string ruta = @"C:\\Users\\tahly\\Desktop\\LaboratorioStark";
        string archivo = Path.Combine(ruta, "invetos.txt");

        // Evaluar si la ruta existe o no 
        if (!Directory.Exists(ruta))
        {
            Console.WriteLine($"Error: la ruta {ruta} no existe");
            return;
        }

        // Evaluar si el archivo existe 
        if (!File.Exists(archivo))
        {
            File.WriteAllText(archivo, "Hola es un ejercico de ayuda de inventos:");
            Console.WriteLine($"Archivo creado: {archivo}");
        }
        else
        {
            Console.WriteLine("El archivo ya existe");
        }
    }
    //Agragar contenido 
    static void AgregarContenidoArchivo()
    {
        string ruta = @"C:\\Users\\tahly\\Desktop\\LaboratorioStark";
        string archivo = Path.Combine(ruta, "inventos.txt");

        if (File.Exists(archivo))
        {
            Console.WriteLine("Ingrese el contenido a agregar:");
            string contenido = Console.ReadLine();
            File.AppendAllText(archivo, Environment.NewLine + contenido);
            Console.WriteLine($"Contenido agregado al archivo: {archivo}");
        }
        else
        {
            Console.WriteLine($"Error: el archivo {archivo} no existe");
        }
    }
    //Leer archivo 
    static void LeerArchivo()
    {
        string ruta = @"C:\\Users\\tahly\\Desktop\\LaboratorioStark";
        string archivo = Path.Combine(ruta, "inventos.txt");
        
        //Evaluar si existe o no 
        if (File.Exists(archivo))
        {
            string contenido = File.ReadAllText(archivo);
            Console.WriteLine("Contenido del archivo:");
            Console.WriteLine(contenido);
        }
        else
        {
            Console.WriteLine($"Error: el archivo {archivo} no existe");
        }
    }
    //Leer el archivo completo 
    static void LeerArchivoCompleto()
    {
        string ruta = @"C:\\Users\\tahly\\Desktop\\LaboratorioStark";
        string archivo = Path.Combine(ruta, "inventos.txt");

        //Verificar que exista y si no se cumplen las condiciones 
        if (File.Exists(archivo))
        {
            string[] lineas = File.ReadAllLines(archivo);
            Console.WriteLine("Contenido completo del archivo:");
            foreach (string linea in lineas)
            {
                Console.WriteLine(linea);
            }
        }
        else
        {
            Console.WriteLine($"Error: el archivo {archivo} no existe");
        }
    }
    //Mover archivo 
    static void MoverArchivo()
    {     // Rutas para los archivos planos 
        string ruta = @"C:\\Users\\tahly\\Desktop\\LaboratorioStark";
        string archivo = Path.Combine(ruta, "inventos.txt");
        string nuevaRuta = @"C:\\Users\\tahly\\Desktop\\LaboratorioStark\\Archivados";
        
        //Evaluar si existe o no 
        if (!Directory.Exists(nuevaRuta))
        {
            Directory.CreateDirectory(nuevaRuta);
        }

        string nuevoArchivo = Path.Combine(nuevaRuta, "invetos.txt");

        if (File.Exists(archivo))
        {
            File.Move(archivo, nuevoArchivo);
            Console.WriteLine($"Archivo movido a {nuevoArchivo}");
        }
        else
        {
            Console.WriteLine($"Error: el archivo {archivo} no existe");
        }
    }
    // Crear otra carpeta 
    static void CrearOtraCarpeta()
    {
        string nuevaCarpeta = @"C:\\Users\\tahly\Desktop\\LaboratorioStark\\NuevaCarpeta";

        // Evalua que exista 
        if (!Directory.Exists(nuevaCarpeta))
        {
            Directory.CreateDirectory(nuevaCarpeta);
            Console.WriteLine($"Carpeta creada: {nuevaCarpeta}");
        }
        else
        {
            Console.WriteLine($"La carpeta {nuevaCarpeta} ya existe");
        }
    }
    //Eliminar Archivo 
    static void EliminarArchivo()
    {
        string ruta = @"C:\\Users\\tahly\\Desktop\\LaboratorioStark";
        string archivo = Path.Combine(ruta, "invetos.txt");

        // verifica que exista 
        if (File.Exists(archivo))
        {
            File.Delete(archivo);
            Console.WriteLine($"Archivo eliminado: {archivo}");
        }
        else
        {
            Console.WriteLine($"Error: el archivo {archivo} no existe");
        }
    }
    //Kistar Archivos 
    static void ListarArchivos()
    {
        string ruta = @"C:\\Users\\tahly\\Desktop\\LaboratorioStark";
        
        //Verifica que exista 
        if (Directory.Exists(ruta))
        {
            string[] archivos = Directory.GetFiles(ruta);
            Console.WriteLine("Archivos en la carpeta:");
            foreach (string archivo in archivos)
            {
                Console.WriteLine(archivo);
            }
        }
        else
        {
            Console.WriteLine($"Error: la ruta {ruta} no existe");
        }
    }
}