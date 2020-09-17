using BLL;
using Entity;
using System;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;
            string sexo;
            string identificacion;
            decimal pulsacion;


            Console.WriteLine("Digite la identificacion: ");
            identificacion = Console.ReadLine();

            Console.WriteLine("Digite el nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Digite el sexo: ");
            sexo = Console.ReadLine();

            Console.WriteLine("Digite la edad: ");
            edad = int.Parse(Console.ReadLine());
            
            PersonaService personaService = new PersonaService();
            
            pulsacion = personaService.CalcularPulsacion(sexo.ToUpper(), edad);

            Persona persona = new Persona(identificacion, nombre, edad, sexo, pulsacion);

            Console.WriteLine("Sus Pulsaciones son de: {0} ", persona.Pulsacion);

            Console.ReadKey();

        }
    }
}
