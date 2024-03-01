using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _4_Operacoes
{
    public class Calculadora
    {
        public int Soma(int x, int y)
        {
            return x + y;
        }

        public int Subtracao(int x, int y)
        {
            return x - y;
        }

        public double Multiplicacao(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double RaizQuadrada(double value)
        {
            if (value < 0)
                throw new ArgumentException("Não é possivel calcular raiz quadrada");

            if (value == 0)
                return 0;

            double estimated = value / 2;
            double nw = (estimated + value / estimated) / 2;
            
            while (Math.Abs(nw - estimated) > 0.00001)
            {
                estimated = nw;
                nw = (estimated + value / estimated) / 2;
            }

            return nw;
        }

        public long Fatorial(long x)
        {
            return ExecutaFatorialRecursivo(x);
        }
        
        private long ExecutaFatorialRecursivo(long param)
        {
            if (param == 0)
                return 0;

            if (param == 1)
                return 1;

            return ExecutaFatorialRecursivo(param - 1) * param;
        }
    }
}
