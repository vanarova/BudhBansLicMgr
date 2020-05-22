using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Alerts
    {
        public List<Alert> AlertList {get; set; }
    }

   public class Alert
    {
       
        public string AlertName { get; set; }
        public string AlertGUID { get; set; }
        public string AlertHtml { get; set; }
    }


}
