using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_consola
{
    internal class claseprincipal
    {
        static void Main(string[] args)
        {
                personaservice service = new personaservice();

            while (true) {


                Console.WriteLine("\n1. Crear");
                Console.WriteLine("2. Ver");
                Console.WriteLine("3. Actualizar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("5. Salir");

                string op = Console.ReadLine();

                switch (op) {

                    case "1": service.crearpersona(); break;
                    case "2": service.mostrarpersonas(); break;
                    case "3": service.actualizarpersonas(); break;
                    case "4": service.eliminarpersonas(); break;
                    case "5": return;

                }
            }

        }
    }
}
