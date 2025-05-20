using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioKataIndividual.KataComposite.Kata1Archivos
{
    public interface FileSystemComponent
    {
        int GetSize();
        void ShowDetails(string indent = "");
    }
}
