using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectImplementation
{
    public class BusinessLogicLayer
    {
        private IRetail _retail;
        public BusinessLogicLayer(IRetail retail)
        {
            _retail = retail;   
        }

        public void GetRetail()
        {
            Console.WriteLine(_retail.AddRetail());
        }
    }
}
