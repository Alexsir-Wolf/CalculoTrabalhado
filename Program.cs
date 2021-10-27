using CalculoTrabalhado.Entities;
using CalculoTrabalhado.Entities.Enums;
using System;
using System.Globalization;

namespace CalculoTrabalhado
{
    class Program
    {
        static void Main(string[] args)
        {
            //DADOS DO WORKER
            Console.Write("Enter com nome do Departamento: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Entre com os dados do Trabalhador: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Salario base: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //INSTA DEPARTAMENTO E WORKER
            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("Quantos contratos para esse trabalhador? ");
            int n = int.Parse(Console.ReadLine());

           for(int i = 1; i <= n; i++)
            {
                //DADOS DO CONTRATO
                Console.WriteLine($"Entre com os dados do contrato #{i} : ");
                Console.Write("Data (DD/MM/AAAA): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (Horas): ");
                int hours = int.Parse(Console.ReadLine());

                //INSTA CONTRATO
                HourContract contract = new HourContract(date, valuePerHour, hours);

                //ADD CONTRATO NO WORKER
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Entre com mês e ano para calcular o valor do salário (MM/AAAA): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));                    //recorta mes
            int year = int.Parse(monthAndYear.Substring(3, 4));                     //recorta ano
            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Departamento: " + worker.Departament.Name);          //navega de Worker/Departamento/Name(nome do departamento)
            Console.WriteLine("Salário referente ao " + monthAndYear + ": " + worker.Income(year, month), CultureInfo.InvariantCulture);






        }
    }
}
