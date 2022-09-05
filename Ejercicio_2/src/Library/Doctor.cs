using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public Person Datos {get; set;}
        public string Especialidad 
        {
            get
            {
                return Especialidad;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Especialidad = value;
                }
                else
                {
                    Console.WriteLine("Error al ingresar especialidad");
                }
            }
        }

        public Doctor(Person datos, string especialidad)
        {
            this.Datos = datos;
            if (!string.IsNullOrEmpty(especialidad))
            {
                this.Especialidad = especialidad;
            }
            else
            {
                Console.WriteLine("Error al ingresar especialidad");
            }
        }
    }
}