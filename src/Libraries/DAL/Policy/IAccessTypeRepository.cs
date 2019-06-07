// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IAccessTypeRepository
    {
        /// <summary>
        /// Counts the number of AccessType in IAccessTypeRepository.
        /// </summary>
        /// <returns>Returns the count of IAccessTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of AccessType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of AccessType.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AccessType> GetAll();

        /// <summary>
        /// Returns all instances of AccessType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of AccessType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the AccessType against accessTypeId. 
        /// </summary>
        /// <param name="accessTypeId">The column "access_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of AccessType.</returns>
        MixERP.Net.Entities.Policy.AccessType Get(int accessTypeId);

        /// <summary>
        /// Gets the first record of AccessType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of AccessType.</returns>
        MixERP.Net.Entities.Policy.AccessType GetFirst();

        /// <summary>
        /// Gets the previous record of AccessType sorted by accessTypeId. 
        /// </summary>
        /// <param name="accessTypeId">The column "access_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of AccessType.</returns>
        MixERP.Net.Entities.Policy.AccessType GetPrevious(int accessTypeId);

        /// <summary>
        /// Gets the next record of AccessType sorted by accessTypeId. 
        /// </summary>
        /// <param name="accessTypeId">The column "access_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of AccessType.</returns>
        MixERP.Net.Entities.Policy.AccessType GetNext(int accessTypeId);

        /// <summary>
        /// Gets the last record of AccessType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of AccessType.</returns>
        MixERP.Net.Entities.Policy.AccessType GetLast();

        /// <summary>
        /// Returns multiple instances of the AccessType against accessTypeIds. 
        /// </summary>
        /// <param name="accessTypeIds">Array of column "access_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of AccessType.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AccessType> Get(int[] accessTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IAccessTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for AccessType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding AccessType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for AccessType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of AccessType class to IAccessTypeRepository.
        /// </summary>
        /// <param name="accessType">The instance of AccessType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic accessType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of AccessType class to IAccessTypeRepository.
        /// </summary>
        /// <param name="accessType">The instance of AccessType class to insert.</param>
        object Add(dynamic accessType);

        /// <summary>
        /// Inserts or updates multiple instances of AccessType class to IAccessTypeRepository.;
        /// </summary>
        /// <param name="accessTypes">List of AccessType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> accessTypes);


        /// <summary>
        /// Updates IAccessTypeRepository with an instance of AccessType class against the primary key value.
        /// </summary>
        /// <param name="accessType">The instance of AccessType class to update.</param>
        /// <param name="accessTypeId">The value of the column "access_type_id" which will be updated.</param>
        void Update(dynamic accessType, int accessTypeId);

        /// <summary>
        /// Deletes AccessType from  IAccessTypeRepository against the primary key value.
        /// </summary>
        /// <param name="accessTypeId">The value of the column "access_type_id" which will be deleted.</param>
        void Delete(int accessTypeId);

        /// <summary>
        /// Produces a paginated result of 10 AccessType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of AccessType class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AccessType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 AccessType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of AccessType class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AccessType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAccessTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of AccessType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IAccessTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of AccessType class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AccessType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAccessTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of AccessType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IAccessTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of AccessType class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AccessType> GetFiltered(long pageNumber, string filterName);



    }
}