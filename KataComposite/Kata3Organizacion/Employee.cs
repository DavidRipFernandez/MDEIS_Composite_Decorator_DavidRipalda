using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioKataIndividual.KataComposite.Kata3Organizacion
{
    public interface Employee
    {
        int GetSalary();
        void ShowDetails(string indent = "");
    }
}
