// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface ILeaveBenefitRepository
    {
        /// <summary>
        /// Counts the number of LeaveBenefit in ILeaveBenefitRepository.
        /// </summary>
        /// <returns>Returns the count of ILeaveBenefitRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of LeaveBenefit. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of LeaveBenefit.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> GetAll();

        /// <summary>
        /// Returns all instances of LeaveBenefit to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of LeaveBenefit.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the LeaveBenefit against leaveBenefitId. 
        /// </summary>
        /// <param name="leaveBenefitId">The column "leave_benefit_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of LeaveBenefit.</returns>
        MixERP.Net.Entities.HRM.LeaveBenefit Get(int leaveBenefitId);

        /// <summary>
        /// Gets the first record of LeaveBenefit.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of LeaveBenefit.</returns>
        MixERP.Net.Entities.HRM.LeaveBenefit GetFirst();

        /// <summary>
        /// Gets the previous record of LeaveBenefit sorted by leaveBenefitId. 
        /// </summary>
        /// <param name="leaveBenefitId">The column "leave_benefit_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of LeaveBenefit.</returns>
        MixERP.Net.Entities.HRM.LeaveBenefit GetPrevious(int leaveBenefitId);

        /// <summary>
        /// Gets the next record of LeaveBenefit sorted by leaveBenefitId. 
        /// </summary>
        /// <param name="leaveBenefitId">The column "leave_benefit_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of LeaveBenefit.</returns>
        MixERP.Net.Entities.HRM.LeaveBenefit GetNext(int leaveBenefitId);

        /// <summary>
        /// Gets the last record of LeaveBenefit.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of LeaveBenefit.</returns>
        MixERP.Net.Entities.HRM.LeaveBenefit GetLast();

        /// <summary>
        /// Returns multiple instances of the LeaveBenefit against leaveBenefitIds. 
        /// </summary>
        /// <param name="leaveBenefitIds">Array of column "leave_benefit_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of LeaveBenefit.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> Get(int[] leaveBenefitIds);

        /// <summary>
        /// Custom fields are user defined form elements for ILeaveBenefitRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for LeaveBenefit.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding LeaveBenefit.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for LeaveBenefit.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of LeaveBenefit class to ILeaveBenefitRepository.
        /// </summary>
        /// <param name="leaveBenefit">The instance of LeaveBenefit class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic leaveBenefit, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of LeaveBenefit class to ILeaveBenefitRepository.
        /// </summary>
        /// <param name="leaveBenefit">The instance of LeaveBenefit class to insert.</param>
        object Add(dynamic leaveBenefit);

        /// <summary>
        /// Inserts or updates multiple instances of LeaveBenefit class to ILeaveBenefitRepository.;
        /// </summary>
        /// <param name="leaveBenefits">List of LeaveBenefit class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> leaveBenefits);


        /// <summary>
        /// Updates ILeaveBenefitRepository with an instance of LeaveBenefit class against the primary key value.
        /// </summary>
        /// <param name="leaveBenefit">The instance of LeaveBenefit class to update.</param>
        /// <param name="leaveBenefitId">The value of the column "leave_benefit_id" which will be updated.</param>
        void Update(dynamic leaveBenefit, int leaveBenefitId);

        /// <summary>
        /// Deletes LeaveBenefit from  ILeaveBenefitRepository against the primary key value.
        /// </summary>
        /// <param name="leaveBenefitId">The value of the column "leave_benefit_id" which will be deleted.</param>
        void Delete(int leaveBenefitId);

        /// <summary>
        /// Produces a paginated result of 10 LeaveBenefit classes.
        /// </summary>
        /// <returns>Returns the first page of collection of LeaveBenefit class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 LeaveBenefit classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of LeaveBenefit class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ILeaveBenefitRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of LeaveBenefit class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ILeaveBenefitRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of LeaveBenefit class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ILeaveBenefitRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of LeaveBenefit class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ILeaveBenefitRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of LeaveBenefit class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> GetFiltered(long pageNumber, string filterName);



    }
}