using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioKataIndividual.KataComposite.Kata3Organizacion
{
    public class IndividualEmployee : Employee
    {
        public string Name { get; }
        public int Salary { get; }

        public IndividualEmployee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public int GetSalary()
        {
            return Salary;
        }

        public void ShowDetails(string indent = "")
        {
            Console.WriteLine($"{indent}Empleado: {Name}, Salario: {Salary}");
        }
    }
}
