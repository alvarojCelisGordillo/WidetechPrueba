using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WidetechPrueba.Core;

namespace WidetechPrueba.Data.Entities
{
    public class User : IIdentifiableEntity
    {
        public int Id  { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime RequestDate { get; set; }
        public int EntityId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}