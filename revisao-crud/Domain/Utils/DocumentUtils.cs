using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Utils
{
    public static class DocumentUtils
    {
        private static int CalculateDigit(List<int> cpf, List<int> algorithm)
        {
            int digitValue = 0;

            for (int index = 0; index < algorithm.Count; index++)
            {
                digitValue += cpf[index] * algorithm[index];
            }

            digitValue %= 11;

            if (digitValue < 0)
            {
                return 0;
            }
            else
            {
                return 11 - digitValue;
            }
        }

        public static Boolean IsCPFValid(string cpf)
        {
            List<int> cpfList = cpf
                .Replace(".", "").Replace("-", "")
                .ToList()
                .Select((value) => Convert.ToInt32(new string(value, 1))).ToList();
            List<int> algorithm1 = new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            List<int> algorithm2 = new List<int> { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string validDigit = $"{cpfList[9]}{cpfList[10]}";
            string calcDigit = $"{CalculateDigit(cpfList, algorithm1)}{CalculateDigit(cpfList, algorithm2)}";

            if (validDigit == calcDigit)
            {
                return true;
            }

            return false;
        }
    }
}
