namespace Patrones.AbstractFactory
{


    class SaborChocolate : IProductoSaborizante
    {
        public string informacion()
        {
            return "Chocolate semi amargo";
        }

        public void obtener()
        {
            Console.WriteLine("Se produce ChocoSD23");
        }
    }
}