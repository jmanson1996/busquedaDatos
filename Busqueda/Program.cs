using System.Security.Cryptography.X509Certificates;

namespace Busqueda
{
    class Program
    {

        static String nombre;

        static String nombre1;
        static String cedula;

        static bool valor = false;


        static void Main()
        {
            //int 
            //Console.WriteLine("ingrese cuantos estudiantes quiere ingresar");
            //int numero = Convert.ToInt16(Console.ReadLine());
            //String[] arreglo = new String[numero];

            //for (int i = 0; i < numero; i++)
            //{
            //    Console.WriteLine("ingrese el nombre");
            //    arreglo[i] = Console.ReadLine();
            //    //Console.WriteLine("Ingrese  la cedula");
            //    //arreglo[i] = cedula;


            //}
            var metodo = new Estudiante()
            {
                Cedula = "1721364717",
                Nombre = "jonathan",
                Apellido = "pilataxi",
                Fecha_nacimiento = "1996",
                Calificacion = "10"
            };
            var metodo1 = new Estudiante()
            {
                Cedula = "1452360171",
                Nombre = "Karen",
                Apellido = "pilataxi",
                Fecha_nacimiento = "2005",
                Calificacion = "10"
            };
            var metodo2 = new Estudiante()
            {
                Cedula = "1789632152",
                Nombre = "Nicol",
                Apellido = "pilataxi",
                Fecha_nacimiento = "2011",
                Calificacion = "10"
            };
            var metodo3 = new Estudiante()
            {
                Cedula = "1523624256",
                Nombre = "Maria",
                Apellido = "Gomez",
                Fecha_nacimiento = "1975",
                Calificacion = "8"
            };
            var scholl = new Escuela();
            scholl.addStudente(metodo);
            scholl.addStudente(metodo1);
            scholl.addStudente(metodo2);
            scholl.addStudente(metodo3);
          
            valor = false;
            do
            {
                Console.WriteLine("ingrese el nombre para buscar");
                nombre1 = Console.ReadLine();
                valor = scholl.serchByName(nombre1);
            } while (true);
            Console.ReadKey();

        }


    }
}
