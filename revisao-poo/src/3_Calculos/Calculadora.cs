using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public class Calculadora
    {
        public double Calcular(double raio)
        {
            return 3.14159 * (raio * raio);
        }

        public double Calcular(double comprimento, double altura)
        {
            return comprimento * altura;
        }

        public double Calcular(int lado1, int lado2, int lado3)
        {
            return  lado1 + lado2 + lado3;
        }

        public double Calcular(int base_triangulo, double altura)
        {
            return (base_triangulo * altura) / 2;
        }

        public double Calcular(List<double> cord1, List<double> cord2, List<double> cord3)
        {
            return 0; // TODO: Fazer este calculo
        }

        public string Calcular(string param)
        {
            return "Uso incorreto";
        }
    }
}
