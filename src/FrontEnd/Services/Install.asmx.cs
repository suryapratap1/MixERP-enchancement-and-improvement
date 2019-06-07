using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework;
using MixERP.Net.FrontEnd.Models;
using MixERP.Net.i18n.Resources;
using Serilog;

namespace MixERP.Net.FrontEnd.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Install : WebService
    {
        [WebMethod]
        public bool SaveOffice(InstallConfig config)
        {
            if (string.IsNullOrWhiteSpace(config.OfficeName) ||
                string.IsNullOrWhiteSpace(config.OfficeCode) ||
                string.IsNullOrWhiteSpace(config.NickName) ||
                string.IsNullOrWhiteSpace(config.RegistrationDate) ||
                string.IsNullOrWhiteSpace(config.CurrencyCode) ||
                string.IsNullOrWhiteSpace(config.CurrencySymbol) ||
                string.IsNullOrWhiteSpace(config.CurrencyName) ||
                string.IsNullOrWhiteSpace(config.HundredthName) ||
                string.IsNullOrWhiteSpace(config.FiscalYearCode) ||
                string.IsNullOrWhiteSpace(config.FiscalYearName) ||
                string.IsNullOrWhiteSpace(config.StartsFrom) ||
                string.IsNullOrWhiteSpace(config.EndsOn) ||
                string.IsNullOrWhiteSpace(config.AdminName) ||
                string.IsNullOrWhiteSpace(config.Username) ||
                string.IsNullOrWhiteSpace(config.Password) ||
                string.IsNullOrWhiteSpace(config.ConfirmPassword) ||
                string.IsNullOrWhiteSpace(config.RegionalDataPath))
            {
                throw new MixERPException(Labels.AllFieldsRequired);
            }

            if (!new[] { "FIFO", "LIFO", "MAVCO" }.Contains(config.ValuationMethod))
            {
                throw new MixERPException("Invalid inventory valuation method specified.");
            }

            if (config.Password != config.ConfirmPassword)
            {
                throw new MixERPException(Warnings.ConfirmationPasswordDoesNotMatch);
            }


            DateTime dateOfRegistration = Convert.ToDateTime(config.RegistrationDate);
            DateTime fiscalYearStartDate = Convert.ToDateTime(config.StartsFrom);
            DateTime fiscalYearEndDate = Convert.ToDateTime(config.EndsOn);
            DateTime transactionStartsFrom = Convert.ToDateTime(config.TransactionStartDate);
            string regionalDataFullPath = this.GetRegionalDataFullPath(config.RegionalDataPath);

            if (string.IsNullOrWhiteSpace(regionalDataFullPath))
            {
                throw new MixERPException(Errors.RegionalDataFileNotFound);
            }

            if (fiscalYearStartDate > fiscalYearEndDate)
            {
                throw new MixERPException(Warnings.StartDateGreaterThanEndDate);
            }

            if (transactionStartsFrom > fiscalYearEndDate)
            {
                throw new MixERPException("Transaction start date cannot be greater than fiscal year end date.");
            }




            try
            {
                Data.Office.Offices.SaveOffice
                    (
                    AppUsers.GetCurrentUserDB(),
                    regionalDataFullPath,
                    config.OfficeCode,
                    config.OfficeName,
                    config.NickName,
                    dateOfRegistration,
                    config.CurrencyCode,
                    config.CurrencySymbol,
                    config.CurrencyName,
                    config.HundredthName,
                    config.FiscalYearCode,
                    config.FiscalYearName,
                    fiscalYearStartDate,
                    fiscalYearEndDate,
                    config.SalesTaxIsVat,
                    config.HasStateSalesTax,
                    config.HasCountySalesTax,
                    config.QuotationValidDays,
                    config.IncomeTaxRate,
                    config.WeekStartDay,
                    transactionStartsFrom,
                    config.IsPerpetual,
                    config.ValuationMethod,
                    config.Logo,
                    config.AdminName,
                    config.Username,
                    config.Password
                    );

                return true;
            }
            catch (Exception ex)
            {
                Log.Warning("Could not save office. {Exception}", ex);
                throw;
            }
        }

        private string GetRegionalDataFullPath(string fileName)
        {
            string path = "/Installation/regional/" + fileName + ".sql";
            path = HostingEnvironment.MapPath(path);

            if (File.Exists(path))
            {
                return path;
            }

            return string.Empty;
        }

        [WebMethod]
        public List<RegionalData> GetRegionalDataList()
        {
            return RegionalData.GetRegionalDataList();
        }
    }
}