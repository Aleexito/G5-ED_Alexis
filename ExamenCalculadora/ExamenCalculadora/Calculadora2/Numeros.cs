using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    class Numeros
    {
        public double Num { set; get; }
        public double Num2 { set; get; }
        public string Opera { set; get; }
        public Numeros()
        {
            Num = 0;
            Num2 = 0;
        }
        
        public double ResultadoSuma(double Num, double Num2)
        {
            return Num + Num2;
        }

        public double ResultadoResta(double Num, double Num2)
        {
            return Num - Num2;
        }

        public double ResultadoMulti(double Num, double Num2)
        {
            return Num * Num2;
        }

        public double ResultadoDivi(double Num, double Num2)
        {
            return Num / Num2;
        }

        public double ResultadoPotencia(double Num, double Num2)
        {
            return Math.Pow(Num, Num2);
        }

        public double ResultadoRaiz(double Num)
        {
            return Math.Sqrt(Num);
        }
    }
}
