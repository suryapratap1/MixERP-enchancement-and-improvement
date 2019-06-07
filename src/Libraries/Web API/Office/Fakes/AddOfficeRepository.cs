// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class AddOfficeRepository : IAddOfficeRepository
    {
        public string OfficeCode { get; set; }
        public string OfficeName { get; set; }
        public string NickName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencyName { get; set; }
        public string HundredthName { get; set; }
        public string FiscalYearCode { get; set; }
        public string FiscalYearName { get; set; }
        public DateTime StartsFrom { get; set; }
        public DateTime EndsOn { get; set; }
        public bool SalesTaxIsVat { get; set; }
        public bool HasStateSalesTax { get; set; }
        public bool HasCountySalesTax { get; set; }
        public int QuotationValidDays { get; set; }
        public decimal IncomeTaxRate { get; set; }
        public int WeekStartDay { get; set; }
        public DateTime TransactionStartDate { get; set; }
        public bool IsPerpetual { get; set; }
        public string InvValuationMethod { get; set; }
        public string LogoFile { get; set; }
        public string AdminName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public void Execute()
        {
            return;
        }
    }
}