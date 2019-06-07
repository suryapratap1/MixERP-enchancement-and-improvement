// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IUserRepository
    {
        /// <summary>
        /// Counts the number of User in IUserRepository.
        /// </summary>
        /// <returns>Returns the count of IUserRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of User. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of User.</returns>
        IEnumerable<MixERP.Net.Entities.Office.User> GetAll();

        /// <summary>
        /// Returns all instances of User to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of User.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the User against userId. 
        /// </summary>
        /// <param name="userId">The column "user_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of User.</returns>
        MixERP.Net.Entities.Office.User Get(int userId);

        /// <summary>
        /// Gets the first record of User.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of User.</returns>
        MixERP.Net.Entities.Office.User GetFirst();

        /// <summary>
        /// Gets the previous record of User sorted by userId. 
        /// </summary>
        /// <param name="userId">The column "user_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of User.</returns>
        MixERP.Net.Entities.Office.User GetPrevious(int userId);

        /// <summary>
        /// Gets the next record of User sorted by userId. 
        /// </summary>
        /// <param name="userId">The column "user_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of User.</returns>
        MixERP.Net.Entities.Office.User GetNext(int userId);

        /// <summary>
        /// Gets the last record of User.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of User.</returns>
        MixERP.Net.Entities.Office.User GetLast();

        /// <summary>
        /// Returns multiple instances of the User against userIds. 
        /// </summary>
        /// <param name="userIds">Array of column "user_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of User.</returns>
        IEnumerable<MixERP.Net.Entities.Office.User> Get(int[] userIds);

        /// <summary>
        /// Custom fields are user defined form elements for IUserRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for User.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding User.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for User.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of User class to IUserRepository.
        /// </summary>
        /// <param name="user">The instance of User class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic user, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of User class to IUserRepository.
        /// </summary>
        /// <param name="user">The instance of User class to insert.</param>
        object Add(dynamic user);

        /// <summary>
        /// Inserts or updates multiple instances of User class to IUserRepository.;
        /// </summary>
        /// <param name="users">List of User class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> users);


        /// <summary>
        /// Updates IUserRepository with an instance of User class against the primary key value.
        /// </summary>
        /// <param name="user">The instance of User class to update.</param>
        /// <param name="userId">The value of the column "user_id" which will be updated.</param>
        void Update(dynamic user, int userId);

        /// <summary>
        /// Deletes User from  IUserRepository against the primary key value.
        /// </summary>
        /// <param name="userId">The value of the column "user_id" which will be deleted.</param>
        void Delete(int userId);

        /// <summary>
        /// Produces a paginated result of 10 User classes.
        /// </summary>
        /// <returns>Returns the first page of collection of User class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.User> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 User classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of User class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.User> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IUserRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of User class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IUserRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of User class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.User> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IUserRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of User class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IUserRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of User class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.User> GetFiltered(long pageNumber, string filterName);



    }
}