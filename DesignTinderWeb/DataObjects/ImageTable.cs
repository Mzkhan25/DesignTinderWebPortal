using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure.Mobile.Server;

namespace DesignTinderWeb.DataObjects
{
    public class ImageTable     : EntityData
    {
        public string ImageUrl { get; set; }
        public string UserName { get; set; }
        public bool UpVote { get; set; }
    }
}