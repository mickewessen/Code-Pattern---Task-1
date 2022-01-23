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
    {        
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();

            builder.RegisterType<Customer>().As<ICustomer>();
            builder.RegisterType<CustomerService>().As<CustomerService>();
            builder.RegisterType<Animal>().As<IAnimal>();
            builder.RegisterType<AnimalService>().As<AnimalService>();
            builder.RegisterType<Menu>().As<IMenu>();
            builder.RegisterType<PopulateMenu>().As<PopulateMenu>();
            builder.RegisterType<RecieptService>().As<RecieptService>();
            builder.RegisterType<DummyData>().As<DummyData>();
            builder.RegisterType<ReturnDataServices>().As<ReturnDataServices>();
            builder.RegisterType<ReturnDataAnimals>().As<ReturnDataAnimals>();
            builder.RegisterType<ReturnDataCustomers>().As<ReturnDataCustomers>();

            return builder.Build();
        }
    }
}
