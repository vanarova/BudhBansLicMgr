using Core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModel
{
   public class VM_Alert : ViewModelBase, I_VM_Alert
    {
        private Model.Alerts m_Alerts;
        private List<I_VM_Alert> vm_Alerts;
        private string _AlertLabel;
        private string _AlertGUID;
        private string _AlertHtml;
        private string _AlertValue;


        private VM_Alert CreateNewAlert()
        {
            return (new VM_Alert() { AlertLabel = "New Alert", AlertGUID = Guid.NewGuid().ToString(), AlertHtml = "<p>Some Value</p>" , AlertValue = "Some Value"});
        }

        public void AddNewAlert()
        {
            vm_Alerts.Add(CreateNewAlert());
        }

        public VM_Alert()
        {
            m_Alerts = new Model.Alerts();
            vm_Alerts = new List<I_VM_Alert>();
        }

        public List<I_VM_Alert> Alerts
        {
        get
            {
                if (vm_Alerts.Count == 0)
                {
                    //vm_Alerts.AlertList = new List<Model.Alert>();
                    vm_Alerts.Add(CreateNewAlert());
                    return vm_Alerts;
                }
                else
                {
                    return vm_Alerts;
                }

            }
            
        }


        public string AlertLabel
        {
            get { return _AlertLabel; }
            set
            {
                if (_AlertLabel!=value)
                {
                    _AlertLabel = value;
                    OnPropertyChanged("AlertName");
                }
            }
        }

        public string AlertValue
        {
            get { return _AlertValue; }
            set
            {
                if (_AlertValue != value)
                {
                    _AlertValue = value;
                    OnPropertyChanged("AlertValue");
                }
            }
        }

        public string AlertGUID
        {
            get { return _AlertGUID; }
            set
            {
                if (_AlertGUID != value)
                {
                    _AlertGUID = value;
                    OnPropertyChanged("AlertGUID");
                }
            }
        }

        public string AlertHtml
        {
            get { return _AlertHtml; }
            set
            {
                if (_AlertHtml != value)
                {
                    _AlertHtml = value;
                    OnPropertyChanged("AlertHtml");
                }
            }
        }

     
        public void SaveAlertsToModel()
        {
            foreach (var item in vm_Alerts)
            {
                m_Alerts.AlertList.Add(new Alert()
                {
                    AlertName = item.AlertLabel,
                    AlertGUID = item.AlertGUID,
                    AlertHtml = item.AlertHtml
                });
            }
        }
    }
}
