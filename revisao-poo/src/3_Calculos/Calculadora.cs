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

        public double Calcular((int x1, int y1) vector1, (int x2, int y2) vector2, (int x3, int y3) vector3)
        {
            int x = (1 * vector2.y2 * vector3.x3) + (vector1.x1 * 1 * vector3.y3) + (vector1.y1 * vector2.x2 * 1);
            int y = (vector1.x1 * vector2.y2 * 1) + (vector1.y1 * 1 * vector3.x3) + (1 * vector2.x2 * vector3.y3) ;
            double area = 0.5 * (x - y);

            return area < 0 ? area * (-1) : area;
        }

        public string Calcular(string param)
        {
            return "Uso incorreto";
        }
    }
}
