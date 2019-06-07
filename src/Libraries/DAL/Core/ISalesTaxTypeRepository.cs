// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesTaxTypeRepository
    {
        /// <summary>
        /// Counts the number of SalesTaxType in ISalesTaxTypeRepository.
        /// </summary>
        /// <returns>Returns the count of ISalesTaxTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of SalesTaxType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SalesTaxType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> GetAll();

        /// <summary>
        /// Returns all instances of SalesTaxType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SalesTaxType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the SalesTaxType against salesTaxTypeId. 
        /// </summary>
        /// <param name="salesTaxTypeId">The column "sales_tax_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxType.</returns>
        MixERP.Net.Entities.Core.SalesTaxType Get(int salesTaxTypeId);

        /// <summary>
        /// Gets the first record of SalesTaxType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxType.</returns>
        MixERP.Net.Entities.Core.SalesTaxType GetFirst();

        /// <summary>
        /// Gets the previous record of SalesTaxType sorted by salesTaxTypeId. 
        /// </summary>
        /// <param name="salesTaxTypeId">The column "sales_tax_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxType.</returns>
        MixERP.Net.Entities.Core.SalesTaxType GetPrevious(int salesTaxTypeId);

        /// <summary>
        /// Gets the next record of SalesTaxType sorted by salesTaxTypeId. 
        /// </summary>
        /// <param name="salesTaxTypeId">The column "sales_tax_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxType.</returns>
        MixERP.Net.Entities.Core.SalesTaxType GetNext(int salesTaxTypeId);

        /// <summary>
        /// Gets the last record of SalesTaxType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxType.</returns>
        MixERP.Net.Entities.Core.SalesTaxType GetLast();

        /// <summary>
        /// Returns multiple instances of the SalesTaxType against salesTaxTypeIds. 
        /// </summary>
        /// <param name="salesTaxTypeIds">Array of column "sales_tax_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of SalesTaxType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> Get(int[] salesTaxTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for ISalesTaxTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for SalesTaxType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding SalesTaxType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for SalesTaxType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of SalesTaxType class to ISalesTaxTypeRepository.
        /// </summary>
        /// <param name="salesTaxType">The instance of SalesTaxType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic salesTaxType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of SalesTaxType class to ISalesTaxTypeRepository.
        /// </summary>
        /// <param name="salesTaxType">The instance of SalesTaxType class to insert.</param>
        object Add(dynamic salesTaxType);

        /// <summary>
        /// Inserts or updates multiple instances of SalesTaxType class to ISalesTaxTypeRepository.;
        /// </summary>
        /// <param name="salesTaxTypes">List of SalesTaxType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> salesTaxTypes);


        /// <summary>
        /// Updates ISalesTaxTypeRepository with an instance of SalesTaxType class against the primary key value.
        /// </summary>
        /// <param name="salesTaxType">The instance of SalesTaxType class to update.</param>
        /// <param name="salesTaxTypeId">The value of the column "sales_tax_type_id" which will be updated.</param>
        void Update(dynamic salesTaxType, int salesTaxTypeId);

        /// <summary>
        /// Deletes SalesTaxType from  ISalesTaxTypeRepository against the primary key value.
        /// </summary>
        /// <param name="salesTaxTypeId">The value of the column "sales_tax_type_id" which will be deleted.</param>
        void Delete(int salesTaxTypeId);

        /// <summary>
        /// Produces a paginated result of 10 SalesTaxType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of SalesTaxType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 SalesTaxType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of SalesTaxType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesTaxTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of SalesTaxType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ISalesTaxTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of SalesTaxType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesTaxTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of SalesTaxType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ISalesTaxTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of SalesTaxType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> GetFiltered(long pageNumber, string filterName);



    }
}