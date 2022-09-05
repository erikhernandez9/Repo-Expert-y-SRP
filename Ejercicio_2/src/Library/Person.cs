using System;
using System.Text;

namespace Library
{
    public class Person
    {
        public string Nombre 
        {
            get
            {
                return Nombre;
            } 
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Nombre = value;
                }
                else
                {
                    Console.WriteLine("Error al ingresar datos");
                }
            }
        }
        public string Edad
        {
            get
            {
                return Edad;
            } 
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Edad = value;
                }
                else
                {
                    Console.WriteLine("Error al ingresar datos");
                }
            }
        }
        public string Phonenumber
        {
            get
            {
                return Phonenumber;
            } 
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Phonenumber = value;
                }
                else
                {
                    Console.WriteLine("Error al ingresar datos");
                }
            }
        }
        public Person(string nombre, string edad, string phoneNumber) 
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                this.Nombre = nombre;
            }
            else
            {
                Console.WriteLine("Error al ingresar el nombre");
            }
            if (!string.IsNullOrEmpty(edad))
            {
                this.Edad = edad;
            }
            else
            {
                Console.WriteLine("Error al ingresar la edad");
            }
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                this.Phonenumber = phoneNumber;
            }
            else
            {
                Console.WriteLine("Error al ingresar el numero");
            }
        }
    }
}