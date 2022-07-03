using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace RestServis.Models
{
    [DataContract]
    public class Osoba
    {
        [DataMember(Order = 0)]
        public string Ime { get; set; }

        [DataMember(Order = 1)]
        public string  Prezime { get; set; }

        [DataMember(Order = 2)]
        public DateTime DatumRodenja { get; set; }
    }
}
