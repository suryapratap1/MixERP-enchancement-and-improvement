// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface ICashierRepository
    {
        /// <summary>
        /// Counts the number of Cashier in ICashierRepository.
        /// </summary>
        /// <returns>Returns the count of ICashierRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Cashier. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Cashier.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Cashier> GetAll();

        /// <summary>
        /// Returns all instances of Cashier to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Cashier.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Cashier against cashierId. 
        /// </summary>
        /// <param name="cashierId">The column "cashier_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Cashier.</returns>
        MixERP.Net.Entities.Office.Cashier Get(long cashierId);

        /// <summary>
        /// Gets the first record of Cashier.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Cashier.</returns>
        MixERP.Net.Entities.Office.Cashier GetFirst();

        /// <summary>
        /// Gets the previous record of Cashier sorted by cashierId. 
        /// </summary>
        /// <param name="cashierId">The column "cashier_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Cashier.</returns>
        MixERP.Net.Entities.Office.Cashier GetPrevious(long cashierId);

        /// <summary>
        /// Gets the next record of Cashier sorted by cashierId. 
        /// </summary>
        /// <param name="cashierId">The column "cashier_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Cashier.</returns>
        MixERP.Net.Entities.Office.Cashier GetNext(long cashierId);

        /// <summary>
        /// Gets the last record of Cashier.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Cashier.</returns>
        MixERP.Net.Entities.Office.Cashier GetLast();

        /// <summary>
        /// Returns multiple instances of the Cashier against cashierIds. 
        /// </summary>
        /// <param name="cashierIds">Array of column "cashier_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Cashier.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Cashier> Get(long[] cashierIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICashierRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Cashier.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Cashier.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Cashier.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Cashier class to ICashierRepository.
        /// </summary>
        /// <param name="cashier">The instance of Cashier class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic cashier, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Cashier class to ICashierRepository.
        /// </summary>
        /// <param name="cashier">The instance of Cashier class to insert.</param>
        object Add(dynamic cashier);

        /// <summary>
        /// Inserts or updates multiple instances of Cashier class to ICashierRepository.;
        /// </summary>
        /// <param name="cashiers">List of Cashier class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> cashiers);


        /// <summary>
        /// Updates ICashierRepository with an instance of Cashier class against the primary key value.
        /// </summary>
        /// <param name="cashier">The instance of Cashier class to update.</param>
        /// <param name="cashierId">The value of the column "cashier_id" which will be updated.</param>
        void Update(dynamic cashier, long cashierId);

        /// <summary>
        /// Deletes Cashier from  ICashierRepository against the primary key value.
        /// </summary>
        /// <param name="cashierId">The value of the column "cashier_id" which will be deleted.</param>
        void Delete(long cashierId);

        /// <summary>
        /// Produces a paginated result of 10 Cashier classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Cashier class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Cashier> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Cashier classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Cashier class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Cashier> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICashierRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Cashier class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICashierRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Cashier class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Cashier> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICashierRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Cashier class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICashierRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Cashier class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Cashier> GetFiltered(long pageNumber, string filterName);



    }
}