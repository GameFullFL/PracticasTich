using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFAlumnos
{
    [DataContract]
    public class ItemTablaISR
    {
        [DataMember]
        public decimal limInf { get; set; }
        [DataMember]
        public decimal limSup { get; set; }
        [DataMember]
        public decimal cuotaFija { get; set; }
        [DataMember]
        public decimal Excedente { get; set; }
        [DataMember]
        public decimal subsidio { get; set; }
        [DataMember]
        public decimal ISR { get; set; }
    }
}