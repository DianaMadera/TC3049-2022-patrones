namespace Builder03
{
    internal class Producto
    {
        private IMotor motor;
        private ICarroceria carroceria;
        private ILlantas llantas;

        internal void ColocarMotor(IMotor _motor)
        {
            motor = _motor;
            Console.WriteLine("Se ha colocado el motor {0} ", motor);
        }

        internal void ColocarCarroceria(ICarroceria _carroceria)
        {
            carroceria = _carroceria;
            Console.WriteLine("Se ha colocado la carroceria {0} ", carroceria);
        }

        internal void ColocarLlantas(ILlantas _llantas)
        {
            llantas = _llantas;
            Console.WriteLine("Se han colocado las llantas {0} ", llantas);
        }
        

        internal void MostrarAuto()
        {
            Console.WriteLine("Auto nuevo construido con:");
            Console.WriteLine("Motor. {0}", motor);
            Console.WriteLine("Carroceria. {0}", carroceria);
            Console.WriteLine("Llantas. {0}", llantas);
            Console.WriteLine("\n");
        }
    }
}