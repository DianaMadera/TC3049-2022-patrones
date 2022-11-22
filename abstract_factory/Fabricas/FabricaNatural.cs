
namespace Patrones.AbstractFactory
{
    class FabricaNatural : IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;
       
        public IProductoLeche ObtenerProductoLeche
        {
            get { return leche; }
        }

        public IProductoSaborizante ObtenerSabor
        {
            get { return sabor; }
        }

        public void crearProducto()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string selection = "";
            Console.WriteLine("Estamos creando tu bebida");
            Console.WriteLine("1)Almendra\n2)Coco\n3)Vaca\n4)Soya\n");
            var x = Console.ReadLine();
            selection= Convert.ToString(x);

            switch (selection)
            {
                case "1":
                    leche = new LecheAlmendras();
                    break;
                
                case "2":
                    leche = new LecheCoco();
                    break;
                case "3":
                    leche = new LecheVaca();
                    break;
                case "4":
                    leche = new LecheSoya();
                    break;
            }

            leche.producir();
            Console.WriteLine("Ahora extraemos el sabor");
            Console.WriteLine("1)Chocolate\n2)Vainilla\n3)Fresa\n");
            x = Console.ReadLine();
            selection= Convert.ToString(x);
            switch (selection)
            {
                case "1":
                    sabor = new SaborChocolate();
                    break;
                
                case "2":
                    sabor = new SaborVainilla();
                    break;
                case "3":
                    sabor = new SaborFresa();
                    break;
            }
            sabor.obtener();
        }
    }
}