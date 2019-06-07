// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IBonusSlabRepository
    {
        /// <summary>
        /// Counts the number of BonusSlab in IBonusSlabRepository.
        /// </summary>
        /// <returns>Returns the count of IBonusSlabRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of BonusSlab. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of BonusSlab.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlab> GetAll();

        /// <summary>
        /// Returns all instances of BonusSlab to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of BonusSlab.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the BonusSlab against bonusSlabId. 
        /// </summary>
        /// <param name="bonusSlabId">The column "bonus_slab_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of BonusSlab.</returns>
        MixERP.Net.Entities.Core.BonusSlab Get(int bonusSlabId);

        /// <summary>
        /// Gets the first record of BonusSlab.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of BonusSlab.</returns>
        MixERP.Net.Entities.Core.BonusSlab GetFirst();

        /// <summary>
        /// Gets the previous record of BonusSlab sorted by bonusSlabId. 
        /// </summary>
        /// <param name="bonusSlabId">The column "bonus_slab_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of BonusSlab.</returns>
        MixERP.Net.Entities.Core.BonusSlab GetPrevious(int bonusSlabId);

        /// <summary>
        /// Gets the next record of BonusSlab sorted by bonusSlabId. 
        /// </summary>
        /// <param name="bonusSlabId">The column "bonus_slab_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of BonusSlab.</returns>
        MixERP.Net.Entities.Core.BonusSlab GetNext(int bonusSlabId);

        /// <summary>
        /// Gets the last record of BonusSlab.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of BonusSlab.</returns>
        MixERP.Net.Entities.Core.BonusSlab GetLast();

        /// <summary>
        /// Returns multiple instances of the BonusSlab against bonusSlabIds. 
        /// </summary>
        /// <param name="bonusSlabIds">Array of column "bonus_slab_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of BonusSlab.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlab> Get(int[] bonusSlabIds);

        /// <summary>
        /// Custom fields are user defined form elements for IBonusSlabRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for BonusSlab.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding BonusSlab.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for BonusSlab.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of BonusSlab class to IBonusSlabRepository.
        /// </summary>
        /// <param name="bonusSlab">The instance of BonusSlab class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic bonusSlab, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of BonusSlab class to IBonusSlabRepository.
        /// </summary>
        /// <param name="bonusSlab">The instance of BonusSlab class to insert.</param>
        object Add(dynamic bonusSlab);

        /// <summary>
        /// Inserts or updates multiple instances of BonusSlab class to IBonusSlabRepository.;
        /// </summary>
        /// <param name="bonusSlabs">List of BonusSlab class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> bonusSlabs);


        /// <summary>
        /// Updates IBonusSlabRepository with an instance of BonusSlab class against the primary key value.
        /// </summary>
        /// <param name="bonusSlab">The instance of BonusSlab class to update.</param>
        /// <param name="bonusSlabId">The value of the column "bonus_slab_id" which will be updated.</param>
        void Update(dynamic bonusSlab, int bonusSlabId);

        /// <summary>
        /// Deletes BonusSlab from  IBonusSlabRepository against the primary key value.
        /// </summary>
        /// <param name="bonusSlabId">The value of the column "bonus_slab_id" which will be deleted.</param>
        void Delete(int bonusSlabId);

        /// <summary>
        /// Produces a paginated result of 10 BonusSlab classes.
        /// </summary>
        /// <returns>Returns the first page of collection of BonusSlab class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlab> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 BonusSlab classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of BonusSlab class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlab> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IBonusSlabRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of BonusSlab class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IBonusSlabRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of BonusSlab class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlab> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IBonusSlabRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of BonusSlab class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IBonusSlabRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of BonusSlab class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlab> GetFiltered(long pageNumber, string filterName);



    }
}