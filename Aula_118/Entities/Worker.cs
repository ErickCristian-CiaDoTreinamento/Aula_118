using System;
using System.Collections.Generic;
using Aula_118.Entities.Enum;

namespace Aula_118.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel WorkerLvl { get; set; }
        public double baseSalary { get; set; }
        public List<HourContract> contractList { get; set }
        public Department Depart;

        public void AddContract(HourContract contract)
        {

        }

        public void RemoveContract(HourContract contract)
        {

        }

        public double Income(int year, int month)
        {
            return 0;
        }
    }
}
