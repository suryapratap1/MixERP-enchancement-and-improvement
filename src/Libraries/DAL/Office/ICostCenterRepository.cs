// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface ICostCenterRepository
    {
        /// <summary>
        /// Counts the number of CostCenter in ICostCenterRepository.
        /// </summary>
        /// <returns>Returns the count of ICostCenterRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of CostCenter. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CostCenter.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CostCenter> GetAll();

        /// <summary>
        /// Returns all instances of CostCenter to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CostCenter.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the CostCenter against costCenterId. 
        /// </summary>
        /// <param name="costCenterId">The column "cost_center_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of CostCenter.</returns>
        MixERP.Net.Entities.Office.CostCenter Get(int costCenterId);

        /// <summary>
        /// Gets the first record of CostCenter.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CostCenter.</returns>
        MixERP.Net.Entities.Office.CostCenter GetFirst();

        /// <summary>
        /// Gets the previous record of CostCenter sorted by costCenterId. 
        /// </summary>
        /// <param name="costCenterId">The column "cost_center_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CostCenter.</returns>
        MixERP.Net.Entities.Office.CostCenter GetPrevious(int costCenterId);

        /// <summary>
        /// Gets the next record of CostCenter sorted by costCenterId. 
        /// </summary>
        /// <param name="costCenterId">The column "cost_center_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CostCenter.</returns>
        MixERP.Net.Entities.Office.CostCenter GetNext(int costCenterId);

        /// <summary>
        /// Gets the last record of CostCenter.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CostCenter.</returns>
        MixERP.Net.Entities.Office.CostCenter GetLast();

        /// <summary>
        /// Returns multiple instances of the CostCenter against costCenterIds. 
        /// </summary>
        /// <param name="costCenterIds">Array of column "cost_center_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of CostCenter.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CostCenter> Get(int[] costCenterIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICostCenterRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for CostCenter.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding CostCenter.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for CostCenter.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of CostCenter class to ICostCenterRepository.
        /// </summary>
        /// <param name="costCenter">The instance of CostCenter class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic costCenter, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of CostCenter class to ICostCenterRepository.
        /// </summary>
        /// <param name="costCenter">The instance of CostCenter class to insert.</param>
        object Add(dynamic costCenter);

        /// <summary>
        /// Inserts or updates multiple instances of CostCenter class to ICostCenterRepository.;
        /// </summary>
        /// <param name="costCenters">List of CostCenter class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> costCenters);


        /// <summary>
        /// Updates ICostCenterRepository with an instance of CostCenter class against the primary key value.
        /// </summary>
        /// <param name="costCenter">The instance of CostCenter class to update.</param>
        /// <param name="costCenterId">The value of the column "cost_center_id" which will be updated.</param>
        void Update(dynamic costCenter, int costCenterId);

        /// <summary>
        /// Deletes CostCenter from  ICostCenterRepository against the primary key value.
        /// </summary>
        /// <param name="costCenterId">The value of the column "cost_center_id" which will be deleted.</param>
        void Delete(int costCenterId);

        /// <summary>
        /// Produces a paginated result of 10 CostCenter classes.
        /// </summary>
        /// <returns>Returns the first page of collection of CostCenter class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CostCenter> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 CostCenter classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of CostCenter class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CostCenter> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICostCenterRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of CostCenter class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICostCenterRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of CostCenter class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CostCenter> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICostCenterRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of CostCenter class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICostCenterRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of CostCenter class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CostCenter> GetFiltered(long pageNumber, string filterName);



    }
}