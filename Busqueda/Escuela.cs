using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda
{
    internal class Escuela
    {
        List<Estudiante> student;
        public Escuela()
        {
            //inizializamos
            student = new List<Estudiante>();

        }
        public void addStudente(Estudiante nuevoEstudiante)
        {
            student.Add(nuevoEstudiante);
        }
        public bool serchByName(string nombre)
        {
           
            bool encontrado = false;
            int i = 0;
            while (encontrado == false && i < student.Count)
            {
                if (student[i].Nombre.Equals(nombre))
                {
                    encontrado= true;
                } else
                {
                    i++;
                }

            }
                if (encontrado)
                {
                Console.WriteLine("la cedula es " + student[i].Cedula + "\n El nombre es :"
                    + student[i].Nombre + "\n El apellido es:"
            + student[i].Apellido + "\n La calificación es :" + student[i].Calificacion);
                return false;
                } else
                {
                    Console.WriteLine(" no se encontro estudiante intentelo nuevamente.." );
                    return true;
                  
            }
            return  true;
        }
    }
}
