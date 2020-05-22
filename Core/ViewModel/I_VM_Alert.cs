using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModel
{
    public interface I_VM_Alert
    {

        void AddNewAlert();
        //void SaveAlertsToModel();

        List<I_VM_Alert> Alerts { get; }

  
        string AlertLabel { get; set; }
 
        string AlertGUID { get; set; }
  
        string AlertHtml { get; set; }

        string AlertValue { get; set; }
    }
}
