using System;
using System.Collections.Generic;
using System.Text;

namespace JuanPabloClase1
{
    class Empleado
    {
        private string pNombre;
        private string pDNI;
        private decimal pSueldo;

        public string Nombre
        {
            set
            {
                if (value.Length > 3)
                {
                    this.pNombre = value;
                } else
                {
                    throw new Exception("La longitud del nombre debe ser mayor a 3.");
                }

            }
            get
            {
                return pNombre;
            }
        }

        public string Dni { get; set; }
        public decimal Sueldo { get; set; }

        public Empleado (string nombre)
        {
            this.Nombre = nombre;
        }
        public Empleado(string nombre, string dni) : this(nombre)
        {
            this.Dni = dni;
        }
        public Empleado(string nombre, string dni, decimal sueldo) : this(nombre, dni)
        {
            this.Sueldo = sueldo;
        }
    }
}
