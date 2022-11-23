namespace Patron.Prototype
{
    class CAlumno : IPrototipo
    {

        private string escuela;
        private string nombre;
        private int edad;
        private int semestre;

        public string Escuela { get => escuela; set => escuela = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public int Edad { get => edad; set => edad = value; }

        public int Semestre { get => semestre; set => semestre = value; }

        public CAlumno(string aescuela, string aNombre, int aEdad, int aSemestre)
        {
            escuela=aescuela;
            nombre = aNombre;
            edad = aEdad;
            semestre=aSemestre;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", escuela, nombre, edad, semestre);
        }
        public object Clonar()
        {
            CAlumno clon = new CAlumno(escuela, nombre, edad, semestre);

            return clon;
        }

    }
}