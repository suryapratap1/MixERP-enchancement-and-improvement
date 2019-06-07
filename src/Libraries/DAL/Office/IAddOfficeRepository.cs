// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Office;
namespace MixERP.Net.Schemas.Office.Data
{
    public interface IAddOfficeRepository
    {

        string OfficeCode { get; set; }
        string OfficeName { get; set; }
        string NickName { get; set; }
        DateTime RegistrationDate { get; set; }
        string CurrencyCode { get; set; }
        string CurrencySymbol { get; set; }
        string CurrencyName { get; set; }
        string HundredthName { get; set; }
        string FiscalYearCode { get; set; }
        string FiscalYearName { get; set; }
        DateTime StartsFrom { get; set; }
        DateTime EndsOn { get; set; }
        bool SalesTaxIsVat { get; set; }
        bool HasStateSalesTax { get; set; }
        bool HasCountySalesTax { get; set; }
        int QuotationValidDays { get; set; }
        decimal IncomeTaxRate { get; set; }
        int WeekStartDay { get; set; }
        DateTime TransactionStartDate { get; set; }
        bool IsPerpetual { get; set; }
        string InvValuationMethod { get; set; }
        string LogoFile { get; set; }
        string AdminName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }

        /// <summary>
        /// Prepares and executes IAddOfficeRepository.
        /// </summary>
        void Execute();
    }
}