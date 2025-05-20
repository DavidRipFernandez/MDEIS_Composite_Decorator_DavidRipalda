


using EjercicioKataIndividual.KataComposite.Kata1Archivos;
using EjercicioKataIndividual.KataComposite.Kata3Organizacion;
using EjercicioKataIndividual.KataDecorador.Kata2Notificaciones;
using EjercicioKataIndividual.KataDecorador.Kata4FiltroImagenes;

namespace EjercicioKataIndividual
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio KATA 1 - SISTEMA DE ARCHIVOS BASICO
            Console.WriteLine("Ejercicio KATA 1 - SISTEMA DE ARCHIVOS BASICO - PATRON COMPOSITE");
            var file1 = new Archivo("file1.txt", 10);
            var file2 = new Archivo("file2.txt", 20);

            var folder1 = new Folder("folder1");
            folder1.Add(file1);
            folder1.Add(file2);

            //file1.ShowDetails();
            //file2.ShowDetails();
            folder1.ShowDetails();

            //EJERCICIO KATA 3 - ORGANIZACION JERARQUICA
            Console.WriteLine("EJERCICIO KATA 3 - ORGANIZACION JERARQUICA - PATRON COMPOSITE");
            var john = new IndividualEmployee("John", 1000);
            var jane = new IndividualEmployee("Jane", 1200);

            var alice = new Manager("Alice", 0); // Si quieres que Alice solo sume los salarios de sus subordinados, pon 0 aquí
            alice.Add(john);
            alice.Add(jane);

            //john.ShowDetails();
            //jane.ShowDetails();
            alice.ShowDetails();

            Console.WriteLine("EJERCICIO KATA 2 - NOTIFICACIONES DE USUARIO - PATRON DECORADOR");

            Notificacion notificacion = new BasicNotificacion();

            // Añadir decoradores (ejemplo: correo y SMS)
            notificacion = new EmailNotification(notificacion);
            notificacion = new SMSNotification(notificacion);

            notificacion.Send();

            Console.WriteLine("EJERCICIO KATA 4 - NOTIFICACIONES DE USUARIO - PATRON DECORADOR");

            // Aplica los filtros: blanco y negro, luego brillo, luego contraste
            Image imagen = new BasicImage();
            imagen = new BlackAndWhiteFilter(imagen);
            imagen = new BrightnessFilter(imagen);
            imagen = new ContrastFilter(imagen);

            imagen.ApplyFilters();

        }
    }
}