using Autofac;
using Code_Pattern___Task_1.Interfaces;
using Code_Pattern___Task_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Pattern___Task_1
{
    public static class AFConfig
    {        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();

            builder.RegisterType<Customer>().As<ICustomer>();
            builder.RegisterType<CustomerService>().As<CustomerService>();
            builder.RegisterType<Animal>().As<IAnimal>();
            builder.RegisterType<AnimalService>().As<AnimalService>();
            builder.RegisterType<Menu>().As<IMenu>();
            builder.RegisterType<Reciept>().As<IReciept>();
            builder.RegisterType<DummyData>().As<DummyData>();
            builder.RegisterType<ReturnData>().As<ReturnData>();


            return builder.Build();
        }
    }
}
