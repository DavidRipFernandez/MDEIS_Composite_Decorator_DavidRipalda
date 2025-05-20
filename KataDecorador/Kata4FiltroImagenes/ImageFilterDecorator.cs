using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioKataIndividual.KataDecorador.Kata4FiltroImagenes
{
    public abstract class ImageFilterDecorator : Image
    {
        protected Image _image;

        public ImageFilterDecorator(Image image)
        {
            _image = image;
        }
        public virtual void ApplyFilters()
        {
            _image.ApplyFilters();
        }
    }
}
