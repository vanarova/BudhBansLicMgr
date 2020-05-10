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
            //Rgister class/services 
            _service.Register<ILoggingServiceHelper, LoggingServiceHelper>(new LightInject.PerContainerLifetime());
        }

        public void RegisterInstance<T>(T instance)
        {
            _service.RegisterInstance<T>(instance);

        }

    }
}
