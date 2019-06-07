using System;

namespace MixERP.Net.FrontEnd.Models
{
    [Serializable]
    public class InstallConfig
    {
        public string OfficeCode { get; set; }
        public string OfficeName { get; set; }
        public string NickName { get; set; }
        public string RegistrationDate { get; set; }
        public string CurrencyCode;
        public string CurrencySymbol;
        public string CurrencyName;
        public string HundredthName;
        public string RegionalDataPath;
        public string FiscalYearCode;
        public string FiscalYearName;
        public string StartsFrom;
        public string EndsOn;
        public bool SalesTaxIsVat;
        public bool HasStateSalesTax;
        public bool HasCountySalesTax;
        public int QuotationValidDays;
        public decimal IncomeTaxRate;
        public int WeekStartDay;
        public string TransactionStartDate;
        public bool IsPerpetual;
        public string ValuationMethod;
        public string Logo;
        public string AdminName;
        public string Username;
        public string Password;
        public string ConfirmPassword;
    }
}