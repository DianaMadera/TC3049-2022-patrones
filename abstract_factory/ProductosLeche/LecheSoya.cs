namespace Patrones.AbstractFactory
{


    class LecheSoya : IProductoLeche
    {
        public string obtenerDatos()
        {
            return "Leche de Soya, 250ml";
        }

        public void producir()
        {
            Console.WriteLine("Moliendo y filtrando la soya");
        }
    }
}