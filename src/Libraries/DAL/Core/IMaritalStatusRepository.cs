// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IMaritalStatusRepository
    {
        /// <summary>
        /// Counts the number of MaritalStatus in IMaritalStatusRepository.
        /// </summary>
        /// <returns>Returns the count of IMaritalStatusRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of MaritalStatus. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of MaritalStatus.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MaritalStatus> GetAll();

        /// <summary>
        /// Returns all instances of MaritalStatus to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of MaritalStatus.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the MaritalStatus against maritalStatusId. 
        /// </summary>
        /// <param name="maritalStatusId">The column "marital_status_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of MaritalStatus.</returns>
        MixERP.Net.Entities.Core.MaritalStatus Get(int maritalStatusId);

        /// <summary>
        /// Gets the first record of MaritalStatus.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of MaritalStatus.</returns>
        MixERP.Net.Entities.Core.MaritalStatus GetFirst();

        /// <summary>
        /// Gets the previous record of MaritalStatus sorted by maritalStatusId. 
        /// </summary>
        /// <param name="maritalStatusId">The column "marital_status_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of MaritalStatus.</returns>
        MixERP.Net.Entities.Core.MaritalStatus GetPrevious(int maritalStatusId);

        /// <summary>
        /// Gets the next record of MaritalStatus sorted by maritalStatusId. 
        /// </summary>
        /// <param name="maritalStatusId">The column "marital_status_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of MaritalStatus.</returns>
        MixERP.Net.Entities.Core.MaritalStatus GetNext(int maritalStatusId);

        /// <summary>
        /// Gets the last record of MaritalStatus.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of MaritalStatus.</returns>
        MixERP.Net.Entities.Core.MaritalStatus GetLast();

        /// <summary>
        /// Returns multiple instances of the MaritalStatus against maritalStatusIds. 
        /// </summary>
        /// <param name="maritalStatusIds">Array of column "marital_status_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of MaritalStatus.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MaritalStatus> Get(int[] maritalStatusIds);

        /// <summary>
        /// Custom fields are user defined form elements for IMaritalStatusRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for MaritalStatus.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding MaritalStatus.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for MaritalStatus.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of MaritalStatus class to IMaritalStatusRepository.
        /// </summary>
        /// <param name="maritalStatus">The instance of MaritalStatus class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic maritalStatus, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of MaritalStatus class to IMaritalStatusRepository.
        /// </summary>
        /// <param name="maritalStatus">The instance of MaritalStatus class to insert.</param>
        object Add(dynamic maritalStatus);

        /// <summary>
        /// Inserts or updates multiple instances of MaritalStatus class to IMaritalStatusRepository.;
        /// </summary>
        /// <param name="maritalStatuses">List of MaritalStatus class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> maritalStatuses);


        /// <summary>
        /// Updates IMaritalStatusRepository with an instance of MaritalStatus class against the primary key value.
        /// </summary>
        /// <param name="maritalStatus">The instance of MaritalStatus class to update.</param>
        /// <param name="maritalStatusId">The value of the column "marital_status_id" which will be updated.</param>
        void Update(dynamic maritalStatus, int maritalStatusId);

        /// <summary>
        /// Deletes MaritalStatus from  IMaritalStatusRepository against the primary key value.
        /// </summary>
        /// <param name="maritalStatusId">The value of the column "marital_status_id" which will be deleted.</param>
        void Delete(int maritalStatusId);

        /// <summary>
        /// Produces a paginated result of 10 MaritalStatus classes.
        /// </summary>
        /// <returns>Returns the first page of collection of MaritalStatus class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MaritalStatus> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 MaritalStatus classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of MaritalStatus class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MaritalStatus> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IMaritalStatusRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of MaritalStatus class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IMaritalStatusRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of MaritalStatus class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MaritalStatus> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IMaritalStatusRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of MaritalStatus class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IMaritalStatusRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of MaritalStatus class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MaritalStatus> GetFiltered(long pageNumber, string filterName);



    }
}