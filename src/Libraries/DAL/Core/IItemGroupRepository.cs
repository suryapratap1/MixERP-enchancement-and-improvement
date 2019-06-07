// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IItemGroupRepository
    {
        /// <summary>
        /// Counts the number of ItemGroup in IItemGroupRepository.
        /// </summary>
        /// <returns>Returns the count of IItemGroupRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ItemGroup. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ItemGroup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroup> GetAll();

        /// <summary>
        /// Returns all instances of ItemGroup to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ItemGroup.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ItemGroup against itemGroupId. 
        /// </summary>
        /// <param name="itemGroupId">The column "item_group_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemGroup.</returns>
        MixERP.Net.Entities.Core.ItemGroup Get(int itemGroupId);

        /// <summary>
        /// Gets the first record of ItemGroup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ItemGroup.</returns>
        MixERP.Net.Entities.Core.ItemGroup GetFirst();

        /// <summary>
        /// Gets the previous record of ItemGroup sorted by itemGroupId. 
        /// </summary>
        /// <param name="itemGroupId">The column "item_group_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemGroup.</returns>
        MixERP.Net.Entities.Core.ItemGroup GetPrevious(int itemGroupId);

        /// <summary>
        /// Gets the next record of ItemGroup sorted by itemGroupId. 
        /// </summary>
        /// <param name="itemGroupId">The column "item_group_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemGroup.</returns>
        MixERP.Net.Entities.Core.ItemGroup GetNext(int itemGroupId);

        /// <summary>
        /// Gets the last record of ItemGroup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ItemGroup.</returns>
        MixERP.Net.Entities.Core.ItemGroup GetLast();

        /// <summary>
        /// Returns multiple instances of the ItemGroup against itemGroupIds. 
        /// </summary>
        /// <param name="itemGroupIds">Array of column "item_group_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ItemGroup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroup> Get(int[] itemGroupIds);

        /// <summary>
        /// Custom fields are user defined form elements for IItemGroupRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ItemGroup.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ItemGroup.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ItemGroup.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ItemGroup class to IItemGroupRepository.
        /// </summary>
        /// <param name="itemGroup">The instance of ItemGroup class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic itemGroup, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ItemGroup class to IItemGroupRepository.
        /// </summary>
        /// <param name="itemGroup">The instance of ItemGroup class to insert.</param>
        object Add(dynamic itemGroup);

        /// <summary>
        /// Inserts or updates multiple instances of ItemGroup class to IItemGroupRepository.;
        /// </summary>
        /// <param name="itemGroups">List of ItemGroup class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> itemGroups);


        /// <summary>
        /// Updates IItemGroupRepository with an instance of ItemGroup class against the primary key value.
        /// </summary>
        /// <param name="itemGroup">The instance of ItemGroup class to update.</param>
        /// <param name="itemGroupId">The value of the column "item_group_id" which will be updated.</param>
        void Update(dynamic itemGroup, int itemGroupId);

        /// <summary>
        /// Deletes ItemGroup from  IItemGroupRepository against the primary key value.
        /// </summary>
        /// <param name="itemGroupId">The value of the column "item_group_id" which will be deleted.</param>
        void Delete(int itemGroupId);

        /// <summary>
        /// Produces a paginated result of 10 ItemGroup classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ItemGroup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroup> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ItemGroup classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ItemGroup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroup> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IItemGroupRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ItemGroup class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IItemGroupRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ItemGroup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroup> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IItemGroupRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ItemGroup class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IItemGroupRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ItemGroup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroup> GetFiltered(long pageNumber, string filterName);



    }
}