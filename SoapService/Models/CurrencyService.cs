namespace SoapService.Models
{
    public class CurrencyService : ICurrencyService
    {
        public Amount ConvertToDkk(Amount amount)
        {
            Amount result = new();
            result.Currency = "DKK";
            if (amount.Currency == "USD")
            {
                result.Value = amount.Value * 5.53;
                return result;
            } else
            {
                return amount;
            }
        }
    }
}
