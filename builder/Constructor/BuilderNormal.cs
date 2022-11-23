using static Builder03.IMotor;
using static Builder03.ICarroceria;
using static Builder03.ILlantas;

namespace Builder03
{
    internal class BuilderNormal : IBuilder
    {
        private Producto auto = new Producto();
        public void ConstrulleCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaBasica());
        }

        public void ConstrulleLLantas()
        {
            auto.ColocarLlantas(new llantas12());
        }

        public void ConstrulleMotor()
        {
            auto.ColocarMotor(new MotorBasico());
        }

        internal Producto ObtenProducto()
        {
            return auto;
        }
    }
}