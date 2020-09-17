using System;

namespace Entity
{
    public class Persona
    {
        public Persona(string identificacion, string nombre, int edad, string sexo, decimal pulsacion)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Pulsacion = pulsacion;

        }

        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public decimal Pulsacion { get; set; }
        
    }
}
