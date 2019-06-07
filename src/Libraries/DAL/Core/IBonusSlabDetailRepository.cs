// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IBonusSlabDetailRepository
    {
        /// <summary>
        /// Counts the number of BonusSlabDetail in IBonusSlabDetailRepository.
        /// </summary>
        /// <returns>Returns the count of IBonusSlabDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of BonusSlabDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of BonusSlabDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetail> GetAll();

        /// <summary>
        /// Returns all instances of BonusSlabDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of BonusSlabDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the BonusSlabDetail against bonusSlabDetailId. 
        /// </summary>
        /// <param name="bonusSlabDetailId">The column "bonus_slab_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of BonusSlabDetail.</returns>
        MixERP.Net.Entities.Core.BonusSlabDetail Get(int bonusSlabDetailId);

        /// <summary>
        /// Gets the first record of BonusSlabDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of BonusSlabDetail.</returns>
        MixERP.Net.Entities.Core.BonusSlabDetail GetFirst();

        /// <summary>
        /// Gets the previous record of BonusSlabDetail sorted by bonusSlabDetailId. 
        /// </summary>
        /// <param name="bonusSlabDetailId">The column "bonus_slab_detail_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of BonusSlabDetail.</returns>
        MixERP.Net.Entities.Core.BonusSlabDetail GetPrevious(int bonusSlabDetailId);

        /// <summary>
        /// Gets the next record of BonusSlabDetail sorted by bonusSlabDetailId. 
        /// </summary>
        /// <param name="bonusSlabDetailId">The column "bonus_slab_detail_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of BonusSlabDetail.</returns>
        MixERP.Net.Entities.Core.BonusSlabDetail GetNext(int bonusSlabDetailId);

        /// <summary>
        /// Gets the last record of BonusSlabDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of BonusSlabDetail.</returns>
        MixERP.Net.Entities.Core.BonusSlabDetail GetLast();

        /// <summary>
        /// Returns multiple instances of the BonusSlabDetail against bonusSlabDetailIds. 
        /// </summary>
        /// <param name="bonusSlabDetailIds">Array of column "bonus_slab_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of BonusSlabDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetail> Get(int[] bonusSlabDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for IBonusSlabDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for BonusSlabDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding BonusSlabDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for BonusSlabDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of BonusSlabDetail class to IBonusSlabDetailRepository.
        /// </summary>
        /// <param name="bonusSlabDetail">The instance of BonusSlabDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic bonusSlabDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of BonusSlabDetail class to IBonusSlabDetailRepository.
        /// </summary>
        /// <param name="bonusSlabDetail">The instance of BonusSlabDetail class to insert.</param>
        object Add(dynamic bonusSlabDetail);

        /// <summary>
        /// Inserts or updates multiple instances of BonusSlabDetail class to IBonusSlabDetailRepository.;
        /// </summary>
        /// <param name="bonusSlabDetails">List of BonusSlabDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> bonusSlabDetails);


        /// <summary>
        /// Updates IBonusSlabDetailRepository with an instance of BonusSlabDetail class against the primary key value.
        /// </summary>
        /// <param name="bonusSlabDetail">The instance of BonusSlabDetail class to update.</param>
        /// <param name="bonusSlabDetailId">The value of the column "bonus_slab_detail_id" which will be updated.</param>
        void Update(dynamic bonusSlabDetail, int bonusSlabDetailId);

        /// <summary>
        /// Deletes BonusSlabDetail from  IBonusSlabDetailRepository against the primary key value.
        /// </summary>
        /// <param name="bonusSlabDetailId">The value of the column "bonus_slab_detail_id" which will be deleted.</param>
        void Delete(int bonusSlabDetailId);

        /// <summary>
        /// Produces a paginated result of 10 BonusSlabDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of BonusSlabDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 BonusSlabDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of BonusSlabDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IBonusSlabDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of BonusSlabDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IBonusSlabDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of BonusSlabDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IBonusSlabDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of BonusSlabDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IBonusSlabDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of BonusSlabDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetail> GetFiltered(long pageNumber, string filterName);



    }
}