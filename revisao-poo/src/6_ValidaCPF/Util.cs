using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6_ValidaCPF
{
    public class Util
    {
        public bool IsValidCPF(string value)
        {
            if (!Regex.IsMatch(value, @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$"))
            {
                return false;
            }

            var cpfList = value.Replace(".", "").Replace("-", "").ToList()
                .Select((value) => Convert.ToInt32(new string(value, 1)))
                .ToList();
            var algorithm1 = new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            var algorithm2 = new List<int> { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string validDigit = $"{cpfList[9]}{cpfList[10]}";
            string calcDigit = $"{CalculateDigit(cpfList, algorithm1)}{CalculateDigit(cpfList, algorithm2)}";

            if (validDigit == calcDigit)
            {
                return true;
            }

            return false;
        }

        private int CalculateDigit(List<int> cpf, List<int> algorithm)
        {
            int digitValue = 0;
            for (int index = 0; index < algorithm.Count; index++)
            {
                digitValue += cpf[index] * algorithm[index];
            }

            digitValue %= 11;

            if (digitValue < 0)
                return 0;
            else
                return 11 - digitValue;
        }
    }
}
