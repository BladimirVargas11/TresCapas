using System;

namespace BLL
{
    public class PersonaService
    {
        public decimal CalcularPulsacion(string sexo, int edad)
        {
            decimal pulsacion = 0;
            if (sexo.Equals("F"))
            {
                pulsacion = (220 - edad) / 10;
            }
            else if (sexo.Equals("M"))
            {
                pulsacion = (210 - edad) / 10;
            }
            else
            {
                pulsacion = 0;
            }
            return pulsacion;
        }
    }
}
