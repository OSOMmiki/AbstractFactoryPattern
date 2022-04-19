using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Infrastructure;

namespace AbstractFactoryPattern.Samsung
{
    public class SamsungFactory : IDevicesFactory

    {
        public ISmartphone CreateSmartphone()
        {
            return new SamsungPhone();
        }

        public ISmartwatch CreateSmartwatch()
        {
            return new SamsungWatch();
        }
    }
}
