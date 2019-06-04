using System;
using System.Collections.Generic;
using System.Text;

namespace JuanPabloClase1
{
    class Libro
    {
        private string pAutor;
        private string pTitulo;
        private int pPaginas;
        public string Autor
        {
            get
            {
                return pAutor;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("El autor debe tener una longitud mayor a 3.");
                }
                else
                {
                    this.pAutor = value;
                }
            }
        }
        public string Titulo
        {
            get
            {
                return pTitulo;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("El título debe tener una longitud mayor a 3.");
                }
                else
                {
                    this.pTitulo = value;
                }
            }
        }
        public int Paginas
        {
            get
            {
                return pPaginas;
            }
            set
            {
                if (value < 20 || value > 10000)
                {
                    throw new Exception("Las páginas deben ser mayor a 20 y menor a 10000");
                }
                else
                {
                    this.pPaginas = value;
                }
            }
        }
        public Libro (string autor = "Anónimo")
        {
            this.Autor = autor;
        }
        public Libro(string autor, string titulo) : this(autor)
        {
            this.Titulo = titulo;
        }
        public Libro(string autor, string titulo, int paginas) : this(autor, titulo)
        {
            this.Paginas = paginas;
        }
    }
}
