// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ITaxBaseAmountTypeRepository
    {
        /// <summary>
        /// Counts the number of TaxBaseAmountType in ITaxBaseAmountTypeRepository.
        /// </summary>
        /// <returns>Returns the count of ITaxBaseAmountTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of TaxBaseAmountType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of TaxBaseAmountType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> GetAll();

        /// <summary>
        /// Returns all instances of TaxBaseAmountType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of TaxBaseAmountType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the TaxBaseAmountType against taxBaseAmountTypeCode. 
        /// </summary>
        /// <param name="taxBaseAmountTypeCode">The column "tax_base_amount_type_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of TaxBaseAmountType.</returns>
        MixERP.Net.Entities.Core.TaxBaseAmountType Get(string taxBaseAmountTypeCode);

        /// <summary>
        /// Gets the first record of TaxBaseAmountType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of TaxBaseAmountType.</returns>
        MixERP.Net.Entities.Core.TaxBaseAmountType GetFirst();

        /// <summary>
        /// Gets the previous record of TaxBaseAmountType sorted by taxBaseAmountTypeCode. 
        /// </summary>
        /// <param name="taxBaseAmountTypeCode">The column "tax_base_amount_type_code" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of TaxBaseAmountType.</returns>
        MixERP.Net.Entities.Core.TaxBaseAmountType GetPrevious(string taxBaseAmountTypeCode);

        /// <summary>
        /// Gets the next record of TaxBaseAmountType sorted by taxBaseAmountTypeCode. 
        /// </summary>
        /// <param name="taxBaseAmountTypeCode">The column "tax_base_amount_type_code" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of TaxBaseAmountType.</returns>
        MixERP.Net.Entities.Core.TaxBaseAmountType GetNext(string taxBaseAmountTypeCode);

        /// <summary>
        /// Gets the last record of TaxBaseAmountType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of TaxBaseAmountType.</returns>
        MixERP.Net.Entities.Core.TaxBaseAmountType GetLast();

        /// <summary>
        /// Returns multiple instances of the TaxBaseAmountType against taxBaseAmountTypeCodes. 
        /// </summary>
        /// <param name="taxBaseAmountTypeCodes">Array of column "tax_base_amount_type_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of TaxBaseAmountType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> Get(string[] taxBaseAmountTypeCodes);

        /// <summary>
        /// Custom fields are user defined form elements for ITaxBaseAmountTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for TaxBaseAmountType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding TaxBaseAmountType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for TaxBaseAmountType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of TaxBaseAmountType class to ITaxBaseAmountTypeRepository.
        /// </summary>
        /// <param name="taxBaseAmountType">The instance of TaxBaseAmountType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic taxBaseAmountType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of TaxBaseAmountType class to ITaxBaseAmountTypeRepository.
        /// </summary>
        /// <param name="taxBaseAmountType">The instance of TaxBaseAmountType class to insert.</param>
        object Add(dynamic taxBaseAmountType);

        /// <summary>
        /// Inserts or updates multiple instances of TaxBaseAmountType class to ITaxBaseAmountTypeRepository.;
        /// </summary>
        /// <param name="taxBaseAmountTypes">List of TaxBaseAmountType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> taxBaseAmountTypes);


        /// <summary>
        /// Updates ITaxBaseAmountTypeRepository with an instance of TaxBaseAmountType class against the primary key value.
        /// </summary>
        /// <param name="taxBaseAmountType">The instance of TaxBaseAmountType class to update.</param>
        /// <param name="taxBaseAmountTypeCode">The value of the column "tax_base_amount_type_code" which will be updated.</param>
        void Update(dynamic taxBaseAmountType, string taxBaseAmountTypeCode);

        /// <summary>
        /// Deletes TaxBaseAmountType from  ITaxBaseAmountTypeRepository against the primary key value.
        /// </summary>
        /// <param name="taxBaseAmountTypeCode">The value of the column "tax_base_amount_type_code" which will be deleted.</param>
        void Delete(string taxBaseAmountTypeCode);

        /// <summary>
        /// Produces a paginated result of 10 TaxBaseAmountType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of TaxBaseAmountType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 TaxBaseAmountType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of TaxBaseAmountType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITaxBaseAmountTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of TaxBaseAmountType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ITaxBaseAmountTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of TaxBaseAmountType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITaxBaseAmountTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of TaxBaseAmountType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ITaxBaseAmountTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of TaxBaseAmountType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> GetFiltered(long pageNumber, string filterName);



    }
}