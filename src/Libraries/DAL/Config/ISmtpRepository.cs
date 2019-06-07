// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface ISmtpRepository
    {
        /// <summary>
        /// Counts the number of Smtp in ISmtpRepository.
        /// </summary>
        /// <returns>Returns the count of ISmtpRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Smtp. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Smtp.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Smtp> GetAll();

        /// <summary>
        /// Returns all instances of Smtp to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Smtp.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Smtp against smtpId. 
        /// </summary>
        /// <param name="smtpId">The column "smtp_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Smtp.</returns>
        MixERP.Net.Entities.Config.Smtp Get(int smtpId);

        /// <summary>
        /// Gets the first record of Smtp.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Smtp.</returns>
        MixERP.Net.Entities.Config.Smtp GetFirst();

        /// <summary>
        /// Gets the previous record of Smtp sorted by smtpId. 
        /// </summary>
        /// <param name="smtpId">The column "smtp_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Smtp.</returns>
        MixERP.Net.Entities.Config.Smtp GetPrevious(int smtpId);

        /// <summary>
        /// Gets the next record of Smtp sorted by smtpId. 
        /// </summary>
        /// <param name="smtpId">The column "smtp_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Smtp.</returns>
        MixERP.Net.Entities.Config.Smtp GetNext(int smtpId);

        /// <summary>
        /// Gets the last record of Smtp.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Smtp.</returns>
        MixERP.Net.Entities.Config.Smtp GetLast();

        /// <summary>
        /// Returns multiple instances of the Smtp against smtpIds. 
        /// </summary>
        /// <param name="smtpIds">Array of column "smtp_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Smtp.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Smtp> Get(int[] smtpIds);

        /// <summary>
        /// Custom fields are user defined form elements for ISmtpRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Smtp.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Smtp.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Smtp.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Smtp class to ISmtpRepository.
        /// </summary>
        /// <param name="smtp">The instance of Smtp class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic smtp, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Smtp class to ISmtpRepository.
        /// </summary>
        /// <param name="smtp">The instance of Smtp class to insert.</param>
        object Add(dynamic smtp);

        /// <summary>
        /// Inserts or updates multiple instances of Smtp class to ISmtpRepository.;
        /// </summary>
        /// <param name="smtps">List of Smtp class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> smtps);


        /// <summary>
        /// Updates ISmtpRepository with an instance of Smtp class against the primary key value.
        /// </summary>
        /// <param name="smtp">The instance of Smtp class to update.</param>
        /// <param name="smtpId">The value of the column "smtp_id" which will be updated.</param>
        void Update(dynamic smtp, int smtpId);

        /// <summary>
        /// Deletes Smtp from  ISmtpRepository against the primary key value.
        /// </summary>
        /// <param name="smtpId">The value of the column "smtp_id" which will be deleted.</param>
        void Delete(int smtpId);

        /// <summary>
        /// Produces a paginated result of 10 Smtp classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Smtp class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Smtp> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Smtp classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Smtp class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Smtp> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISmtpRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Smtp class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ISmtpRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Smtp class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Smtp> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISmtpRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Smtp class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ISmtpRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Smtp class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Smtp> GetFiltered(long pageNumber, string filterName);



    }
}