namespace AbstractFactoryPattern.Infrastructure;

public interface IDevicesFactory
{
    ISmartphone CreateSmartphone();
    ISmartwatch CreateSmartwatch();
}