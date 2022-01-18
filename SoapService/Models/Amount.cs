using System.Runtime.Serialization;

namespace SoapService.Models
{
    [DataContract]
    public class Amount
    {
        [DataMember]
        public double Value { get; set; }
        [DataMember]
        public string Currency { get; set; }
    }
}
