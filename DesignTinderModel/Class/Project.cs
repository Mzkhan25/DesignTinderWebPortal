using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignTinderModel.Class
{
    public class Project : EntityData
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string URL { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
    }
}