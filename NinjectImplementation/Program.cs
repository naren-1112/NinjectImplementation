using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NinjectImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            IRetail retail = kernel.Get<IRetail>();
            BusinessLogicLayer BL = new BusinessLogicLayer(retail);
            BL.GetRetail();
            Console.ReadLine();
        }
    }
}