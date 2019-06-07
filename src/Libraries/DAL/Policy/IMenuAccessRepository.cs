// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IMenuAccessRepository
    {
        /// <summary>
        /// Counts the number of MenuAccess in IMenuAccessRepository.
        /// </summary>
        /// <returns>Returns the count of IMenuAccessRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of MenuAccess. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of MenuAccess.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> GetAll();

        /// <summary>
        /// Returns all instances of MenuAccess to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of MenuAccess.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the MenuAccess against accessId. 
        /// </summary>
        /// <param name="accessId">The column "access_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of MenuAccess.</returns>
        MixERP.Net.Entities.Policy.MenuAccess Get(long accessId);

        /// <summary>
        /// Gets the first record of MenuAccess.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of MenuAccess.</returns>
        MixERP.Net.Entities.Policy.MenuAccess GetFirst();

        /// <summary>
        /// Gets the previous record of MenuAccess sorted by accessId. 
        /// </summary>
        /// <param name="accessId">The column "access_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of MenuAccess.</returns>
        MixERP.Net.Entities.Policy.MenuAccess GetPrevious(long accessId);

        /// <summary>
        /// Gets the next record of MenuAccess sorted by accessId. 
        /// </summary>
        /// <param name="accessId">The column "access_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of MenuAccess.</returns>
        MixERP.Net.Entities.Policy.MenuAccess GetNext(long accessId);

        /// <summary>
        /// Gets the last record of MenuAccess.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of MenuAccess.</returns>
        MixERP.Net.Entities.Policy.MenuAccess GetLast();

        /// <summary>
        /// Returns multiple instances of the MenuAccess against accessIds. 
        /// </summary>
        /// <param name="accessIds">Array of column "access_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of MenuAccess.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> Get(long[] accessIds);

        /// <summary>
        /// Custom fields are user defined form elements for IMenuAccessRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for MenuAccess.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding MenuAccess.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for MenuAccess.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of MenuAccess class to IMenuAccessRepository.
        /// </summary>
        /// <param name="menuAccess">The instance of MenuAccess class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic menuAccess, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of MenuAccess class to IMenuAccessRepository.
        /// </summary>
        /// <param name="menuAccess">The instance of MenuAccess class to insert.</param>
        object Add(dynamic menuAccess);

        /// <summary>
        /// Inserts or updates multiple instances of MenuAccess class to IMenuAccessRepository.;
        /// </summary>
        /// <param name="menuAccesses">List of MenuAccess class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> menuAccesses);


        /// <summary>
        /// Updates IMenuAccessRepository with an instance of MenuAccess class against the primary key value.
        /// </summary>
        /// <param name="menuAccess">The instance of MenuAccess class to update.</param>
        /// <param name="accessId">The value of the column "access_id" which will be updated.</param>
        void Update(dynamic menuAccess, long accessId);

        /// <summary>
        /// Deletes MenuAccess from  IMenuAccessRepository against the primary key value.
        /// </summary>
        /// <param name="accessId">The value of the column "access_id" which will be deleted.</param>
        void Delete(long accessId);

        /// <summary>
        /// Produces a paginated result of 10 MenuAccess classes.
        /// </summary>
        /// <returns>Returns the first page of collection of MenuAccess class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 MenuAccess classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of MenuAccess class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IMenuAccessRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of MenuAccess class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IMenuAccessRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of MenuAccess class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IMenuAccessRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of MenuAccess class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IMenuAccessRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of MenuAccess class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> GetFiltered(long pageNumber, string filterName);



    }
}