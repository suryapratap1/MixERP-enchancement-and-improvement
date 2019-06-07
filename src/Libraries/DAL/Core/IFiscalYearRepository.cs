// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IFiscalYearRepository
    {
        /// <summary>
        /// Counts the number of FiscalYear in IFiscalYearRepository.
        /// </summary>
        /// <returns>Returns the count of IFiscalYearRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of FiscalYear. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of FiscalYear.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYear> GetAll();

        /// <summary>
        /// Returns all instances of FiscalYear to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of FiscalYear.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the FiscalYear against fiscalYearCode. 
        /// </summary>
        /// <param name="fiscalYearCode">The column "fiscal_year_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of FiscalYear.</returns>
        MixERP.Net.Entities.Core.FiscalYear Get(string fiscalYearCode);

        /// <summary>
        /// Gets the first record of FiscalYear.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of FiscalYear.</returns>
        MixERP.Net.Entities.Core.FiscalYear GetFirst();

        /// <summary>
        /// Gets the previous record of FiscalYear sorted by fiscalYearCode. 
        /// </summary>
        /// <param name="fiscalYearCode">The column "fiscal_year_code" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of FiscalYear.</returns>
        MixERP.Net.Entities.Core.FiscalYear GetPrevious(string fiscalYearCode);

        /// <summary>
        /// Gets the next record of FiscalYear sorted by fiscalYearCode. 
        /// </summary>
        /// <param name="fiscalYearCode">The column "fiscal_year_code" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of FiscalYear.</returns>
        MixERP.Net.Entities.Core.FiscalYear GetNext(string fiscalYearCode);

        /// <summary>
        /// Gets the last record of FiscalYear.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of FiscalYear.</returns>
        MixERP.Net.Entities.Core.FiscalYear GetLast();

        /// <summary>
        /// Returns multiple instances of the FiscalYear against fiscalYearCodes. 
        /// </summary>
        /// <param name="fiscalYearCodes">Array of column "fiscal_year_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of FiscalYear.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYear> Get(string[] fiscalYearCodes);

        /// <summary>
        /// Custom fields are user defined form elements for IFiscalYearRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for FiscalYear.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding FiscalYear.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for FiscalYear.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of FiscalYear class to IFiscalYearRepository.
        /// </summary>
        /// <param name="fiscalYear">The instance of FiscalYear class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic fiscalYear, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of FiscalYear class to IFiscalYearRepository.
        /// </summary>
        /// <param name="fiscalYear">The instance of FiscalYear class to insert.</param>
        object Add(dynamic fiscalYear);

        /// <summary>
        /// Inserts or updates multiple instances of FiscalYear class to IFiscalYearRepository.;
        /// </summary>
        /// <param name="fiscalYears">List of FiscalYear class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> fiscalYears);


        /// <summary>
        /// Updates IFiscalYearRepository with an instance of FiscalYear class against the primary key value.
        /// </summary>
        /// <param name="fiscalYear">The instance of FiscalYear class to update.</param>
        /// <param name="fiscalYearCode">The value of the column "fiscal_year_code" which will be updated.</param>
        void Update(dynamic fiscalYear, string fiscalYearCode);

        /// <summary>
        /// Deletes FiscalYear from  IFiscalYearRepository against the primary key value.
        /// </summary>
        /// <param name="fiscalYearCode">The value of the column "fiscal_year_code" which will be deleted.</param>
        void Delete(string fiscalYearCode);

        /// <summary>
        /// Produces a paginated result of 10 FiscalYear classes.
        /// </summary>
        /// <returns>Returns the first page of collection of FiscalYear class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYear> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 FiscalYear classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of FiscalYear class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYear> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IFiscalYearRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of FiscalYear class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IFiscalYearRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of FiscalYear class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYear> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IFiscalYearRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of FiscalYear class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IFiscalYearRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of FiscalYear class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYear> GetFiltered(long pageNumber, string filterName);



    }
}