// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ITaxExemptTypeRepository
    {
        /// <summary>
        /// Counts the number of TaxExemptType in ITaxExemptTypeRepository.
        /// </summary>
        /// <returns>Returns the count of ITaxExemptTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of TaxExemptType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of TaxExemptType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> GetAll();

        /// <summary>
        /// Returns all instances of TaxExemptType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of TaxExemptType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the TaxExemptType against taxExemptTypeId. 
        /// </summary>
        /// <param name="taxExemptTypeId">The column "tax_exempt_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of TaxExemptType.</returns>
        MixERP.Net.Entities.Core.TaxExemptType Get(int taxExemptTypeId);

        /// <summary>
        /// Gets the first record of TaxExemptType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of TaxExemptType.</returns>
        MixERP.Net.Entities.Core.TaxExemptType GetFirst();

        /// <summary>
        /// Gets the previous record of TaxExemptType sorted by taxExemptTypeId. 
        /// </summary>
        /// <param name="taxExemptTypeId">The column "tax_exempt_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of TaxExemptType.</returns>
        MixERP.Net.Entities.Core.TaxExemptType GetPrevious(int taxExemptTypeId);

        /// <summary>
        /// Gets the next record of TaxExemptType sorted by taxExemptTypeId. 
        /// </summary>
        /// <param name="taxExemptTypeId">The column "tax_exempt_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of TaxExemptType.</returns>
        MixERP.Net.Entities.Core.TaxExemptType GetNext(int taxExemptTypeId);

        /// <summary>
        /// Gets the last record of TaxExemptType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of TaxExemptType.</returns>
        MixERP.Net.Entities.Core.TaxExemptType GetLast();

        /// <summary>
        /// Returns multiple instances of the TaxExemptType against taxExemptTypeIds. 
        /// </summary>
        /// <param name="taxExemptTypeIds">Array of column "tax_exempt_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of TaxExemptType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> Get(int[] taxExemptTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for ITaxExemptTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for TaxExemptType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding TaxExemptType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for TaxExemptType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of TaxExemptType class to ITaxExemptTypeRepository.
        /// </summary>
        /// <param name="taxExemptType">The instance of TaxExemptType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic taxExemptType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of TaxExemptType class to ITaxExemptTypeRepository.
        /// </summary>
        /// <param name="taxExemptType">The instance of TaxExemptType class to insert.</param>
        object Add(dynamic taxExemptType);

        /// <summary>
        /// Inserts or updates multiple instances of TaxExemptType class to ITaxExemptTypeRepository.;
        /// </summary>
        /// <param name="taxExemptTypes">List of TaxExemptType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> taxExemptTypes);


        /// <summary>
        /// Updates ITaxExemptTypeRepository with an instance of TaxExemptType class against the primary key value.
        /// </summary>
        /// <param name="taxExemptType">The instance of TaxExemptType class to update.</param>
        /// <param name="taxExemptTypeId">The value of the column "tax_exempt_type_id" which will be updated.</param>
        void Update(dynamic taxExemptType, int taxExemptTypeId);

        /// <summary>
        /// Deletes TaxExemptType from  ITaxExemptTypeRepository against the primary key value.
        /// </summary>
        /// <param name="taxExemptTypeId">The value of the column "tax_exempt_type_id" which will be deleted.</param>
        void Delete(int taxExemptTypeId);

        /// <summary>
        /// Produces a paginated result of 10 TaxExemptType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of TaxExemptType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 TaxExemptType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of TaxExemptType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITaxExemptTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of TaxExemptType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ITaxExemptTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of TaxExemptType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITaxExemptTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of TaxExemptType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ITaxExemptTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of TaxExemptType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> GetFiltered(long pageNumber, string filterName);



    }
}