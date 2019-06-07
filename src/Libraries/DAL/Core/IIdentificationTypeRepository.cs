// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IIdentificationTypeRepository
    {
        /// <summary>
        /// Counts the number of IdentificationType in IIdentificationTypeRepository.
        /// </summary>
        /// <returns>Returns the count of IIdentificationTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of IdentificationType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of IdentificationType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IdentificationType> GetAll();

        /// <summary>
        /// Returns all instances of IdentificationType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of IdentificationType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the IdentificationType against identificationTypeCode. 
        /// </summary>
        /// <param name="identificationTypeCode">The column "identification_type_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of IdentificationType.</returns>
        MixERP.Net.Entities.Core.IdentificationType Get(string identificationTypeCode);

        /// <summary>
        /// Gets the first record of IdentificationType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of IdentificationType.</returns>
        MixERP.Net.Entities.Core.IdentificationType GetFirst();

        /// <summary>
        /// Gets the previous record of IdentificationType sorted by identificationTypeCode. 
        /// </summary>
        /// <param name="identificationTypeCode">The column "identification_type_code" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of IdentificationType.</returns>
        MixERP.Net.Entities.Core.IdentificationType GetPrevious(string identificationTypeCode);

        /// <summary>
        /// Gets the next record of IdentificationType sorted by identificationTypeCode. 
        /// </summary>
        /// <param name="identificationTypeCode">The column "identification_type_code" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of IdentificationType.</returns>
        MixERP.Net.Entities.Core.IdentificationType GetNext(string identificationTypeCode);

        /// <summary>
        /// Gets the last record of IdentificationType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of IdentificationType.</returns>
        MixERP.Net.Entities.Core.IdentificationType GetLast();

        /// <summary>
        /// Returns multiple instances of the IdentificationType against identificationTypeCodes. 
        /// </summary>
        /// <param name="identificationTypeCodes">Array of column "identification_type_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of IdentificationType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IdentificationType> Get(string[] identificationTypeCodes);

        /// <summary>
        /// Custom fields are user defined form elements for IIdentificationTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for IdentificationType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IdentificationType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IdentificationType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of IdentificationType class to IIdentificationTypeRepository.
        /// </summary>
        /// <param name="identificationType">The instance of IdentificationType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic identificationType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of IdentificationType class to IIdentificationTypeRepository.
        /// </summary>
        /// <param name="identificationType">The instance of IdentificationType class to insert.</param>
        object Add(dynamic identificationType);

        /// <summary>
        /// Inserts or updates multiple instances of IdentificationType class to IIdentificationTypeRepository.;
        /// </summary>
        /// <param name="identificationTypes">List of IdentificationType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> identificationTypes);


        /// <summary>
        /// Updates IIdentificationTypeRepository with an instance of IdentificationType class against the primary key value.
        /// </summary>
        /// <param name="identificationType">The instance of IdentificationType class to update.</param>
        /// <param name="identificationTypeCode">The value of the column "identification_type_code" which will be updated.</param>
        void Update(dynamic identificationType, string identificationTypeCode);

        /// <summary>
        /// Deletes IdentificationType from  IIdentificationTypeRepository against the primary key value.
        /// </summary>
        /// <param name="identificationTypeCode">The value of the column "identification_type_code" which will be deleted.</param>
        void Delete(string identificationTypeCode);

        /// <summary>
        /// Produces a paginated result of 10 IdentificationType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of IdentificationType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IdentificationType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 IdentificationType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of IdentificationType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IdentificationType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IIdentificationTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of IdentificationType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IIdentificationTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of IdentificationType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IdentificationType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IIdentificationTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of IdentificationType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IIdentificationTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of IdentificationType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IdentificationType> GetFiltered(long pageNumber, string filterName);



    }
}