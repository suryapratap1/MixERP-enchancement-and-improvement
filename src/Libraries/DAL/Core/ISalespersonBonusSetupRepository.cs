// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalespersonBonusSetupRepository
    {
        /// <summary>
        /// Counts the number of SalespersonBonusSetup in ISalespersonBonusSetupRepository.
        /// </summary>
        /// <returns>Returns the count of ISalespersonBonusSetupRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of SalespersonBonusSetup. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SalespersonBonusSetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetAll();

        /// <summary>
        /// Returns all instances of SalespersonBonusSetup to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SalespersonBonusSetup.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the SalespersonBonusSetup against salespersonBonusSetupId. 
        /// </summary>
        /// <param name="salespersonBonusSetupId">The column "salesperson_bonus_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalespersonBonusSetup.</returns>
        MixERP.Net.Entities.Core.SalespersonBonusSetup Get(int salespersonBonusSetupId);

        /// <summary>
        /// Gets the first record of SalespersonBonusSetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SalespersonBonusSetup.</returns>
        MixERP.Net.Entities.Core.SalespersonBonusSetup GetFirst();

        /// <summary>
        /// Gets the previous record of SalespersonBonusSetup sorted by salespersonBonusSetupId. 
        /// </summary>
        /// <param name="salespersonBonusSetupId">The column "salesperson_bonus_setup_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalespersonBonusSetup.</returns>
        MixERP.Net.Entities.Core.SalespersonBonusSetup GetPrevious(int salespersonBonusSetupId);

        /// <summary>
        /// Gets the next record of SalespersonBonusSetup sorted by salespersonBonusSetupId. 
        /// </summary>
        /// <param name="salespersonBonusSetupId">The column "salesperson_bonus_setup_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalespersonBonusSetup.</returns>
        MixERP.Net.Entities.Core.SalespersonBonusSetup GetNext(int salespersonBonusSetupId);

        /// <summary>
        /// Gets the last record of SalespersonBonusSetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SalespersonBonusSetup.</returns>
        MixERP.Net.Entities.Core.SalespersonBonusSetup GetLast();

        /// <summary>
        /// Returns multiple instances of the SalespersonBonusSetup against salespersonBonusSetupIds. 
        /// </summary>
        /// <param name="salespersonBonusSetupIds">Array of column "salesperson_bonus_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of SalespersonBonusSetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> Get(int[] salespersonBonusSetupIds);

        /// <summary>
        /// Custom fields are user defined form elements for ISalespersonBonusSetupRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for SalespersonBonusSetup.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding SalespersonBonusSetup.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for SalespersonBonusSetup.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of SalespersonBonusSetup class to ISalespersonBonusSetupRepository.
        /// </summary>
        /// <param name="salespersonBonusSetup">The instance of SalespersonBonusSetup class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic salespersonBonusSetup, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of SalespersonBonusSetup class to ISalespersonBonusSetupRepository.
        /// </summary>
        /// <param name="salespersonBonusSetup">The instance of SalespersonBonusSetup class to insert.</param>
        object Add(dynamic salespersonBonusSetup);

        /// <summary>
        /// Inserts or updates multiple instances of SalespersonBonusSetup class to ISalespersonBonusSetupRepository.;
        /// </summary>
        /// <param name="salespersonBonusSetups">List of SalespersonBonusSetup class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> salespersonBonusSetups);


        /// <summary>
        /// Updates ISalespersonBonusSetupRepository with an instance of SalespersonBonusSetup class against the primary key value.
        /// </summary>
        /// <param name="salespersonBonusSetup">The instance of SalespersonBonusSetup class to update.</param>
        /// <param name="salespersonBonusSetupId">The value of the column "salesperson_bonus_setup_id" which will be updated.</param>
        void Update(dynamic salespersonBonusSetup, int salespersonBonusSetupId);

        /// <summary>
        /// Deletes SalespersonBonusSetup from  ISalespersonBonusSetupRepository against the primary key value.
        /// </summary>
        /// <param name="salespersonBonusSetupId">The value of the column "salesperson_bonus_setup_id" which will be deleted.</param>
        void Delete(int salespersonBonusSetupId);

        /// <summary>
        /// Produces a paginated result of 10 SalespersonBonusSetup classes.
        /// </summary>
        /// <returns>Returns the first page of collection of SalespersonBonusSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 SalespersonBonusSetup classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of SalespersonBonusSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalespersonBonusSetupRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of SalespersonBonusSetup class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ISalespersonBonusSetupRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of SalespersonBonusSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalespersonBonusSetupRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of SalespersonBonusSetup class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ISalespersonBonusSetupRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of SalespersonBonusSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetFiltered(long pageNumber, string filterName);



    }
}