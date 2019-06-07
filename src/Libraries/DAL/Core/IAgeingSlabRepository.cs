// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IAgeingSlabRepository
    {
        /// <summary>
        /// Counts the number of AgeingSlab in IAgeingSlabRepository.
        /// </summary>
        /// <returns>Returns the count of IAgeingSlabRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of AgeingSlab. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of AgeingSlab.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> GetAll();

        /// <summary>
        /// Returns all instances of AgeingSlab to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of AgeingSlab.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the AgeingSlab against ageingSlabId. 
        /// </summary>
        /// <param name="ageingSlabId">The column "ageing_slab_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of AgeingSlab.</returns>
        MixERP.Net.Entities.Core.AgeingSlab Get(int ageingSlabId);

        /// <summary>
        /// Gets the first record of AgeingSlab.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of AgeingSlab.</returns>
        MixERP.Net.Entities.Core.AgeingSlab GetFirst();

        /// <summary>
        /// Gets the previous record of AgeingSlab sorted by ageingSlabId. 
        /// </summary>
        /// <param name="ageingSlabId">The column "ageing_slab_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of AgeingSlab.</returns>
        MixERP.Net.Entities.Core.AgeingSlab GetPrevious(int ageingSlabId);

        /// <summary>
        /// Gets the next record of AgeingSlab sorted by ageingSlabId. 
        /// </summary>
        /// <param name="ageingSlabId">The column "ageing_slab_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of AgeingSlab.</returns>
        MixERP.Net.Entities.Core.AgeingSlab GetNext(int ageingSlabId);

        /// <summary>
        /// Gets the last record of AgeingSlab.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of AgeingSlab.</returns>
        MixERP.Net.Entities.Core.AgeingSlab GetLast();

        /// <summary>
        /// Returns multiple instances of the AgeingSlab against ageingSlabIds. 
        /// </summary>
        /// <param name="ageingSlabIds">Array of column "ageing_slab_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of AgeingSlab.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> Get(int[] ageingSlabIds);

        /// <summary>
        /// Custom fields are user defined form elements for IAgeingSlabRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for AgeingSlab.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding AgeingSlab.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for AgeingSlab.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of AgeingSlab class to IAgeingSlabRepository.
        /// </summary>
        /// <param name="ageingSlab">The instance of AgeingSlab class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic ageingSlab, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of AgeingSlab class to IAgeingSlabRepository.
        /// </summary>
        /// <param name="ageingSlab">The instance of AgeingSlab class to insert.</param>
        object Add(dynamic ageingSlab);

        /// <summary>
        /// Inserts or updates multiple instances of AgeingSlab class to IAgeingSlabRepository.;
        /// </summary>
        /// <param name="ageingSlabs">List of AgeingSlab class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> ageingSlabs);


        /// <summary>
        /// Updates IAgeingSlabRepository with an instance of AgeingSlab class against the primary key value.
        /// </summary>
        /// <param name="ageingSlab">The instance of AgeingSlab class to update.</param>
        /// <param name="ageingSlabId">The value of the column "ageing_slab_id" which will be updated.</param>
        void Update(dynamic ageingSlab, int ageingSlabId);

        /// <summary>
        /// Deletes AgeingSlab from  IAgeingSlabRepository against the primary key value.
        /// </summary>
        /// <param name="ageingSlabId">The value of the column "ageing_slab_id" which will be deleted.</param>
        void Delete(int ageingSlabId);

        /// <summary>
        /// Produces a paginated result of 10 AgeingSlab classes.
        /// </summary>
        /// <returns>Returns the first page of collection of AgeingSlab class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 AgeingSlab classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of AgeingSlab class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAgeingSlabRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of AgeingSlab class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IAgeingSlabRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of AgeingSlab class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAgeingSlabRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of AgeingSlab class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IAgeingSlabRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of AgeingSlab class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> GetFiltered(long pageNumber, string filterName);



    }
}