using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioKataIndividual.KataComposite.Kata1Archivos
{
    public class Folder
    {
        public string Name { get; }
        private List<FileSystemComponent> components = new List<FileSystemComponent>();

        public Folder(string name)
        {
            Name = name;
        }

        public void Add(FileSystemComponent component)
        {
            components.Add(component);
        }

        public int GetSize()
        {
            int total = 0;
            foreach (var c in components)
                total += c.GetSize();
            return total;
        }

        public void ShowDetails(string indent = "")
        {
            Console.WriteLine($"{indent}Carpeta: {Name}, Tamaño Total: {GetSize()}KB");
            foreach (var c in components)
                c.ShowDetails(indent + "  ");
        }
    }
}
