namespace Patron.Prototype
{
    class CAdminPrototipos
    {
        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();
        public CAdminPrototipos()
        {
            //Adicionamos los obj prototipo con los valores iniciales
            CAlumno alumno = new CAlumno("Tec de Monterrey", "Alumno", 23, 9);
            prototipos.Add("Alumno", alumno);
        }

        public void AdicionaPrototipo(string pLlave, IPrototipo pPrototipo)
        {
            prototipos.Add(pLlave, pPrototipo);
        }
        public object ObtenPrototipo(string pLlave)
        {
            return prototipos[pLlave].Clonar();
        }

    }
}