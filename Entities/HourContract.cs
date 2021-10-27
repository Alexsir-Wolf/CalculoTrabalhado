using System;


namespace CalculoTrabalhado.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePorHour { get; set; }
        public int Hours { get; set; }

        //CONSTRUTORES

        public HourContract() //contrutor padrão
        {

        }

        public HourContract(DateTime date, double valuePorHour, int hours)
        {
            Date = date;
            ValuePorHour = valuePorHour;
            Hours = hours;
        }



        //METODOS

        public double TotalValue()
        {
            return Hours * ValuePorHour;
        }
    }
}
