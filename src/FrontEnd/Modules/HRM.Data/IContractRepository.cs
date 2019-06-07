// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IContractRepository
    {
        /// <summary>
        /// Counts the number of Contract in IContractRepository.
        /// </summary>
        /// <returns>Returns the count of IContractRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Contract. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Contract.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Contract> GetAll();

        /// <summary>
        /// Returns all instances of Contract to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Contract.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Contract against contractId. 
        /// </summary>
        /// <param name="contractId">The column "contract_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Contract.</returns>
        MixERP.Net.Entities.HRM.Contract Get(long contractId);

        /// <summary>
        /// Gets the first record of Contract.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Contract.</returns>
        MixERP.Net.Entities.HRM.Contract GetFirst();

        /// <summary>
        /// Gets the previous record of Contract sorted by contractId. 
        /// </summary>
        /// <param name="contractId">The column "contract_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Contract.</returns>
        MixERP.Net.Entities.HRM.Contract GetPrevious(long contractId);

        /// <summary>
        /// Gets the next record of Contract sorted by contractId. 
        /// </summary>
        /// <param name="contractId">The column "contract_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Contract.</returns>
        MixERP.Net.Entities.HRM.Contract GetNext(long contractId);

        /// <summary>
        /// Gets the last record of Contract.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Contract.</returns>
        MixERP.Net.Entities.HRM.Contract GetLast();

        /// <summary>
        /// Returns multiple instances of the Contract against contractIds. 
        /// </summary>
        /// <param name="contractIds">Array of column "contract_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Contract.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Contract> Get(long[] contractIds);

        /// <summary>
        /// Custom fields are user defined form elements for IContractRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Contract.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Contract.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Contract.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Contract class to IContractRepository.
        /// </summary>
        /// <param name="contract">The instance of Contract class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic contract, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Contract class to IContractRepository.
        /// </summary>
        /// <param name="contract">The instance of Contract class to insert.</param>
        object Add(dynamic contract);

        /// <summary>
        /// Inserts or updates multiple instances of Contract class to IContractRepository.;
        /// </summary>
        /// <param name="contracts">List of Contract class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> contracts);


        /// <summary>
        /// Updates IContractRepository with an instance of Contract class against the primary key value.
        /// </summary>
        /// <param name="contract">The instance of Contract class to update.</param>
        /// <param name="contractId">The value of the column "contract_id" which will be updated.</param>
        void Update(dynamic contract, long contractId);

        /// <summary>
        /// Deletes Contract from  IContractRepository against the primary key value.
        /// </summary>
        /// <param name="contractId">The value of the column "contract_id" which will be deleted.</param>
        void Delete(long contractId);

        /// <summary>
        /// Produces a paginated result of 10 Contract classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Contract class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Contract> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Contract classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Contract class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Contract> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IContractRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Contract class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IContractRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Contract class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Contract> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IContractRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Contract class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IContractRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Contract class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Contract> GetFiltered(long pageNumber, string filterName);


        void Verify(long contractId, short verificationStatusId, string reason);

    }
}