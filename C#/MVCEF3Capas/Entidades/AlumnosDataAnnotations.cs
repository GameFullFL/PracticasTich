using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [MetadataType(typeof(AlumnosDataAnnotations))]
    public partial class Alumnos
    {

    }
    public class AlumnosDataAnnotations
    {
        public int id { get; set; }

        [RegularExpression("^(?=.{3,15}$)[A-ZÁÉÍÓÚ][a-zñáéíóú]+(?: [A-ZÁÉÍÓÚ][a-zñáéíóú]+)?$", ErrorMessage = "Este campo solo acepta letras y espacios")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayName("Nombre")]
        public string nombre { get; set; }

        [RegularExpression("^(?=.{3,15}$)[A-ZÁÉÍÓÚ][a-zñáéíóú]+(?: [A-ZÁÉÍÓÚ][a-zñáéíóú]+)?$", ErrorMessage = "Este campo solo acepta letras y espacios")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayName("Primer Apellido")]
        public string primerApellido { get; set; }

        [RegularExpression("^(?=.{3,15}$)[A-ZÁÉÍÓÚ][a-zñáéíóú]+(?: [A-ZÁÉÍÓÚ][a-zñáéíóú]+)?$", ErrorMessage = "Este campo solo acepta letras y espacios")]
        [DisplayName("Segundo Apellido")]
        public string segundoApellido { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayName("Correo")]
        public string correo { get; set; }

        [DisplayName("Telefono")]
        public string telefono { get; set; }
        [Required(ErrorMessage = "La {0} es obligatorio")]
        [DisplayName("Fecha de Nacimiento")]
        public System.DateTime fechaNacimiento { get; set; }
        [Required(ErrorMessage = "El {0} es obligatorio")]

        [RegularExpression("^[A-Z]{1}[AEIOU]{1}[A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[HM]{1}(AS|BC|BS|CC|CS|CH|CL|CM|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B-DF-HJ-NP-TV-Z]{3}[0-9A-Z]{1}[0-9]{1}$", ErrorMessage = "La CURP no tiene el formato correcto")]
        public string curp { get; set; }

        [Range(10000, 40000, ErrorMessage = "Sueldo entre {1} y {2}")]
        [DisplayName("Sueldo")]
        public Nullable<decimal> sueldo { get; set; }
        [DisplayName("Estado")]
        public int idEstadoOrigen { get; set; }
        [DisplayName("Estatus")]
        public short idEstatus { get; set; }

    }
}
