using Caliburn.Micro;
using CaliburnTestProject.ViewModels;
using System;
using System.Collections.Generic;

namespace CaliburnTestProject
{
    public class Bootstrap: PhoneBootstrapper
    {
        private PhoneContainer container;
        protected override void Configure()
        {
            container = new PhoneContainer();
            container.RegisterPhoneServices(RootFrame);
            container.PerRequest<MainPageViewModel>();
            container.PerRequest<SecondPageViewModel>();
        }

        static void AddCustomConventions()
        {
            //ellided  
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }
    }
}
