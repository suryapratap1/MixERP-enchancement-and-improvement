// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Office;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Office.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "office.add_office(_office_code character varying, _office_name character varying, _nick_name character varying, _registration_date date, _currency_code character varying, _currency_symbol character varying, _currency_name character varying, _hundredth_name character varying, _fiscal_year_code character varying, _fiscal_year_name character varying, _starts_from date, _ends_on date, _sales_tax_is_vat boolean, _has_state_sales_tax boolean, _has_county_sales_tax boolean, _quotation_valid_days integer, _income_tax_rate numeric, _week_start_day integer, _transaction_start_date date, _is_perpetual boolean, _inv_valuation_method character varying, _logo_file text, _admin_name character varying, _user_name character varying, _password character varying)" on the database.
    /// </summary>
    public class AddOfficeProcedure : DbAccess, IAddOfficeRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "office";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "add_office";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
        public long _LoginId { get; set; }
        /// <summary>
        /// User id of application user accessing this table.
        /// </summary>
        public int _UserId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string _Catalog { get; set; }

        /// <summary>
        /// Maps to "_office_code" argument of the function "office.add_office".
        /// </summary>
        public string OfficeCode { get; set; }
        /// <summary>
        /// Maps to "_office_name" argument of the function "office.add_office".
        /// </summary>
        public string OfficeName { get; set; }
        /// <summary>
        /// Maps to "_nick_name" argument of the function "office.add_office".
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// Maps to "_registration_date" argument of the function "office.add_office".
        /// </summary>
        public DateTime RegistrationDate { get; set; }
        /// <summary>
        /// Maps to "_currency_code" argument of the function "office.add_office".
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Maps to "_currency_symbol" argument of the function "office.add_office".
        /// </summary>
        public string CurrencySymbol { get; set; }
        /// <summary>
        /// Maps to "_currency_name" argument of the function "office.add_office".
        /// </summary>
        public string CurrencyName { get; set; }
        /// <summary>
        /// Maps to "_hundredth_name" argument of the function "office.add_office".
        /// </summary>
        public string HundredthName { get; set; }
        /// <summary>
        /// Maps to "_fiscal_year_code" argument of the function "office.add_office".
        /// </summary>
        public string FiscalYearCode { get; set; }
        /// <summary>
        /// Maps to "_fiscal_year_name" argument of the function "office.add_office".
        /// </summary>
        public string FiscalYearName { get; set; }
        /// <summary>
        /// Maps to "_starts_from" argument of the function "office.add_office".
        /// </summary>
        public DateTime StartsFrom { get; set; }
        /// <summary>
        /// Maps to "_ends_on" argument of the function "office.add_office".
        /// </summary>
        public DateTime EndsOn { get; set; }
        /// <summary>
        /// Maps to "_sales_tax_is_vat" argument of the function "office.add_office".
        /// </summary>
        public bool SalesTaxIsVat { get; set; }
        /// <summary>
        /// Maps to "_has_state_sales_tax" argument of the function "office.add_office".
        /// </summary>
        public bool HasStateSalesTax { get; set; }
        /// <summary>
        /// Maps to "_has_county_sales_tax" argument of the function "office.add_office".
        /// </summary>
        public bool HasCountySalesTax { get; set; }
        /// <summary>
        /// Maps to "_quotation_valid_days" argument of the function "office.add_office".
        /// </summary>
        public int QuotationValidDays { get; set; }
        /// <summary>
        /// Maps to "_income_tax_rate" argument of the function "office.add_office".
        /// </summary>
        public decimal IncomeTaxRate { get; set; }
        /// <summary>
        /// Maps to "_week_start_day" argument of the function "office.add_office".
        /// </summary>
        public int WeekStartDay { get; set; }
        /// <summary>
        /// Maps to "_transaction_start_date" argument of the function "office.add_office".
        /// </summary>
        public DateTime TransactionStartDate { get; set; }
        /// <summary>
        /// Maps to "_is_perpetual" argument of the function "office.add_office".
        /// </summary>
        public bool IsPerpetual { get; set; }
        /// <summary>
        /// Maps to "_inv_valuation_method" argument of the function "office.add_office".
        /// </summary>
        public string InvValuationMethod { get; set; }
        /// <summary>
        /// Maps to "_logo_file" argument of the function "office.add_office".
        /// </summary>
        public string LogoFile { get; set; }
        /// <summary>
        /// Maps to "_admin_name" argument of the function "office.add_office".
        /// </summary>
        public string AdminName { get; set; }
        /// <summary>
        /// Maps to "_user_name" argument of the function "office.add_office".
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Maps to "_password" argument of the function "office.add_office".
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "office.add_office(_office_code character varying, _office_name character varying, _nick_name character varying, _registration_date date, _currency_code character varying, _currency_symbol character varying, _currency_name character varying, _hundredth_name character varying, _fiscal_year_code character varying, _fiscal_year_name character varying, _starts_from date, _ends_on date, _sales_tax_is_vat boolean, _has_state_sales_tax boolean, _has_county_sales_tax boolean, _quotation_valid_days integer, _income_tax_rate numeric, _week_start_day integer, _transaction_start_date date, _is_perpetual boolean, _inv_valuation_method character varying, _logo_file text, _admin_name character varying, _user_name character varying, _password character varying)" on the database.
        /// </summary>
        public AddOfficeProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "office.add_office(_office_code character varying, _office_name character varying, _nick_name character varying, _registration_date date, _currency_code character varying, _currency_symbol character varying, _currency_name character varying, _hundredth_name character varying, _fiscal_year_code character varying, _fiscal_year_name character varying, _starts_from date, _ends_on date, _sales_tax_is_vat boolean, _has_state_sales_tax boolean, _has_county_sales_tax boolean, _quotation_valid_days integer, _income_tax_rate numeric, _week_start_day integer, _transaction_start_date date, _is_perpetual boolean, _inv_valuation_method character varying, _logo_file text, _admin_name character varying, _user_name character varying, _password character varying)" on the database.
        /// </summary>
        /// <param name="officeCode">Enter argument value for "_office_code" parameter of the function "office.add_office".</param>
        /// <param name="officeName">Enter argument value for "_office_name" parameter of the function "office.add_office".</param>
        /// <param name="nickName">Enter argument value for "_nick_name" parameter of the function "office.add_office".</param>
        /// <param name="registrationDate">Enter argument value for "_registration_date" parameter of the function "office.add_office".</param>
        /// <param name="currencyCode">Enter argument value for "_currency_code" parameter of the function "office.add_office".</param>
        /// <param name="currencySymbol">Enter argument value for "_currency_symbol" parameter of the function "office.add_office".</param>
        /// <param name="currencyName">Enter argument value for "_currency_name" parameter of the function "office.add_office".</param>
        /// <param name="hundredthName">Enter argument value for "_hundredth_name" parameter of the function "office.add_office".</param>
        /// <param name="fiscalYearCode">Enter argument value for "_fiscal_year_code" parameter of the function "office.add_office".</param>
        /// <param name="fiscalYearName">Enter argument value for "_fiscal_year_name" parameter of the function "office.add_office".</param>
        /// <param name="startsFrom">Enter argument value for "_starts_from" parameter of the function "office.add_office".</param>
        /// <param name="endsOn">Enter argument value for "_ends_on" parameter of the function "office.add_office".</param>
        /// <param name="salesTaxIsVat">Enter argument value for "_sales_tax_is_vat" parameter of the function "office.add_office".</param>
        /// <param name="hasStateSalesTax">Enter argument value for "_has_state_sales_tax" parameter of the function "office.add_office".</param>
        /// <param name="hasCountySalesTax">Enter argument value for "_has_county_sales_tax" parameter of the function "office.add_office".</param>
        /// <param name="quotationValidDays">Enter argument value for "_quotation_valid_days" parameter of the function "office.add_office".</param>
        /// <param name="incomeTaxRate">Enter argument value for "_income_tax_rate" parameter of the function "office.add_office".</param>
        /// <param name="weekStartDay">Enter argument value for "_week_start_day" parameter of the function "office.add_office".</param>
        /// <param name="transactionStartDate">Enter argument value for "_transaction_start_date" parameter of the function "office.add_office".</param>
        /// <param name="isPerpetual">Enter argument value for "_is_perpetual" parameter of the function "office.add_office".</param>
        /// <param name="invValuationMethod">Enter argument value for "_inv_valuation_method" parameter of the function "office.add_office".</param>
        /// <param name="logoFile">Enter argument value for "_logo_file" parameter of the function "office.add_office".</param>
        /// <param name="adminName">Enter argument value for "_admin_name" parameter of the function "office.add_office".</param>
        /// <param name="userName">Enter argument value for "_user_name" parameter of the function "office.add_office".</param>
        /// <param name="password">Enter argument value for "_password" parameter of the function "office.add_office".</param>
        public AddOfficeProcedure(string officeCode, string officeName, string nickName, DateTime registrationDate, string currencyCode, string currencySymbol, string currencyName, string hundredthName, string fiscalYearCode, string fiscalYearName, DateTime startsFrom, DateTime endsOn, bool salesTaxIsVat, bool hasStateSalesTax, bool hasCountySalesTax, int quotationValidDays, decimal incomeTaxRate, int weekStartDay, DateTime transactionStartDate, bool isPerpetual, string invValuationMethod, string logoFile, string adminName, string userName, string password)
        {
            this.OfficeCode = officeCode;
            this.OfficeName = officeName;
            this.NickName = nickName;
            this.RegistrationDate = registrationDate;
            this.CurrencyCode = currencyCode;
            this.CurrencySymbol = currencySymbol;
            this.CurrencyName = currencyName;
            this.HundredthName = hundredthName;
            this.FiscalYearCode = fiscalYearCode;
            this.FiscalYearName = fiscalYearName;
            this.StartsFrom = startsFrom;
            this.EndsOn = endsOn;
            this.SalesTaxIsVat = salesTaxIsVat;
            this.HasStateSalesTax = hasStateSalesTax;
            this.HasCountySalesTax = hasCountySalesTax;
            this.QuotationValidDays = quotationValidDays;
            this.IncomeTaxRate = incomeTaxRate;
            this.WeekStartDay = weekStartDay;
            this.TransactionStartDate = transactionStartDate;
            this.IsPerpetual = isPerpetual;
            this.InvValuationMethod = invValuationMethod;
            this.LogoFile = logoFile;
            this.AdminName = adminName;
            this.UserName = userName;
            this.Password = password;
        }
        /// <summary>
        /// Prepares and executes the function "office.add_office".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"AddOfficeProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM office.add_office(@OfficeCode, @OfficeName, @NickName, @RegistrationDate, @CurrencyCode, @CurrencySymbol, @CurrencyName, @HundredthName, @FiscalYearCode, @FiscalYearName, @StartsFrom, @EndsOn, @SalesTaxIsVat, @HasStateSalesTax, @HasCountySalesTax, @QuotationValidDays, @IncomeTaxRate, @WeekStartDay, @TransactionStartDate, @IsPerpetual, @InvValuationMethod, @LogoFile, @AdminName, @UserName, @Password);";

            query = query.ReplaceWholeWord("@OfficeCode", "@0::character varying");
            query = query.ReplaceWholeWord("@OfficeName", "@1::character varying");
            query = query.ReplaceWholeWord("@NickName", "@2::character varying");
            query = query.ReplaceWholeWord("@RegistrationDate", "@3::date");
            query = query.ReplaceWholeWord("@CurrencyCode", "@4::character varying");
            query = query.ReplaceWholeWord("@CurrencySymbol", "@5::character varying");
            query = query.ReplaceWholeWord("@CurrencyName", "@6::character varying");
            query = query.ReplaceWholeWord("@HundredthName", "@7::character varying");
            query = query.ReplaceWholeWord("@FiscalYearCode", "@8::character varying");
            query = query.ReplaceWholeWord("@FiscalYearName", "@9::character varying");
            query = query.ReplaceWholeWord("@StartsFrom", "@10::date");
            query = query.ReplaceWholeWord("@EndsOn", "@11::date");
            query = query.ReplaceWholeWord("@SalesTaxIsVat", "@12::boolean");
            query = query.ReplaceWholeWord("@HasStateSalesTax", "@13::boolean");
            query = query.ReplaceWholeWord("@HasCountySalesTax", "@14::boolean");
            query = query.ReplaceWholeWord("@QuotationValidDays", "@15::integer");
            query = query.ReplaceWholeWord("@IncomeTaxRate", "@16::numeric");
            query = query.ReplaceWholeWord("@WeekStartDay", "@17::integer");
            query = query.ReplaceWholeWord("@TransactionStartDate", "@18::date");
            query = query.ReplaceWholeWord("@IsPerpetual", "@19::boolean");
            query = query.ReplaceWholeWord("@InvValuationMethod", "@20::character varying");
            query = query.ReplaceWholeWord("@LogoFile", "@21::text");
            query = query.ReplaceWholeWord("@AdminName", "@22::character varying");
            query = query.ReplaceWholeWord("@UserName", "@23::character varying");
            query = query.ReplaceWholeWord("@Password", "@24::character varying");


            List<object> parameters = new List<object>();
            parameters.Add(this.OfficeCode);
            parameters.Add(this.OfficeName);
            parameters.Add(this.NickName);
            parameters.Add(this.RegistrationDate);
            parameters.Add(this.CurrencyCode);
            parameters.Add(this.CurrencySymbol);
            parameters.Add(this.CurrencyName);
            parameters.Add(this.HundredthName);
            parameters.Add(this.FiscalYearCode);
            parameters.Add(this.FiscalYearName);
            parameters.Add(this.StartsFrom);
            parameters.Add(this.EndsOn);
            parameters.Add(this.SalesTaxIsVat);
            parameters.Add(this.HasStateSalesTax);
            parameters.Add(this.HasCountySalesTax);
            parameters.Add(this.QuotationValidDays);
            parameters.Add(this.IncomeTaxRate);
            parameters.Add(this.WeekStartDay);
            parameters.Add(this.TransactionStartDate);
            parameters.Add(this.IsPerpetual);
            parameters.Add(this.InvValuationMethod);
            parameters.Add(this.LogoFile);
            parameters.Add(this.AdminName);
            parameters.Add(this.UserName);
            parameters.Add(this.Password);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}