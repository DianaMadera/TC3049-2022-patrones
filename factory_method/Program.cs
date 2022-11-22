using MetodoFabrica02.Fabrica;
using MetodoFabrica02.Fabrica.Creadores;

namespace MetodoFabrica02
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehiculo vehiculo;
            int dinero = 1000000;
            // Obtenemos el vehiculo de la fabrica
            vehiculo = CCreador.MetodoFabrica(dinero);
            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            Console.WriteLine("Nuevo "+ vehiculo.GetType().Name+ " creado");

            IVehiculo vehiculo2;
            int dinero2=750;
            // Obtenemos el vehiculo de la fabrica
            vehiculo2 = CCreador.MetodoFabrica(dinero2);
            vehiculo2.Encender();
            vehiculo2.Acelerar();
            vehiculo2.Frenar();
            Console.WriteLine("Nuevo "+ vehiculo2.GetType().Name+ " creado");

            IVehiculo vehiculo3;
            int dinero3=400;
            // Obtenemos el vehiculo de la fabrica
            vehiculo3 = CCreador.MetodoFabrica(dinero3);
            vehiculo3.Encender();
            vehiculo3.Acelerar();
            vehiculo3.Frenar();
            Console.WriteLine("Nuevo "+ vehiculo3.GetType().Name+ " creado");
        }
    }
}