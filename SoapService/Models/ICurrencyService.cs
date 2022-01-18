using System.ServiceModel;

namespace SoapService.Models
{
    [ServiceContract]
    public interface ICurrencyService
    {
        [OperationContract]
        public Amount ConvertToDkk(Amount amount);
    }
}
