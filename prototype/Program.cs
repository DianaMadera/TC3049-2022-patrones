
namespace Patron.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // invocamos el admin
            CAdminPrototipos admin = new CAdminPrototipos();

            //registrando alumnos del tec con caracteristicas similares
            CAlumno uno = (CAlumno)admin.ObtenPrototipo("Alumno");
            CAlumno dos = (CAlumno)admin.ObtenPrototipo("Alumno");
            CAlumno tres = (CAlumno)admin.ObtenPrototipo("Alumno");

            //imprimimos los prototipos
            Console.WriteLine(uno);
            Console.WriteLine(dos);
             Console.WriteLine(tres);
            Console.WriteLine("-----");

            //Modificamos el nombre
            uno.Nombre = "Diana";
            dos.Nombre = "José Antonio";
            tres.Nombre = "Patricia";

            // verificamos que cada quien tenga su nombre
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine(tres);
            Console.WriteLine("-----");


        }

    }
}