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

        internal string AgregarPersona(Persona personaAAgregar)
        {
            if (personaAAgregar.Documento < 0 || personaAAgregar.Documento > 99_999_999)
            {
                return "El numero de documento no puede ser menor a 0 ni mayor a 99.999.999";
            }

            if (string.IsNullOrEmpty(personaAAgregar.Nombre))
            {
                return "Debe ingresar algun nombre";
            }

            if (string.IsNullOrEmpty(personaAAgregar.Telefono))
            {
                return "Debe agregar un numero de telefono";
            }

            if (String.IsNullOrEmpty(personaAAgregar.Apellido))
            {
                return "Agregue el Apellido";
            }


            Personas.Add(personaAAgregar);

            return null;
        }

        internal string Borrar(Persona personaSeleccionada)
        {
            if (personaSeleccionada.Documento == 27555678)
            {
                return "No puede borrar a esta persona";
            }

            Personas.Remove(personaSeleccionada);

            return "Ok";
        }

        internal string Modificar(Persona personaSeleccionada, Persona nuevaVersion)
        {
            if (nuevaVersion.Documento < 0 || nuevaVersion.Documento > 99_999_999)
            {
                return "El numero de documento no puede ser menor a 0 ni mayor a 99.999.999";
            }

            if (string.IsNullOrEmpty(nuevaVersion.Nombre))
            {
                return "Debe ingresar algun nombre";
            }

            personaSeleccionada.Apellido=nuevaVersion.Apellido;
            personaSeleccionada.Nombre=nuevaVersion.Nombre;
            personaSeleccionada.Documento=nuevaVersion.Documento;
            personaSeleccionada.Telefono=nuevaVersion.Telefono;

            return "Ok";
        }
    }
}
