﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mx.Amib.Sistemas.External.Expediente.Certificacion.Catalog
{
    public class MetodoValidacionTO
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private bool vigente;

        public bool Vigente
        {
            get { return vigente; }
            set { vigente = value; }
        }
    }
}
