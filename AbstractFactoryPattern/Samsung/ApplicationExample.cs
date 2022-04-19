

using AbstractFactoryPattern.Infrastructure;

namespace AbstractFactoryPattern.Samsung;

public class ApplicationExample
{
    private readonly IDevicesFactory _devicesFactory;

    public ApplicationExample(IDevicesFactory devicesFactory)
    {
        _devicesFactory = devicesFactory;
    }

    public void CreateAndConnectDevices()
    {
        var smartphone = _devicesFactory.CreateSmartphone();
        var smartwatch = _devicesFactory.CreateSmartwatch();

        smartphone.ConnectSmartwatch(smartwatch);
    }
}