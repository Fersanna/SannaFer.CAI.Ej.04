using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SannaFer.CAI.Ej._04
{
    internal class PersonasModel
    {
        public List<Persona> Personas = new List<Persona>()

            {
             new Persona {Documento = 27285688, Apellido ="Sanna", Nombre = "Fernando", Telefono = "4567-6911" },
             new Persona {Documento = 27285700, Apellido ="Messi", Nombre = "Lio", Telefono = "4567-5555" },
             new Persona {Documento = 27285800, Apellido ="Riquelme", Nombre = "Juan", Telefono = "4567-7596" },
             new Persona {Documento = 27555678, Apellido ="Pratto", Nombre = "Oso", Telefono = "4567-1156" }

            };

        internal string Borrar(Persona personaSeleccionada)
        {
            if (personaSeleccionada.Documento == 27555678)
            {
                return "No puede borrar a esta persona";
            }

            Personas.Remove(personaSeleccionada);

            return "Ok";
        }
    }
}
