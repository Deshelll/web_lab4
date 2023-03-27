using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Id
        { get; set; }
        [DataMember]
        public string Title
        { get; set; }
        [DataMember]
        public int Id_Customers
        { get; set; }
        [DataMember]
        public int Price
        { get; set; }
        [DataMember]
        public int Count
        { get; set; }
    }
}