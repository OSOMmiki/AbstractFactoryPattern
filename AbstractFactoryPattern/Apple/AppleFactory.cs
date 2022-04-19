using AbstractFactoryPattern.Infrastructure;
using AbstractFactoryPattern.Samsung;

namespace AbstractFactoryPattern.Apple;

public class AppleFactory : IDevicesFactory
{
    public ISmartphone CreateSmartphone()
    {
        return new ApplePhone();
    }

    public ISmartwatch CreateSmartwatch()
    {
        return new SamsungWatch();
    }
}