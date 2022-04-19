using AbstractFactoryPattern.Infrastructure;

namespace AbstractFactoryPattern.Samsung;

public class SamsungPhone : ISmartphone
{
    public bool ConnectSmartwatch(ISmartwatch smartwatch)
    {
        return smartwatch is SamsungWatch;
    }
}