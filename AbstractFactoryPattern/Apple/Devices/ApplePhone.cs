using AbstractFactoryPattern.Infrastructure;

namespace AbstractFactoryPattern.Apple;

public class ApplePhone : ISmartphone
{
    public bool ConnectSmartwatch(ISmartwatch smartwatch)
    {
        return smartwatch is AppleWatch;
    }
}