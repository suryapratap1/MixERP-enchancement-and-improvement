using System.Collections.Generic;

namespace MixERP.Net.Framework.Contracts.Currency
{
    public interface ICurrencyConverter
    {
        bool Enabled { get; }
        string ConfigFileName { get; }
        string ConverterName { get; }
        string BaseCurrency { get; set; }
        List<string> CurrencyCodes { get; set; }
        IEnumerable<CurrencyConversionResult> GetResult();
    }
}