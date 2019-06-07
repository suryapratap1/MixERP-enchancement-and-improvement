// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICompoundItemDetailRepository
    {
        /// <summary>
        /// Counts the number of CompoundItemDetail in ICompoundItemDetailRepository.
        /// </summary>
        /// <returns>Returns the count of ICompoundItemDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of CompoundItemDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CompoundItemDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetail> GetAll();

        /// <summary>
        /// Returns all instances of CompoundItemDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CompoundItemDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the CompoundItemDetail against compoundItemDetailId. 
        /// </summary>
        /// <param name="compoundItemDetailId">The column "compound_item_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of CompoundItemDetail.</returns>
        MixERP.Net.Entities.Core.CompoundItemDetail Get(int compoundItemDetailId);

        /// <summary>
        /// Gets the first record of CompoundItemDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CompoundItemDetail.</returns>
        MixERP.Net.Entities.Core.CompoundItemDetail GetFirst();

        /// <summary>
        /// Gets the previous record of CompoundItemDetail sorted by compoundItemDetailId. 
        /// </summary>
        /// <param name="compoundItemDetailId">The column "compound_item_detail_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CompoundItemDetail.</returns>
        MixERP.Net.Entities.Core.CompoundItemDetail GetPrevious(int compoundItemDetailId);

        /// <summary>
        /// Gets the next record of CompoundItemDetail sorted by compoundItemDetailId. 
        /// </summary>
        /// <param name="compoundItemDetailId">The column "compound_item_detail_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CompoundItemDetail.</returns>
        MixERP.Net.Entities.Core.CompoundItemDetail GetNext(int compoundItemDetailId);

        /// <summary>
        /// Gets the last record of CompoundItemDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CompoundItemDetail.</returns>
        MixERP.Net.Entities.Core.CompoundItemDetail GetLast();

        /// <summary>
        /// Returns multiple instances of the CompoundItemDetail against compoundItemDetailIds. 
        /// </summary>
        /// <param name="compoundItemDetailIds">Array of column "compound_item_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of CompoundItemDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetail> Get(int[] compoundItemDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICompoundItemDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for CompoundItemDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding CompoundItemDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for CompoundItemDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of CompoundItemDetail class to ICompoundItemDetailRepository.
        /// </summary>
        /// <param name="compoundItemDetail">The instance of CompoundItemDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic compoundItemDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of CompoundItemDetail class to ICompoundItemDetailRepository.
        /// </summary>
        /// <param name="compoundItemDetail">The instance of CompoundItemDetail class to insert.</param>
        object Add(dynamic compoundItemDetail);

        /// <summary>
        /// Inserts or updates multiple instances of CompoundItemDetail class to ICompoundItemDetailRepository.;
        /// </summary>
        /// <param name="compoundItemDetails">List of CompoundItemDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> compoundItemDetails);


        /// <summary>
        /// Updates ICompoundItemDetailRepository with an instance of CompoundItemDetail class against the primary key value.
        /// </summary>
        /// <param name="compoundItemDetail">The instance of CompoundItemDetail class to update.</param>
        /// <param name="compoundItemDetailId">The value of the column "compound_item_detail_id" which will be updated.</param>
        void Update(dynamic compoundItemDetail, int compoundItemDetailId);

        /// <summary>
        /// Deletes CompoundItemDetail from  ICompoundItemDetailRepository against the primary key value.
        /// </summary>
        /// <param name="compoundItemDetailId">The value of the column "compound_item_detail_id" which will be deleted.</param>
        void Delete(int compoundItemDetailId);

        /// <summary>
        /// Produces a paginated result of 10 CompoundItemDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of CompoundItemDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 CompoundItemDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of CompoundItemDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICompoundItemDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of CompoundItemDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICompoundItemDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of CompoundItemDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICompoundItemDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of CompoundItemDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICompoundItemDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of CompoundItemDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetail> GetFiltered(long pageNumber, string filterName);



    }
}