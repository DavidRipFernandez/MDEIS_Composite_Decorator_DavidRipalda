using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioKataIndividual.KataComposite.Kata3Organizacion
{
    public class Manager : Employee
    {
        public string Name { get; }
        public int Salary { get; }
        private List<Employee> subordinates = new List<Employee>();

        public Manager(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public void Add(Employee employee)
        {
            subordinates.Add(employee);
        }

        public int GetSalary()
        {
            int total = Salary;
            foreach (var e in subordinates)
                total += e.GetSalary();
            return total;
        }

        public void ShowDetails(string indent = "")
        {
            Console.WriteLine($"{indent}Gerente: {Name}, Salario Total: ${GetSalary()}");
            foreach (var e in subordinates)
                e.ShowDetails(indent + "  ");
        }
    }
}
