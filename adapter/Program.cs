﻿// Patrón Adapter -- Ejemplo real  

using System;

namespace Patrones.AdapterReal
{

    /// <summary>

    /// Clase MainApp 

    /// Adapter Design Pattern.

    /// </summary>

    class MainApp
    {

        /// <summary>

        /// Aplicación

        /// </summary>

        static void Main()
        {
            // Elemento no adaptado

            Libro desconocido = new Libro("Desconocido");

            desconocido.MostrarInfo();

            // Elementos adaptados
            Libro l1 = new InformacionLibro("L01");
            l1.MostrarInfo();

            Libro l2 = new InformacionLibro("L02");
            l2.MostrarInfo();

            Libro l3 = new InformacionLibro("L03");
            l3.MostrarInfo();

            Libro l4 = new InformacionLibro("L04");
            l4.MostrarInfo();

            // Wait for user
            Console.ReadKey();

        }

    }

    /// <summary>

    /// The 'Target' class

    /// </summary>

    class Libro
    {
        protected string _codigo;

        protected string _autor;

        protected string _titulo;

        protected string _editorial;

        protected string _isbn;

        protected string _anoPublicacion;

        // Constructor

        public Libro(string codigo)
        {
            this._codigo = codigo;
        }

        public virtual void MostrarInfo()
        {

            Console.WriteLine("\nLibro: {0} ------ ", _codigo);

        }

    }



    /// <summary>

    /// The 'Adapter' class

    /// </summary>

    class InformacionLibro : Libro
    {

        private Biblioteca _bib;


        // Constructor


        public InformacionLibro(string codigo) : base(codigo)
        {
            Console.WriteLine(codigo);

        }

        public override void MostrarInfo()
        {
            // The Adaptee

            _bib = new Biblioteca();


            _autor = _bib.ObtenerAutor(_codigo);

            _titulo = _bib.ObtenerTitulo(_codigo);

            _editorial = _bib.ObtenerEditorial(_codigo);

            _isbn = _bib.ObtenerISBN(_codigo);

            _anoPublicacion= _bib.ObtenerAnoPublicacion(_codigo);


            base.MostrarInfo();

            Console.WriteLine(" Título: {0}", _titulo);

            Console.WriteLine(" Autor : {0}", _autor);

            Console.WriteLine(" Editorial: {0}", _editorial);

            Console.WriteLine(" ISBN: {0}", _isbn);

            Console.WriteLine(" Año de publicación: {0}", _anoPublicacion);
        }
    }



    /// <summary>

    /// The 'Adaptee' class

    /// </summary>

    class Biblioteca
    {

        // API heredada

        public string ObtenerAutor(string libro)
        {

            // Autor
            switch (libro)
            {

                case "L01": return "Paco Fernández";

                case "L02": return "Juan Alberto Gómez";

                case "L03": return "Exiquio Camil";

                case "L04": return "Gabriel García Márquez";

                default: return "";
            }

        }


        public string ObtenerTitulo(string libro)
        {
            switch (libro)
            {
                case "L01": return "Programación en C#";

                case "L02": return "Pensamiento filosófico de Marx";

                case "L03": return "Latinoamérica: innovación tecnológica";

                case "L04": return "Crónica de una muerte anunciada";

                default: return "";
            }
        }


        public string ObtenerEditorial(string libro)
        {
            switch (libro)
            {
                case "L01": return "Alfa-Omega";

                case "L02": return "Publish CE";

                case "L03": return "Fantom";

                case "L04": return "Porrúa";

                default: return "";
            }
        }

        public string ObtenerISBN(string libro)
        {
            switch (libro)
            {
                case "L01": return "89237532985";

                case "L02": return "938573985439";

                case "L03": return "9835798572395";

                case "L04": return "9787483748723";

                default: return "";
            }
        }

        public string ObtenerAnoPublicacion(string libro)
        {
            switch (libro)
            {
                case "L01": return "2002";

                case "L02": return "1918";

                case "L03": return "2010";

                case "L04": return "1981";

                default: return "";
            }
        }

    }

}


