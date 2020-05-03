using System;
using System.Collections.Generic;
using System.Text;
using Core.ViewModel;
using LightInject;

namespace Core.Helper
{
   public class LightInjectHelper
    {
        private ServiceContainer _service;
        public ServiceContainer service { get { return _service; } }
        public LightInjectHelper()
        {
            _service = new ServiceContainer();
            _service.Register<I_VM_Alert, VM_Alert>();
            _service.Register<ILoggingServiceHelper, LoggingServiceHelper>(new LightInject.PerContainerLifetime());
        }
    }
}
