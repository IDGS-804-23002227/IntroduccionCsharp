using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionCsharp.Models
{
    public class Distancia
    {
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }

        public double Resultado { get; set; }

        public void Calcular()
        {
            Resultado = Math.Sqrt(
                Math.Pow((x2 - x1), 2) +
                Math.Pow((y2 - y1), 2)
                );
        }

    }

}
