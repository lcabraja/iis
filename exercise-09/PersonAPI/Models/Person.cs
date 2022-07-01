using System;
using System.Runtime.Serialization;

namespace API.Models
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/API.Models")]
    public class Person
    {
        [DataMember(Order = 0)]
        public string Name { get; set; }
        [DataMember(Order = 1)]
        public string Surname { get; set; }
        [DataMember(Order = 2)]
        public DateTime DateOfBirth { get; set; }
    }
}
