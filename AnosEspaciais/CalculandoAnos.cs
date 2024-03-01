using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnosEspaciais
{
    public class CalculandoAnos
    {
        static double CalcularAnosEmOutroPlaneta(int userAge, double planetYears, double journeyToPlanet)
        {
            double planetAge = userAge / planetYears;
            double newPlanetAge = (userAge + journeyToPlanet) / planetYears;

            return newPlanetAge + planetAge;
        }
    }
}
