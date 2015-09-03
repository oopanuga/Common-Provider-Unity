
namespace CommonProvider.Unity.Example.Providers
{
    public interface ISmsProvider : IProvider
    {
        string SendSms(Message message);
    }
}
