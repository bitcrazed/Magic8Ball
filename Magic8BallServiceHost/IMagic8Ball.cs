using System.ServiceModel;

namespace Magic8BallServiceHost
{
    [ServiceContract]
    public interface IMagic8Ball
    {
        [OperationContract]
        string Shake(string question);
    }
}
