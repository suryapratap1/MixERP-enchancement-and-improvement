// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IRoundingMethodRepository
    {
        /// <summary>
        /// Counts the number of RoundingMethod in IRoundingMethodRepository.
        /// </summary>
        /// <returns>Returns the count of IRoundingMethodRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of RoundingMethod. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of RoundingMethod.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> GetAll();

        /// <summary>
        /// Returns all instances of RoundingMethod to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of RoundingMethod.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the RoundingMethod against roundingMethodCode. 
        /// </summary>
        /// <param name="roundingMethodCode">The column "rounding_method_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of RoundingMethod.</returns>
        MixERP.Net.Entities.Core.RoundingMethod Get(string roundingMethodCode);

        /// <summary>
        /// Gets the first record of RoundingMethod.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of RoundingMethod.</returns>
        MixERP.Net.Entities.Core.RoundingMethod GetFirst();

        /// <summary>
        /// Gets the previous record of RoundingMethod sorted by roundingMethodCode. 
        /// </summary>
        /// <param name="roundingMethodCode">The column "rounding_method_code" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of RoundingMethod.</returns>
        MixERP.Net.Entities.Core.RoundingMethod GetPrevious(string roundingMethodCode);

        /// <summary>
        /// Gets the next record of RoundingMethod sorted by roundingMethodCode. 
        /// </summary>
        /// <param name="roundingMethodCode">The column "rounding_method_code" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of RoundingMethod.</returns>
        MixERP.Net.Entities.Core.RoundingMethod GetNext(string roundingMethodCode);

        /// <summary>
        /// Gets the last record of RoundingMethod.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of RoundingMethod.</returns>
        MixERP.Net.Entities.Core.RoundingMethod GetLast();

        /// <summary>
        /// Returns multiple instances of the RoundingMethod against roundingMethodCodes. 
        /// </summary>
        /// <param name="roundingMethodCodes">Array of column "rounding_method_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of RoundingMethod.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> Get(string[] roundingMethodCodes);

        /// <summary>
        /// Custom fields are user defined form elements for IRoundingMethodRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for RoundingMethod.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding RoundingMethod.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for RoundingMethod.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of RoundingMethod class to IRoundingMethodRepository.
        /// </summary>
        /// <param name="roundingMethod">The instance of RoundingMethod class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic roundingMethod, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of RoundingMethod class to IRoundingMethodRepository.
        /// </summary>
        /// <param name="roundingMethod">The instance of RoundingMethod class to insert.</param>
        object Add(dynamic roundingMethod);

        /// <summary>
        /// Inserts or updates multiple instances of RoundingMethod class to IRoundingMethodRepository.;
        /// </summary>
        /// <param name="roundingMethods">List of RoundingMethod class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> roundingMethods);


        /// <summary>
        /// Updates IRoundingMethodRepository with an instance of RoundingMethod class against the primary key value.
        /// </summary>
        /// <param name="roundingMethod">The instance of RoundingMethod class to update.</param>
        /// <param name="roundingMethodCode">The value of the column "rounding_method_code" which will be updated.</param>
        void Update(dynamic roundingMethod, string roundingMethodCode);

        /// <summary>
        /// Deletes RoundingMethod from  IRoundingMethodRepository against the primary key value.
        /// </summary>
        /// <param name="roundingMethodCode">The value of the column "rounding_method_code" which will be deleted.</param>
        void Delete(string roundingMethodCode);

        /// <summary>
        /// Produces a paginated result of 10 RoundingMethod classes.
        /// </summary>
        /// <returns>Returns the first page of collection of RoundingMethod class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 RoundingMethod classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of RoundingMethod class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IRoundingMethodRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of RoundingMethod class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IRoundingMethodRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of RoundingMethod class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IRoundingMethodRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of RoundingMethod class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IRoundingMethodRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of RoundingMethod class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> GetFiltered(long pageNumber, string filterName);



    }
}