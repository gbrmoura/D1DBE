using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Datas
{
    public class DateUtils
    {
        public double DiasDiferenca(string begin, string end)
        {
            var beginDate = DateTime.Parse(begin);
            var endDate = DateTime.Parse(end);
            var diff = (endDate - beginDate);
            var totalDays = diff.TotalDays;
            return totalDays > 0 ? totalDays : -totalDays;
        }
    }
}
