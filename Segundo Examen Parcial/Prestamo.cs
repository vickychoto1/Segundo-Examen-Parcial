﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Examen_Parcial
{
    internal class Prestamo
    {
        public string codigo { get; set; }
        public string no_identificacion { get; set; }
        public DateTime fecha_prestamo { get; set; }
        public DateTime fecha_devolucion { get; set; }
    }
}
