using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_118.Entities.Enum
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public double TotalValue()
        {
            return 0;
        }
    }
}
