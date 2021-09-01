using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {

        public static double FahrenheitToCelsius(double temp)
        {
            double Ctemp = (temp - 32) * (5 / 9);

            return Ctemp;

        }
        public static double CelsiusToFahrenheit(double temp)
        {

            double Ftemp = ((temp * 9 )/5) + 32;
            return Ftemp;

        }






    }
}
