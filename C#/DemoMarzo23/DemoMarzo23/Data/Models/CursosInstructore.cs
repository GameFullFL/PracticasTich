using System;
using System.Collections.Generic;

#nullable disable

namespace DemoMarzo23.Data.Models
{
    public partial class CursosInstructore
    {
        public int Id { get; set; }
        public short IdCurso { get; set; }
        public short IdInstructor { get; set; }
        public DateTime? FechaContratacion { get; set; }

        public virtual Curso IdCursoNavigation { get; set; }
        public virtual Instructore IdInstructorNavigation { get; set; }
    }
}
