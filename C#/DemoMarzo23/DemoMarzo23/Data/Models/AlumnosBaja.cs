﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DemoMarzo23.Data.Models
{
    public partial class AlumnosBaja
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaBaja { get; set; }
    }
}
