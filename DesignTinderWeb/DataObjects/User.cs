using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure.Mobile.Server;

namespace DesignTinderWeb.DataObjects
{
    public class User : EntityData
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}