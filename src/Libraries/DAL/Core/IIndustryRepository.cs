// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IIndustryRepository
    {
        /// <summary>
        /// Counts the number of Industry in IIndustryRepository.
        /// </summary>
        /// <returns>Returns the count of IIndustryRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Industry. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Industry.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Industry> GetAll();

        /// <summary>
        /// Returns all instances of Industry to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Industry.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Industry against industryId. 
        /// </summary>
        /// <param name="industryId">The column "industry_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Industry.</returns>
        MixERP.Net.Entities.Core.Industry Get(int industryId);

        /// <summary>
        /// Gets the first record of Industry.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Industry.</returns>
        MixERP.Net.Entities.Core.Industry GetFirst();

        /// <summary>
        /// Gets the previous record of Industry sorted by industryId. 
        /// </summary>
        /// <param name="industryId">The column "industry_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Industry.</returns>
        MixERP.Net.Entities.Core.Industry GetPrevious(int industryId);

        /// <summary>
        /// Gets the next record of Industry sorted by industryId. 
        /// </summary>
        /// <param name="industryId">The column "industry_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Industry.</returns>
        MixERP.Net.Entities.Core.Industry GetNext(int industryId);

        /// <summary>
        /// Gets the last record of Industry.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Industry.</returns>
        MixERP.Net.Entities.Core.Industry GetLast();

        /// <summary>
        /// Returns multiple instances of the Industry against industryIds. 
        /// </summary>
        /// <param name="industryIds">Array of column "industry_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Industry.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Industry> Get(int[] industryIds);

        /// <summary>
        /// Custom fields are user defined form elements for IIndustryRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Industry.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Industry.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Industry.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Industry class to IIndustryRepository.
        /// </summary>
        /// <param name="industry">The instance of Industry class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic industry, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Industry class to IIndustryRepository.
        /// </summary>
        /// <param name="industry">The instance of Industry class to insert.</param>
        object Add(dynamic industry);

        /// <summary>
        /// Inserts or updates multiple instances of Industry class to IIndustryRepository.;
        /// </summary>
        /// <param name="industries">List of Industry class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> industries);


        /// <summary>
        /// Updates IIndustryRepository with an instance of Industry class against the primary key value.
        /// </summary>
        /// <param name="industry">The instance of Industry class to update.</param>
        /// <param name="industryId">The value of the column "industry_id" which will be updated.</param>
        void Update(dynamic industry, int industryId);

        /// <summary>
        /// Deletes Industry from  IIndustryRepository against the primary key value.
        /// </summary>
        /// <param name="industryId">The value of the column "industry_id" which will be deleted.</param>
        void Delete(int industryId);

        /// <summary>
        /// Produces a paginated result of 10 Industry classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Industry class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Industry> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Industry classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Industry class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Industry> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IIndustryRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Industry class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IIndustryRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Industry class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Industry> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IIndustryRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Industry class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IIndustryRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Industry class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Industry> GetFiltered(long pageNumber, string filterName);



    }
}