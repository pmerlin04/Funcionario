
namespace ExercicioHerancaPolimorfismo.Entities
{
    //subclasse da Employee
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) :
            base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        //a palavra override significa que este método está sendo subescrevido
        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * (110 / 100));
        }
    }
}
