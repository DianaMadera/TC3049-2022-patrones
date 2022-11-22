namespace Patrones.AbstractFactory
{


    class SaborFresa : IProductoSaborizante
    {
        public string informacion()
        {
            return "Fresa";
        }

        public void obtener()
        {
            Console.WriteLine("Se produce Fresa 34RTP");
        }
    }
}