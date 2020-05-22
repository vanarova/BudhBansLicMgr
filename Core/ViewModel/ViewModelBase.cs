using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Core.ViewModel
{
   public class ViewModelBase:INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            //var handler = PropertyChanged;

            //if (handler != null)
            //    handler(this, new PropertyChangedEventArgs(name));
        }

        
    }
}
