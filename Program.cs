using System.Collections.Generic;
using System.Globalization;
using ExercicioHerancaPolimorfismo.Entities;

namespace ExercicioHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();//instanciando uma lista para os funcionarios
            Console.Write("How many employees? ");//quantos funcionarios serão
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");//dados do funcionario
                Console.Write("Outsourced (y/n)? ");//terceirizado ou nao
                char t = char.Parse(Console.ReadLine());
                Console.Write("Name: ");//nome
                string name = Console.ReadLine();
                Console.Write("Hours: ");//horas trabalhadas
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");//valor por hora
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (t == 'y')
                {
                    //verifica se é terceirizado
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employee.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                    //funcionario terceirizado
                }
                else
                {
                    //verifica quando não é terceirizado
                    employee.Add(new Employee(name, hours, valuePerHour));
                    //funcionario normal
                }

            }

            //apresentação do resultado
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");

            foreach(Employee emp in employee)
            {
                Console.WriteLine(emp.Name + " - " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }



        }
    }
}
