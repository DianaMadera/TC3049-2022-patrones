namespace Builder03
{
    class Program
    {
        static void Main(string[] args)
        {
            Director miDirector = new Director();
            BuilderNormal normal = new BuilderNormal();
            miDirector.Construye(normal);
            Producto auto1 = normal.ObtenProducto();
            auto1.MostrarAuto();

            SuperBuilder super = new SuperBuilder();
            miDirector.Construye(super);
            Producto auto2 = super.ObtenProducto();
            auto2.MostrarAuto();
        }
    }
}