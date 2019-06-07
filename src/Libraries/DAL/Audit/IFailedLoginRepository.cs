// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Audit.Data
{
    public interface IFailedLoginRepository
    {
        /// <summary>
        /// Counts the number of FailedLogin in IFailedLoginRepository.
        /// </summary>
        /// <returns>Returns the count of IFailedLoginRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of FailedLogin. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of FailedLogin.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetAll();

        /// <summary>
        /// Returns all instances of FailedLogin to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of FailedLogin.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the FailedLogin against failedLoginId. 
        /// </summary>
        /// <param name="failedLoginId">The column "failed_login_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of FailedLogin.</returns>
        MixERP.Net.Entities.Audit.FailedLogin Get(long failedLoginId);

        /// <summary>
        /// Gets the first record of FailedLogin.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of FailedLogin.</returns>
        MixERP.Net.Entities.Audit.FailedLogin GetFirst();

        /// <summary>
        /// Gets the previous record of FailedLogin sorted by failedLoginId. 
        /// </summary>
        /// <param name="failedLoginId">The column "failed_login_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of FailedLogin.</returns>
        MixERP.Net.Entities.Audit.FailedLogin GetPrevious(long failedLoginId);

        /// <summary>
        /// Gets the next record of FailedLogin sorted by failedLoginId. 
        /// </summary>
        /// <param name="failedLoginId">The column "failed_login_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of FailedLogin.</returns>
        MixERP.Net.Entities.Audit.FailedLogin GetNext(long failedLoginId);

        /// <summary>
        /// Gets the last record of FailedLogin.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of FailedLogin.</returns>
        MixERP.Net.Entities.Audit.FailedLogin GetLast();

        /// <summary>
        /// Returns multiple instances of the FailedLogin against failedLoginIds. 
        /// </summary>
        /// <param name="failedLoginIds">Array of column "failed_login_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of FailedLogin.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> Get(long[] failedLoginIds);

        /// <summary>
        /// Custom fields are user defined form elements for IFailedLoginRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for FailedLogin.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding FailedLogin.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for FailedLogin.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of FailedLogin class to IFailedLoginRepository.
        /// </summary>
        /// <param name="failedLogin">The instance of FailedLogin class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic failedLogin, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of FailedLogin class to IFailedLoginRepository.
        /// </summary>
        /// <param name="failedLogin">The instance of FailedLogin class to insert.</param>
        object Add(dynamic failedLogin);

        /// <summary>
        /// Inserts or updates multiple instances of FailedLogin class to IFailedLoginRepository.;
        /// </summary>
        /// <param name="failedLogins">List of FailedLogin class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> failedLogins);


        /// <summary>
        /// Updates IFailedLoginRepository with an instance of FailedLogin class against the primary key value.
        /// </summary>
        /// <param name="failedLogin">The instance of FailedLogin class to update.</param>
        /// <param name="failedLoginId">The value of the column "failed_login_id" which will be updated.</param>
        void Update(dynamic failedLogin, long failedLoginId);

        /// <summary>
        /// Deletes FailedLogin from  IFailedLoginRepository against the primary key value.
        /// </summary>
        /// <param name="failedLoginId">The value of the column "failed_login_id" which will be deleted.</param>
        void Delete(long failedLoginId);

        /// <summary>
        /// Produces a paginated result of 10 FailedLogin classes.
        /// </summary>
        /// <returns>Returns the first page of collection of FailedLogin class.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 FailedLogin classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of FailedLogin class.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IFailedLoginRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of FailedLogin class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IFailedLoginRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of FailedLogin class.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IFailedLoginRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of FailedLogin class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IFailedLoginRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of FailedLogin class.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetFiltered(long pageNumber, string filterName);



    }
}