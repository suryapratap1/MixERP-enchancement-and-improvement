// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Audit.Data
{
    public interface ILoginRepository
    {
        /// <summary>
        /// Counts the number of Login in ILoginRepository.
        /// </summary>
        /// <returns>Returns the count of ILoginRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Login. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Login.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.Login> GetAll();

        /// <summary>
        /// Returns all instances of Login to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Login.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Login against loginId. 
        /// </summary>
        /// <param name="loginId">The column "login_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Login.</returns>
        MixERP.Net.Entities.Audit.Login Get(long loginId);

        /// <summary>
        /// Gets the first record of Login.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Login.</returns>
        MixERP.Net.Entities.Audit.Login GetFirst();

        /// <summary>
        /// Gets the previous record of Login sorted by loginId. 
        /// </summary>
        /// <param name="loginId">The column "login_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Login.</returns>
        MixERP.Net.Entities.Audit.Login GetPrevious(long loginId);

        /// <summary>
        /// Gets the next record of Login sorted by loginId. 
        /// </summary>
        /// <param name="loginId">The column "login_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Login.</returns>
        MixERP.Net.Entities.Audit.Login GetNext(long loginId);

        /// <summary>
        /// Gets the last record of Login.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Login.</returns>
        MixERP.Net.Entities.Audit.Login GetLast();

        /// <summary>
        /// Returns multiple instances of the Login against loginIds. 
        /// </summary>
        /// <param name="loginIds">Array of column "login_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Login.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.Login> Get(long[] loginIds);

        /// <summary>
        /// Custom fields are user defined form elements for ILoginRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Login.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Login.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Login.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Login class to ILoginRepository.
        /// </summary>
        /// <param name="login">The instance of Login class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic login, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Login class to ILoginRepository.
        /// </summary>
        /// <param name="login">The instance of Login class to insert.</param>
        object Add(dynamic login);

        /// <summary>
        /// Inserts or updates multiple instances of Login class to ILoginRepository.;
        /// </summary>
        /// <param name="logins">List of Login class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> logins);


        /// <summary>
        /// Updates ILoginRepository with an instance of Login class against the primary key value.
        /// </summary>
        /// <param name="login">The instance of Login class to update.</param>
        /// <param name="loginId">The value of the column "login_id" which will be updated.</param>
        void Update(dynamic login, long loginId);

        /// <summary>
        /// Deletes Login from  ILoginRepository against the primary key value.
        /// </summary>
        /// <param name="loginId">The value of the column "login_id" which will be deleted.</param>
        void Delete(long loginId);

        /// <summary>
        /// Produces a paginated result of 10 Login classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Login class.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.Login> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Login classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Login class.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.Login> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ILoginRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Login class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ILoginRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Login class.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.Login> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ILoginRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Login class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ILoginRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Login class.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.Login> GetFiltered(long pageNumber, string filterName);



    }
}