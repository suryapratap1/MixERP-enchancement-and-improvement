// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IPayGradeRepository
    {
        /// <summary>
        /// Counts the number of PayGrade in IPayGradeRepository.
        /// </summary>
        /// <returns>Returns the count of IPayGradeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of PayGrade. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of PayGrade.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.PayGrade> GetAll();

        /// <summary>
        /// Returns all instances of PayGrade to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of PayGrade.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the PayGrade against payGradeId. 
        /// </summary>
        /// <param name="payGradeId">The column "pay_grade_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of PayGrade.</returns>
        MixERP.Net.Entities.HRM.PayGrade Get(int payGradeId);

        /// <summary>
        /// Gets the first record of PayGrade.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of PayGrade.</returns>
        MixERP.Net.Entities.HRM.PayGrade GetFirst();

        /// <summary>
        /// Gets the previous record of PayGrade sorted by payGradeId. 
        /// </summary>
        /// <param name="payGradeId">The column "pay_grade_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of PayGrade.</returns>
        MixERP.Net.Entities.HRM.PayGrade GetPrevious(int payGradeId);

        /// <summary>
        /// Gets the next record of PayGrade sorted by payGradeId. 
        /// </summary>
        /// <param name="payGradeId">The column "pay_grade_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of PayGrade.</returns>
        MixERP.Net.Entities.HRM.PayGrade GetNext(int payGradeId);

        /// <summary>
        /// Gets the last record of PayGrade.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of PayGrade.</returns>
        MixERP.Net.Entities.HRM.PayGrade GetLast();

        /// <summary>
        /// Returns multiple instances of the PayGrade against payGradeIds. 
        /// </summary>
        /// <param name="payGradeIds">Array of column "pay_grade_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of PayGrade.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.PayGrade> Get(int[] payGradeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IPayGradeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for PayGrade.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding PayGrade.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for PayGrade.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of PayGrade class to IPayGradeRepository.
        /// </summary>
        /// <param name="payGrade">The instance of PayGrade class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic payGrade, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of PayGrade class to IPayGradeRepository.
        /// </summary>
        /// <param name="payGrade">The instance of PayGrade class to insert.</param>
        object Add(dynamic payGrade);

        /// <summary>
        /// Inserts or updates multiple instances of PayGrade class to IPayGradeRepository.;
        /// </summary>
        /// <param name="payGrades">List of PayGrade class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> payGrades);


        /// <summary>
        /// Updates IPayGradeRepository with an instance of PayGrade class against the primary key value.
        /// </summary>
        /// <param name="payGrade">The instance of PayGrade class to update.</param>
        /// <param name="payGradeId">The value of the column "pay_grade_id" which will be updated.</param>
        void Update(dynamic payGrade, int payGradeId);

        /// <summary>
        /// Deletes PayGrade from  IPayGradeRepository against the primary key value.
        /// </summary>
        /// <param name="payGradeId">The value of the column "pay_grade_id" which will be deleted.</param>
        void Delete(int payGradeId);

        /// <summary>
        /// Produces a paginated result of 10 PayGrade classes.
        /// </summary>
        /// <returns>Returns the first page of collection of PayGrade class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.PayGrade> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 PayGrade classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of PayGrade class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.PayGrade> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPayGradeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of PayGrade class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IPayGradeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of PayGrade class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.PayGrade> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPayGradeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of PayGrade class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IPayGradeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of PayGrade class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.PayGrade> GetFiltered(long pageNumber, string filterName);



    }
}