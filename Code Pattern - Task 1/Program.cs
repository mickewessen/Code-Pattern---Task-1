using Autofac;
using Code_Pattern___Task_1.Interfaces;
using System;

namespace Code_Pattern___Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AFConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}
