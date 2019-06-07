// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IIncomeTaxSetupRepository
    {
        /// <summary>
        /// Counts the number of IncomeTaxSetup in IIncomeTaxSetupRepository.
        /// </summary>
        /// <returns>Returns the count of IIncomeTaxSetupRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of IncomeTaxSetup. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of IncomeTaxSetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IncomeTaxSetup> GetAll();

        /// <summary>
        /// Returns all instances of IncomeTaxSetup to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of IncomeTaxSetup.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the IncomeTaxSetup against incomeTaxSetupId. 
        /// </summary>
        /// <param name="incomeTaxSetupId">The column "income_tax_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of IncomeTaxSetup.</returns>
        MixERP.Net.Entities.Core.IncomeTaxSetup Get(int incomeTaxSetupId);

        /// <summary>
        /// Gets the first record of IncomeTaxSetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of IncomeTaxSetup.</returns>
        MixERP.Net.Entities.Core.IncomeTaxSetup GetFirst();

        /// <summary>
        /// Gets the previous record of IncomeTaxSetup sorted by incomeTaxSetupId. 
        /// </summary>
        /// <param name="incomeTaxSetupId">The column "income_tax_setup_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of IncomeTaxSetup.</returns>
        MixERP.Net.Entities.Core.IncomeTaxSetup GetPrevious(int incomeTaxSetupId);

        /// <summary>
        /// Gets the next record of IncomeTaxSetup sorted by incomeTaxSetupId. 
        /// </summary>
        /// <param name="incomeTaxSetupId">The column "income_tax_setup_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of IncomeTaxSetup.</returns>
        MixERP.Net.Entities.Core.IncomeTaxSetup GetNext(int incomeTaxSetupId);

        /// <summary>
        /// Gets the last record of IncomeTaxSetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of IncomeTaxSetup.</returns>
        MixERP.Net.Entities.Core.IncomeTaxSetup GetLast();

        /// <summary>
        /// Returns multiple instances of the IncomeTaxSetup against incomeTaxSetupIds. 
        /// </summary>
        /// <param name="incomeTaxSetupIds">Array of column "income_tax_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of IncomeTaxSetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IncomeTaxSetup> Get(int[] incomeTaxSetupIds);

        /// <summary>
        /// Custom fields are user defined form elements for IIncomeTaxSetupRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for IncomeTaxSetup.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IncomeTaxSetup.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IncomeTaxSetup.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of IncomeTaxSetup class to IIncomeTaxSetupRepository.
        /// </summary>
        /// <param name="incomeTaxSetup">The instance of IncomeTaxSetup class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic incomeTaxSetup, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of IncomeTaxSetup class to IIncomeTaxSetupRepository.
        /// </summary>
        /// <param name="incomeTaxSetup">The instance of IncomeTaxSetup class to insert.</param>
        object Add(dynamic incomeTaxSetup);

        /// <summary>
        /// Inserts or updates multiple instances of IncomeTaxSetup class to IIncomeTaxSetupRepository.;
        /// </summary>
        /// <param name="incomeTaxSetups">List of IncomeTaxSetup class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> incomeTaxSetups);


        /// <summary>
        /// Updates IIncomeTaxSetupRepository with an instance of IncomeTaxSetup class against the primary key value.
        /// </summary>
        /// <param name="incomeTaxSetup">The instance of IncomeTaxSetup class to update.</param>
        /// <param name="incomeTaxSetupId">The value of the column "income_tax_setup_id" which will be updated.</param>
        void Update(dynamic incomeTaxSetup, int incomeTaxSetupId);

        /// <summary>
        /// Deletes IncomeTaxSetup from  IIncomeTaxSetupRepository against the primary key value.
        /// </summary>
        /// <param name="incomeTaxSetupId">The value of the column "income_tax_setup_id" which will be deleted.</param>
        void Delete(int incomeTaxSetupId);

        /// <summary>
        /// Produces a paginated result of 10 IncomeTaxSetup classes.
        /// </summary>
        /// <returns>Returns the first page of collection of IncomeTaxSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IncomeTaxSetup> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 IncomeTaxSetup classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of IncomeTaxSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IncomeTaxSetup> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IIncomeTaxSetupRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of IncomeTaxSetup class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IIncomeTaxSetupRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of IncomeTaxSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IncomeTaxSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IIncomeTaxSetupRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of IncomeTaxSetup class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IIncomeTaxSetupRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of IncomeTaxSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IncomeTaxSetup> GetFiltered(long pageNumber, string filterName);



    }
}