// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICashFlowSetupRepository
    {
        /// <summary>
        /// Counts the number of CashFlowSetup in ICashFlowSetupRepository.
        /// </summary>
        /// <returns>Returns the count of ICashFlowSetupRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of CashFlowSetup. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CashFlowSetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> GetAll();

        /// <summary>
        /// Returns all instances of CashFlowSetup to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CashFlowSetup.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the CashFlowSetup against cashFlowSetupId. 
        /// </summary>
        /// <param name="cashFlowSetupId">The column "cash_flow_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of CashFlowSetup.</returns>
        MixERP.Net.Entities.Core.CashFlowSetup Get(int cashFlowSetupId);

        /// <summary>
        /// Gets the first record of CashFlowSetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CashFlowSetup.</returns>
        MixERP.Net.Entities.Core.CashFlowSetup GetFirst();

        /// <summary>
        /// Gets the previous record of CashFlowSetup sorted by cashFlowSetupId. 
        /// </summary>
        /// <param name="cashFlowSetupId">The column "cash_flow_setup_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CashFlowSetup.</returns>
        MixERP.Net.Entities.Core.CashFlowSetup GetPrevious(int cashFlowSetupId);

        /// <summary>
        /// Gets the next record of CashFlowSetup sorted by cashFlowSetupId. 
        /// </summary>
        /// <param name="cashFlowSetupId">The column "cash_flow_setup_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CashFlowSetup.</returns>
        MixERP.Net.Entities.Core.CashFlowSetup GetNext(int cashFlowSetupId);

        /// <summary>
        /// Gets the last record of CashFlowSetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CashFlowSetup.</returns>
        MixERP.Net.Entities.Core.CashFlowSetup GetLast();

        /// <summary>
        /// Returns multiple instances of the CashFlowSetup against cashFlowSetupIds. 
        /// </summary>
        /// <param name="cashFlowSetupIds">Array of column "cash_flow_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of CashFlowSetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> Get(int[] cashFlowSetupIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICashFlowSetupRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for CashFlowSetup.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding CashFlowSetup.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for CashFlowSetup.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of CashFlowSetup class to ICashFlowSetupRepository.
        /// </summary>
        /// <param name="cashFlowSetup">The instance of CashFlowSetup class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic cashFlowSetup, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of CashFlowSetup class to ICashFlowSetupRepository.
        /// </summary>
        /// <param name="cashFlowSetup">The instance of CashFlowSetup class to insert.</param>
        object Add(dynamic cashFlowSetup);

        /// <summary>
        /// Inserts or updates multiple instances of CashFlowSetup class to ICashFlowSetupRepository.;
        /// </summary>
        /// <param name="cashFlowSetups">List of CashFlowSetup class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> cashFlowSetups);


        /// <summary>
        /// Updates ICashFlowSetupRepository with an instance of CashFlowSetup class against the primary key value.
        /// </summary>
        /// <param name="cashFlowSetup">The instance of CashFlowSetup class to update.</param>
        /// <param name="cashFlowSetupId">The value of the column "cash_flow_setup_id" which will be updated.</param>
        void Update(dynamic cashFlowSetup, int cashFlowSetupId);

        /// <summary>
        /// Deletes CashFlowSetup from  ICashFlowSetupRepository against the primary key value.
        /// </summary>
        /// <param name="cashFlowSetupId">The value of the column "cash_flow_setup_id" which will be deleted.</param>
        void Delete(int cashFlowSetupId);

        /// <summary>
        /// Produces a paginated result of 10 CashFlowSetup classes.
        /// </summary>
        /// <returns>Returns the first page of collection of CashFlowSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 CashFlowSetup classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of CashFlowSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICashFlowSetupRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of CashFlowSetup class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICashFlowSetupRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of CashFlowSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICashFlowSetupRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of CashFlowSetup class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICashFlowSetupRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of CashFlowSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> GetFiltered(long pageNumber, string filterName);



    }
}