// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IRoleRepository
    {
        /// <summary>
        /// Counts the number of Role in IRoleRepository.
        /// </summary>
        /// <returns>Returns the count of IRoleRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Role. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Role.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Role> GetAll();

        /// <summary>
        /// Returns all instances of Role to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Role.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Role against roleId. 
        /// </summary>
        /// <param name="roleId">The column "role_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Role.</returns>
        MixERP.Net.Entities.Office.Role Get(int roleId);

        /// <summary>
        /// Gets the first record of Role.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Role.</returns>
        MixERP.Net.Entities.Office.Role GetFirst();

        /// <summary>
        /// Gets the previous record of Role sorted by roleId. 
        /// </summary>
        /// <param name="roleId">The column "role_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Role.</returns>
        MixERP.Net.Entities.Office.Role GetPrevious(int roleId);

        /// <summary>
        /// Gets the next record of Role sorted by roleId. 
        /// </summary>
        /// <param name="roleId">The column "role_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Role.</returns>
        MixERP.Net.Entities.Office.Role GetNext(int roleId);

        /// <summary>
        /// Gets the last record of Role.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Role.</returns>
        MixERP.Net.Entities.Office.Role GetLast();

        /// <summary>
        /// Returns multiple instances of the Role against roleIds. 
        /// </summary>
        /// <param name="roleIds">Array of column "role_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Role.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Role> Get(int[] roleIds);

        /// <summary>
        /// Custom fields are user defined form elements for IRoleRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Role.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Role.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Role.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Role class to IRoleRepository.
        /// </summary>
        /// <param name="role">The instance of Role class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic role, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Role class to IRoleRepository.
        /// </summary>
        /// <param name="role">The instance of Role class to insert.</param>
        object Add(dynamic role);

        /// <summary>
        /// Inserts or updates multiple instances of Role class to IRoleRepository.;
        /// </summary>
        /// <param name="roles">List of Role class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> roles);


        /// <summary>
        /// Updates IRoleRepository with an instance of Role class against the primary key value.
        /// </summary>
        /// <param name="role">The instance of Role class to update.</param>
        /// <param name="roleId">The value of the column "role_id" which will be updated.</param>
        void Update(dynamic role, int roleId);

        /// <summary>
        /// Deletes Role from  IRoleRepository against the primary key value.
        /// </summary>
        /// <param name="roleId">The value of the column "role_id" which will be deleted.</param>
        void Delete(int roleId);

        /// <summary>
        /// Produces a paginated result of 10 Role classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Role class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Role> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Role classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Role class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Role> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IRoleRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Role class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IRoleRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Role class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Role> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IRoleRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Role class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IRoleRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Role class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Role> GetFiltered(long pageNumber, string filterName);



    }
}