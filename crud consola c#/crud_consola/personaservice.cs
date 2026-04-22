using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace crud_consola
{
    public class personaservice
    {
        private List<persona> listapersona = new List<persona>();

        public void crearpersona()
        {
            Console.WriteLine("cual es tu nombre? ");
            string nombre = Console.ReadLine();

            persona p = new persona();
            {
                Id = listapersona.Count + 1,
                Nombre = nombre

            };

            listapersona.Add(p);
            Console.WriteLine("persona agregada.");
        }


        public void mostrarpersonas()
        {
            foreach (var p in listapersona)
            {
                Console.WriteLine("Id: {p.Id} Nombre: {p.Nombre}");

            }
        }

        public void actualizarpersonas() {
            Console.WriteLine("cual es el Id?");
            int id = int.Parse(Console.ReadLine());

            var persona = listapersona.FirstOrDefault(p => p.Id == id);

            if (persona != null)
            {
                Console.WriteLine("nuevo nombre:");
                persona.Nombre = Console.ReadLine();
            }

        }


        public void eliminarpersonas()
        {
            Console.WriteLine("cual es el Id?");
            int id = int.Parse(Console.ReadLine());

            var persona = listapersona.FirstOrDefault(p => p.Id == id);

            if (persona != null)
            {
                listapersona.Remove(persona);
            }
        }
    }
}

