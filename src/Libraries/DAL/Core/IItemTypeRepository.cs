// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IItemTypeRepository
    {
        /// <summary>
        /// Counts the number of ItemType in IItemTypeRepository.
        /// </summary>
        /// <returns>Returns the count of IItemTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ItemType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ItemType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemType> GetAll();

        /// <summary>
        /// Returns all instances of ItemType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ItemType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ItemType against itemTypeId. 
        /// </summary>
        /// <param name="itemTypeId">The column "item_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemType.</returns>
        MixERP.Net.Entities.Core.ItemType Get(int itemTypeId);

        /// <summary>
        /// Gets the first record of ItemType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ItemType.</returns>
        MixERP.Net.Entities.Core.ItemType GetFirst();

        /// <summary>
        /// Gets the previous record of ItemType sorted by itemTypeId. 
        /// </summary>
        /// <param name="itemTypeId">The column "item_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemType.</returns>
        MixERP.Net.Entities.Core.ItemType GetPrevious(int itemTypeId);

        /// <summary>
        /// Gets the next record of ItemType sorted by itemTypeId. 
        /// </summary>
        /// <param name="itemTypeId">The column "item_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemType.</returns>
        MixERP.Net.Entities.Core.ItemType GetNext(int itemTypeId);

        /// <summary>
        /// Gets the last record of ItemType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ItemType.</returns>
        MixERP.Net.Entities.Core.ItemType GetLast();

        /// <summary>
        /// Returns multiple instances of the ItemType against itemTypeIds. 
        /// </summary>
        /// <param name="itemTypeIds">Array of column "item_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ItemType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemType> Get(int[] itemTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IItemTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ItemType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ItemType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ItemType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ItemType class to IItemTypeRepository.
        /// </summary>
        /// <param name="itemType">The instance of ItemType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic itemType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ItemType class to IItemTypeRepository.
        /// </summary>
        /// <param name="itemType">The instance of ItemType class to insert.</param>
        object Add(dynamic itemType);

        /// <summary>
        /// Inserts or updates multiple instances of ItemType class to IItemTypeRepository.;
        /// </summary>
        /// <param name="itemTypes">List of ItemType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> itemTypes);


        /// <summary>
        /// Updates IItemTypeRepository with an instance of ItemType class against the primary key value.
        /// </summary>
        /// <param name="itemType">The instance of ItemType class to update.</param>
        /// <param name="itemTypeId">The value of the column "item_type_id" which will be updated.</param>
        void Update(dynamic itemType, int itemTypeId);

        /// <summary>
        /// Deletes ItemType from  IItemTypeRepository against the primary key value.
        /// </summary>
        /// <param name="itemTypeId">The value of the column "item_type_id" which will be deleted.</param>
        void Delete(int itemTypeId);

        /// <summary>
        /// Produces a paginated result of 10 ItemType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ItemType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ItemType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ItemType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IItemTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ItemType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IItemTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ItemType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IItemTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ItemType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IItemTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ItemType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemType> GetFiltered(long pageNumber, string filterName);



    }
}