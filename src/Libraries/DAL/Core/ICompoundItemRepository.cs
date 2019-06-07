// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICompoundItemRepository
    {
        /// <summary>
        /// Counts the number of CompoundItem in ICompoundItemRepository.
        /// </summary>
        /// <returns>Returns the count of ICompoundItemRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of CompoundItem. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CompoundItem.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItem> GetAll();

        /// <summary>
        /// Returns all instances of CompoundItem to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CompoundItem.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the CompoundItem against compoundItemId. 
        /// </summary>
        /// <param name="compoundItemId">The column "compound_item_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of CompoundItem.</returns>
        MixERP.Net.Entities.Core.CompoundItem Get(int compoundItemId);

        /// <summary>
        /// Gets the first record of CompoundItem.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CompoundItem.</returns>
        MixERP.Net.Entities.Core.CompoundItem GetFirst();

        /// <summary>
        /// Gets the previous record of CompoundItem sorted by compoundItemId. 
        /// </summary>
        /// <param name="compoundItemId">The column "compound_item_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CompoundItem.</returns>
        MixERP.Net.Entities.Core.CompoundItem GetPrevious(int compoundItemId);

        /// <summary>
        /// Gets the next record of CompoundItem sorted by compoundItemId. 
        /// </summary>
        /// <param name="compoundItemId">The column "compound_item_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CompoundItem.</returns>
        MixERP.Net.Entities.Core.CompoundItem GetNext(int compoundItemId);

        /// <summary>
        /// Gets the last record of CompoundItem.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CompoundItem.</returns>
        MixERP.Net.Entities.Core.CompoundItem GetLast();

        /// <summary>
        /// Returns multiple instances of the CompoundItem against compoundItemIds. 
        /// </summary>
        /// <param name="compoundItemIds">Array of column "compound_item_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of CompoundItem.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItem> Get(int[] compoundItemIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICompoundItemRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for CompoundItem.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding CompoundItem.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for CompoundItem.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of CompoundItem class to ICompoundItemRepository.
        /// </summary>
        /// <param name="compoundItem">The instance of CompoundItem class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic compoundItem, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of CompoundItem class to ICompoundItemRepository.
        /// </summary>
        /// <param name="compoundItem">The instance of CompoundItem class to insert.</param>
        object Add(dynamic compoundItem);

        /// <summary>
        /// Inserts or updates multiple instances of CompoundItem class to ICompoundItemRepository.;
        /// </summary>
        /// <param name="compoundItems">List of CompoundItem class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> compoundItems);


        /// <summary>
        /// Updates ICompoundItemRepository with an instance of CompoundItem class against the primary key value.
        /// </summary>
        /// <param name="compoundItem">The instance of CompoundItem class to update.</param>
        /// <param name="compoundItemId">The value of the column "compound_item_id" which will be updated.</param>
        void Update(dynamic compoundItem, int compoundItemId);

        /// <summary>
        /// Deletes CompoundItem from  ICompoundItemRepository against the primary key value.
        /// </summary>
        /// <param name="compoundItemId">The value of the column "compound_item_id" which will be deleted.</param>
        void Delete(int compoundItemId);

        /// <summary>
        /// Produces a paginated result of 10 CompoundItem classes.
        /// </summary>
        /// <returns>Returns the first page of collection of CompoundItem class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItem> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 CompoundItem classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of CompoundItem class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItem> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICompoundItemRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of CompoundItem class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICompoundItemRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of CompoundItem class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItem> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICompoundItemRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of CompoundItem class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICompoundItemRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of CompoundItem class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItem> GetFiltered(long pageNumber, string filterName);



    }
}