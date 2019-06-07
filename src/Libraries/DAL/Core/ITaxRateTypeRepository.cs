// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ITaxRateTypeRepository
    {
        /// <summary>
        /// Counts the number of TaxRateType in ITaxRateTypeRepository.
        /// </summary>
        /// <returns>Returns the count of ITaxRateTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of TaxRateType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of TaxRateType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxRateType> GetAll();

        /// <summary>
        /// Returns all instances of TaxRateType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of TaxRateType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the TaxRateType against taxRateTypeCode. 
        /// </summary>
        /// <param name="taxRateTypeCode">The column "tax_rate_type_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of TaxRateType.</returns>
        MixERP.Net.Entities.Core.TaxRateType Get(string taxRateTypeCode);

        /// <summary>
        /// Gets the first record of TaxRateType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of TaxRateType.</returns>
        MixERP.Net.Entities.Core.TaxRateType GetFirst();

        /// <summary>
        /// Gets the previous record of TaxRateType sorted by taxRateTypeCode. 
        /// </summary>
        /// <param name="taxRateTypeCode">The column "tax_rate_type_code" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of TaxRateType.</returns>
        MixERP.Net.Entities.Core.TaxRateType GetPrevious(string taxRateTypeCode);

        /// <summary>
        /// Gets the next record of TaxRateType sorted by taxRateTypeCode. 
        /// </summary>
        /// <param name="taxRateTypeCode">The column "tax_rate_type_code" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of TaxRateType.</returns>
        MixERP.Net.Entities.Core.TaxRateType GetNext(string taxRateTypeCode);

        /// <summary>
        /// Gets the last record of TaxRateType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of TaxRateType.</returns>
        MixERP.Net.Entities.Core.TaxRateType GetLast();

        /// <summary>
        /// Returns multiple instances of the TaxRateType against taxRateTypeCodes. 
        /// </summary>
        /// <param name="taxRateTypeCodes">Array of column "tax_rate_type_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of TaxRateType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxRateType> Get(string[] taxRateTypeCodes);

        /// <summary>
        /// Custom fields are user defined form elements for ITaxRateTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for TaxRateType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding TaxRateType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for TaxRateType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of TaxRateType class to ITaxRateTypeRepository.
        /// </summary>
        /// <param name="taxRateType">The instance of TaxRateType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic taxRateType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of TaxRateType class to ITaxRateTypeRepository.
        /// </summary>
        /// <param name="taxRateType">The instance of TaxRateType class to insert.</param>
        object Add(dynamic taxRateType);

        /// <summary>
        /// Inserts or updates multiple instances of TaxRateType class to ITaxRateTypeRepository.;
        /// </summary>
        /// <param name="taxRateTypes">List of TaxRateType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> taxRateTypes);


        /// <summary>
        /// Updates ITaxRateTypeRepository with an instance of TaxRateType class against the primary key value.
        /// </summary>
        /// <param name="taxRateType">The instance of TaxRateType class to update.</param>
        /// <param name="taxRateTypeCode">The value of the column "tax_rate_type_code" which will be updated.</param>
        void Update(dynamic taxRateType, string taxRateTypeCode);

        /// <summary>
        /// Deletes TaxRateType from  ITaxRateTypeRepository against the primary key value.
        /// </summary>
        /// <param name="taxRateTypeCode">The value of the column "tax_rate_type_code" which will be deleted.</param>
        void Delete(string taxRateTypeCode);

        /// <summary>
        /// Produces a paginated result of 10 TaxRateType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of TaxRateType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxRateType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 TaxRateType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of TaxRateType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxRateType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITaxRateTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of TaxRateType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ITaxRateTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of TaxRateType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxRateType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITaxRateTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of TaxRateType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ITaxRateTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of TaxRateType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxRateType> GetFiltered(long pageNumber, string filterName);



    }
}