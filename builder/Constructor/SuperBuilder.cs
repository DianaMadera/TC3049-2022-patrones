using static Builder03.IMotor;
using static Builder03.ICarroceria;
using static Builder03.ILlantas;

namespace Builder03
{
    internal class SuperBuilder : IBuilder
    {
        private Producto auto = new Producto();
        public void ConstrulleCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaEspecial());
        }

        public void ConstrulleLLantas()
        {
            auto.ColocarLlantas(new llantasSuper());
        }

        public void ConstrulleMotor()
        {
            auto.ColocarMotor(new MotorGrande());
        }

        internal Producto ObtenProducto()
        {
            return auto;
        }
    }
}