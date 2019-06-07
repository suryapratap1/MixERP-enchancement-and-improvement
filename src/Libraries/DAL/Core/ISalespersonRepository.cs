// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalespersonRepository
    {
        /// <summary>
        /// Counts the number of Salesperson in ISalespersonRepository.
        /// </summary>
        /// <returns>Returns the count of ISalespersonRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Salesperson. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Salesperson.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Salesperson> GetAll();

        /// <summary>
        /// Returns all instances of Salesperson to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Salesperson.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Salesperson against salespersonId. 
        /// </summary>
        /// <param name="salespersonId">The column "salesperson_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Salesperson.</returns>
        MixERP.Net.Entities.Core.Salesperson Get(int salespersonId);

        /// <summary>
        /// Gets the first record of Salesperson.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Salesperson.</returns>
        MixERP.Net.Entities.Core.Salesperson GetFirst();

        /// <summary>
        /// Gets the previous record of Salesperson sorted by salespersonId. 
        /// </summary>
        /// <param name="salespersonId">The column "salesperson_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Salesperson.</returns>
        MixERP.Net.Entities.Core.Salesperson GetPrevious(int salespersonId);

        /// <summary>
        /// Gets the next record of Salesperson sorted by salespersonId. 
        /// </summary>
        /// <param name="salespersonId">The column "salesperson_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Salesperson.</returns>
        MixERP.Net.Entities.Core.Salesperson GetNext(int salespersonId);

        /// <summary>
        /// Gets the last record of Salesperson.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Salesperson.</returns>
        MixERP.Net.Entities.Core.Salesperson GetLast();

        /// <summary>
        /// Returns multiple instances of the Salesperson against salespersonIds. 
        /// </summary>
        /// <param name="salespersonIds">Array of column "salesperson_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Salesperson.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Salesperson> Get(int[] salespersonIds);

        /// <summary>
        /// Custom fields are user defined form elements for ISalespersonRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Salesperson.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Salesperson.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Salesperson.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Salesperson class to ISalespersonRepository.
        /// </summary>
        /// <param name="salesperson">The instance of Salesperson class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic salesperson, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Salesperson class to ISalespersonRepository.
        /// </summary>
        /// <param name="salesperson">The instance of Salesperson class to insert.</param>
        object Add(dynamic salesperson);

        /// <summary>
        /// Inserts or updates multiple instances of Salesperson class to ISalespersonRepository.;
        /// </summary>
        /// <param name="salespeople">List of Salesperson class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> salespeople);


        /// <summary>
        /// Updates ISalespersonRepository with an instance of Salesperson class against the primary key value.
        /// </summary>
        /// <param name="salesperson">The instance of Salesperson class to update.</param>
        /// <param name="salespersonId">The value of the column "salesperson_id" which will be updated.</param>
        void Update(dynamic salesperson, int salespersonId);

        /// <summary>
        /// Deletes Salesperson from  ISalespersonRepository against the primary key value.
        /// </summary>
        /// <param name="salespersonId">The value of the column "salesperson_id" which will be deleted.</param>
        void Delete(int salespersonId);

        /// <summary>
        /// Produces a paginated result of 10 Salesperson classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Salesperson class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Salesperson> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Salesperson classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Salesperson class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Salesperson> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalespersonRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Salesperson class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ISalespersonRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Salesperson class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Salesperson> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalespersonRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Salesperson class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ISalespersonRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Salesperson class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Salesperson> GetFiltered(long pageNumber, string filterName);



    }
}