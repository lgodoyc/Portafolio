﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionDePermisos.Models
{
    public class Resolucion
    {
        public int cantidadPermisos { get; set; }
        public string rut { get; set; }
        public string nombreTipoPermiso { get; set; }
        public bool utilizado { get; set; }
        public string departamento { get; set; }

        public Resolucion()
        {
            cantidadPermisos = default(int);
            rut = string.Empty;
            nombreTipoPermiso = string.Empty;
            utilizado = default(bool);
            departamento = string.Empty;
        }
    }
}