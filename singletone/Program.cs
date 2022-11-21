//crear espacio de trabajo
namespace Patrones
{
    class MainApp
    {
        static void Main(){
            //se crea la instancia
            Singleton? transaction1= Singleton.Instance();
            transaction1.PonerDatos(1);
            Console.WriteLine(transaction1.ToString());
            Singleton? transaction2= Singleton.Instance();
        }
    }
    
    internal class Singleton
    {

        private int no_transaction;

        internal static Singleton? _instance;
        //verificar que la instancia solo se ejecuto o creo una vez
        internal static Singleton? Instance()
        {
            if(_instance == null){
                _instance= new Patrones.Singleton();
                Console.WriteLine("Nueva transacción en proceso");
            }
            else
            {
                Console.WriteLine("No se puede realizar la transacción porque otra se esta realizando");
            }
            return _instance;
        }

        public override string ToString()
        {
            return string.Format("El cajero esta procesando la transacción {0} en este momento", no_transaction);
        }
        public void PonerDatos(int number)
        {
            no_transaction = number;
        }
    }
}