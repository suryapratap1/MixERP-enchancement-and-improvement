// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICashFlowHeadingRepository
    {
        /// <summary>
        /// Counts the number of CashFlowHeading in ICashFlowHeadingRepository.
        /// </summary>
        /// <returns>Returns the count of ICashFlowHeadingRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of CashFlowHeading. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CashFlowHeading.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> GetAll();

        /// <summary>
        /// Returns all instances of CashFlowHeading to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CashFlowHeading.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the CashFlowHeading against cashFlowHeadingId. 
        /// </summary>
        /// <param name="cashFlowHeadingId">The column "cash_flow_heading_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of CashFlowHeading.</returns>
        MixERP.Net.Entities.Core.CashFlowHeading Get(int cashFlowHeadingId);

        /// <summary>
        /// Gets the first record of CashFlowHeading.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CashFlowHeading.</returns>
        MixERP.Net.Entities.Core.CashFlowHeading GetFirst();

        /// <summary>
        /// Gets the previous record of CashFlowHeading sorted by cashFlowHeadingId. 
        /// </summary>
        /// <param name="cashFlowHeadingId">The column "cash_flow_heading_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CashFlowHeading.</returns>
        MixERP.Net.Entities.Core.CashFlowHeading GetPrevious(int cashFlowHeadingId);

        /// <summary>
        /// Gets the next record of CashFlowHeading sorted by cashFlowHeadingId. 
        /// </summary>
        /// <param name="cashFlowHeadingId">The column "cash_flow_heading_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CashFlowHeading.</returns>
        MixERP.Net.Entities.Core.CashFlowHeading GetNext(int cashFlowHeadingId);

        /// <summary>
        /// Gets the last record of CashFlowHeading.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CashFlowHeading.</returns>
        MixERP.Net.Entities.Core.CashFlowHeading GetLast();

        /// <summary>
        /// Returns multiple instances of the CashFlowHeading against cashFlowHeadingIds. 
        /// </summary>
        /// <param name="cashFlowHeadingIds">Array of column "cash_flow_heading_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of CashFlowHeading.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> Get(int[] cashFlowHeadingIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICashFlowHeadingRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for CashFlowHeading.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding CashFlowHeading.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for CashFlowHeading.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of CashFlowHeading class to ICashFlowHeadingRepository.
        /// </summary>
        /// <param name="cashFlowHeading">The instance of CashFlowHeading class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic cashFlowHeading, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of CashFlowHeading class to ICashFlowHeadingRepository.
        /// </summary>
        /// <param name="cashFlowHeading">The instance of CashFlowHeading class to insert.</param>
        object Add(dynamic cashFlowHeading);

        /// <summary>
        /// Inserts or updates multiple instances of CashFlowHeading class to ICashFlowHeadingRepository.;
        /// </summary>
        /// <param name="cashFlowHeadings">List of CashFlowHeading class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> cashFlowHeadings);


        /// <summary>
        /// Updates ICashFlowHeadingRepository with an instance of CashFlowHeading class against the primary key value.
        /// </summary>
        /// <param name="cashFlowHeading">The instance of CashFlowHeading class to update.</param>
        /// <param name="cashFlowHeadingId">The value of the column "cash_flow_heading_id" which will be updated.</param>
        void Update(dynamic cashFlowHeading, int cashFlowHeadingId);

        /// <summary>
        /// Deletes CashFlowHeading from  ICashFlowHeadingRepository against the primary key value.
        /// </summary>
        /// <param name="cashFlowHeadingId">The value of the column "cash_flow_heading_id" which will be deleted.</param>
        void Delete(int cashFlowHeadingId);

        /// <summary>
        /// Produces a paginated result of 10 CashFlowHeading classes.
        /// </summary>
        /// <returns>Returns the first page of collection of CashFlowHeading class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 CashFlowHeading classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of CashFlowHeading class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICashFlowHeadingRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of CashFlowHeading class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICashFlowHeadingRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of CashFlowHeading class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICashFlowHeadingRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of CashFlowHeading class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICashFlowHeadingRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of CashFlowHeading class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> GetFiltered(long pageNumber, string filterName);



    }
}