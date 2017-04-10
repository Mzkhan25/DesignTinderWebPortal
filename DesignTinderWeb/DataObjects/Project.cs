using System.Collections.Generic;
using Microsoft.Azure.Mobile.Server;

namespace DesignTinderWeb.DataObjects
{
    public class Project: EntityData
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string URL { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
    }
}