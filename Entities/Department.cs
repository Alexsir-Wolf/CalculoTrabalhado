
namespace CalculoTrabalhado.Entities
{
    class Department
    {
        public string Name { get; set; }

        //CONSTRUTORES
        public Department() //contrutor padrão
        {

        }
        public Department (string name) //contrutor que recebe NOME como argumento.
        {
            Name = name;
        }
    }
}
