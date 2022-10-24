using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WidetechPrueba.Contracts
{
    [DataContract]
    public class UserData
    {
        // Here is defined what ever goes through the wire, not exposing the whole data model to the client. 
        // Whatever properties are needed are defined here...
        [DataMember]
        public string UserToken { get; set; }
        [DataMember]
        public int UserId { get; set; }
    }
}