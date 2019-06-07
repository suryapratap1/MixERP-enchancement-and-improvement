// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ITaxMasterRepository
    {
        /// <summary>
        /// Counts the number of TaxMaster in ITaxMasterRepository.
        /// </summary>
        /// <returns>Returns the count of ITaxMasterRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of TaxMaster. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of TaxMaster.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxMaster> GetAll();

        /// <summary>
        /// Returns all instances of TaxMaster to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of TaxMaster.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the TaxMaster against taxMasterId. 
        /// </summary>
        /// <param name="taxMasterId">The column "tax_master_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of TaxMaster.</returns>
        MixERP.Net.Entities.Core.TaxMaster Get(int taxMasterId);

        /// <summary>
        /// Gets the first record of TaxMaster.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of TaxMaster.</returns>
        MixERP.Net.Entities.Core.TaxMaster GetFirst();

        /// <summary>
        /// Gets the previous record of TaxMaster sorted by taxMasterId. 
        /// </summary>
        /// <param name="taxMasterId">The column "tax_master_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of TaxMaster.</returns>
        MixERP.Net.Entities.Core.TaxMaster GetPrevious(int taxMasterId);

        /// <summary>
        /// Gets the next record of TaxMaster sorted by taxMasterId. 
        /// </summary>
        /// <param name="taxMasterId">The column "tax_master_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of TaxMaster.</returns>
        MixERP.Net.Entities.Core.TaxMaster GetNext(int taxMasterId);

        /// <summary>
        /// Gets the last record of TaxMaster.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of TaxMaster.</returns>
        MixERP.Net.Entities.Core.TaxMaster GetLast();

        /// <summary>
        /// Returns multiple instances of the TaxMaster against taxMasterIds. 
        /// </summary>
        /// <param name="taxMasterIds">Array of column "tax_master_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of TaxMaster.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxMaster> Get(int[] taxMasterIds);

        /// <summary>
        /// Custom fields are user defined form elements for ITaxMasterRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for TaxMaster.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding TaxMaster.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for TaxMaster.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of TaxMaster class to ITaxMasterRepository.
        /// </summary>
        /// <param name="taxMaster">The instance of TaxMaster class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic taxMaster, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of TaxMaster class to ITaxMasterRepository.
        /// </summary>
        /// <param name="taxMaster">The instance of TaxMaster class to insert.</param>
        object Add(dynamic taxMaster);

        /// <summary>
        /// Inserts or updates multiple instances of TaxMaster class to ITaxMasterRepository.;
        /// </summary>
        /// <param name="taxMasters">List of TaxMaster class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> taxMasters);


        /// <summary>
        /// Updates ITaxMasterRepository with an instance of TaxMaster class against the primary key value.
        /// </summary>
        /// <param name="taxMaster">The instance of TaxMaster class to update.</param>
        /// <param name="taxMasterId">The value of the column "tax_master_id" which will be updated.</param>
        void Update(dynamic taxMaster, int taxMasterId);

        /// <summary>
        /// Deletes TaxMaster from  ITaxMasterRepository against the primary key value.
        /// </summary>
        /// <param name="taxMasterId">The value of the column "tax_master_id" which will be deleted.</param>
        void Delete(int taxMasterId);

        /// <summary>
        /// Produces a paginated result of 10 TaxMaster classes.
        /// </summary>
        /// <returns>Returns the first page of collection of TaxMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxMaster> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 TaxMaster classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of TaxMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxMaster> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITaxMasterRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of TaxMaster class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ITaxMasterRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of TaxMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxMaster> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITaxMasterRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of TaxMaster class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ITaxMasterRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of TaxMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxMaster> GetFiltered(long pageNumber, string filterName);



    }
}