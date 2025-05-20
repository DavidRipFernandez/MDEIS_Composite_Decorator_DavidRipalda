using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioKataIndividual.KataComposite.Kata1Archivos
{
    public class Archivo : FileSystemComponent
    {
        public string Name { get; }
        public int Size { get; } // Tamaño en KB

        public Archivo(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public int GetSize()
        {
            return Size;
        }

        public void ShowDetails(string indent = "")
        {
            Console.WriteLine($"{indent}Archivo: {Name}, Tamaño: {Size}KB");
        }
    }
}
