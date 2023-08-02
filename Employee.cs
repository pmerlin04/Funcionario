using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancaPolimorfismo.Entities
{
    internal class Employee
    {
        public string Name { get; set; } //nome funcionario
        public int Hours { get; set; } //horas trabalhadas
        public double ValuePerHour { get; set; } //valor por hora

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        //funcao pagamento
        //palavra virtual deixa que a funcao seja subescrita
        public virtual double Payment()
        {
            return Hours * ValuePerHour ;
        }




    }
}
