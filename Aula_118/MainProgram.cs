using System;
using System.Collections.Generic;
using Aula_118.Entities;
using Aula_118.Entities.Enum;

namespace Aula_118
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            
            HourContract contract1 = new HourContract { Date = DateTime.Now, ValuePerHour = 50.0, Hours = 2};
            HourContract contract2 = new HourContract { Date = DateTime.Parse("2018-08-15"), ValuePerHour = 80.0, Hours = 3 };
            HourContract contract3 = new HourContract { Date = new DateTime(2018, 11, 25)};

            Department depto = new Department { Name = "Legilação" };

            Worker worker = new Worker { Name = "Joelson", WorkerLvl = WorkerLevel.Mid_Level, baseSalary = 1000.00, contractList = new List<HourContract>(), Depart = depto};
            worker.AddContract(contract1);
        }
    }
}
