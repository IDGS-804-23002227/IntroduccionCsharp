using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionCsharp.Models
{
    public class Multiplicacion
    {
        public int a { get; set; }
        public int b { get; set; }

        public int Resultado { get; set; }

        public string Operacion { get; set; }

        public void Calcular()
        {
            Resultado = 0;
            Operacion = "";

            for (int i = 0; i < b; i++)
            {
                Resultado = Resultado + a;

                Operacion = Operacion + a;

                if (i < b - 1)
                {
                    Operacion = Operacion + "+";
                }
            }

            Operacion = Operacion + "=" + Resultado;
        }
    }
}
 