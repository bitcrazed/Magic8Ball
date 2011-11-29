using System.ServiceModel;
using System.ServiceModel.Web;

namespace Magic8BallServiceHost
{
    [ServiceContract]
    public interface IMagic8Ball
    {
        [OperationContract]
        [WebGet(UriTemplate = "shake/{question}")]
        string Shake(string question);
    }
}
