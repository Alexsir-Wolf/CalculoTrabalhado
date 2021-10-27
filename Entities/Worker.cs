using CalculoTrabalhado.Entities.Enums;
using System;
using System.Collections.Generic;

namespace CalculoTrabalhado.Entities
{
    class Worker
    {
        public String Name { get; set; }
        public WorkerLevel Level { get; set; } //ENUM WorkerLevel
        public double BaseSalary { get; set; }
        public Department Departament { get; set; } //composição, departamento da class worker
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //composição, lista para varios contratos


        //CONSTRUTOR

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department departament)
        {
            Name = name;                                        //não add lista de muitos no contrutor
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;

        }

        //METODOS

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract); //Lista Contract ADD novos contract
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract); //Lista Contract REMOVE novos contract
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts) //para cada HOURCONTRACT/contract na lista Contracts
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }



    }
}
