using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectImplementation
{
    public class NinjectModules: Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IRetail>().To<DataAccessLayer>();
        }
    }
}
