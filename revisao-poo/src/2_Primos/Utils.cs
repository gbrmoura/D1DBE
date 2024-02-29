using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    public class Utils
    {
        private bool PrimoValido(int value)
        {
            if (value == 0 || value == 1)
                return false;

            for (int i = 2; i < ((value / 2) + 1); i++) 
            { 
                if (value % i == 0)
                    return false;
            }

            return true;
        }

        public int ContaPrimos(int x, int y)
        {
            if (x < 0 && y < 0)
                throw new Exception("Parametros devem ser numeros inteiros positivos");

            if (x > y)
                throw new Exception("Primeiro parametro deve ser menor que o segundo");

            int count = 0;
            for (int i = x; i <= y; i++)
            {
                if (PrimoValido(i))
                    count++;
            }

            return count;
        }
    }
}
