using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioKataIndividual.KataDecorador.Kata4FiltroImagenes
{
    public class BrightnessFilter : ImageFilterDecorator
    {
        public BrightnessFilter(Image image) : base(image){}
        public override void ApplyFilters()
        {
            base.ApplyFilters();
            Console.WriteLine("Aplicando filtro de brillo");
        }
    }
}
