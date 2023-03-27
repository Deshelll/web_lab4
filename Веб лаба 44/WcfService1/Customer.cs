using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id
        { get; set; }
        [DataMember]
        public string Name
        { get; set; }
        [DataMember]
        public string Surname
        { get; set; }
        [DataMember]
        public int Year
        { get; set; }
    }
}