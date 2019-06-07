// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesTeamRepository
    {
        /// <summary>
        /// Counts the number of SalesTeam in ISalesTeamRepository.
        /// </summary>
        /// <returns>Returns the count of ISalesTeamRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of SalesTeam. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SalesTeam.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeam> GetAll();

        /// <summary>
        /// Returns all instances of SalesTeam to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SalesTeam.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the SalesTeam against salesTeamId. 
        /// </summary>
        /// <param name="salesTeamId">The column "sales_team_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTeam.</returns>
        MixERP.Net.Entities.Core.SalesTeam Get(int salesTeamId);

        /// <summary>
        /// Gets the first record of SalesTeam.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SalesTeam.</returns>
        MixERP.Net.Entities.Core.SalesTeam GetFirst();

        /// <summary>
        /// Gets the previous record of SalesTeam sorted by salesTeamId. 
        /// </summary>
        /// <param name="salesTeamId">The column "sales_team_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTeam.</returns>
        MixERP.Net.Entities.Core.SalesTeam GetPrevious(int salesTeamId);

        /// <summary>
        /// Gets the next record of SalesTeam sorted by salesTeamId. 
        /// </summary>
        /// <param name="salesTeamId">The column "sales_team_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTeam.</returns>
        MixERP.Net.Entities.Core.SalesTeam GetNext(int salesTeamId);

        /// <summary>
        /// Gets the last record of SalesTeam.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SalesTeam.</returns>
        MixERP.Net.Entities.Core.SalesTeam GetLast();

        /// <summary>
        /// Returns multiple instances of the SalesTeam against salesTeamIds. 
        /// </summary>
        /// <param name="salesTeamIds">Array of column "sales_team_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of SalesTeam.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeam> Get(int[] salesTeamIds);

        /// <summary>
        /// Custom fields are user defined form elements for ISalesTeamRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for SalesTeam.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding SalesTeam.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for SalesTeam.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of SalesTeam class to ISalesTeamRepository.
        /// </summary>
        /// <param name="salesTeam">The instance of SalesTeam class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic salesTeam, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of SalesTeam class to ISalesTeamRepository.
        /// </summary>
        /// <param name="salesTeam">The instance of SalesTeam class to insert.</param>
        object Add(dynamic salesTeam);

        /// <summary>
        /// Inserts or updates multiple instances of SalesTeam class to ISalesTeamRepository.;
        /// </summary>
        /// <param name="salesTeams">List of SalesTeam class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> salesTeams);


        /// <summary>
        /// Updates ISalesTeamRepository with an instance of SalesTeam class against the primary key value.
        /// </summary>
        /// <param name="salesTeam">The instance of SalesTeam class to update.</param>
        /// <param name="salesTeamId">The value of the column "sales_team_id" which will be updated.</param>
        void Update(dynamic salesTeam, int salesTeamId);

        /// <summary>
        /// Deletes SalesTeam from  ISalesTeamRepository against the primary key value.
        /// </summary>
        /// <param name="salesTeamId">The value of the column "sales_team_id" which will be deleted.</param>
        void Delete(int salesTeamId);

        /// <summary>
        /// Produces a paginated result of 10 SalesTeam classes.
        /// </summary>
        /// <returns>Returns the first page of collection of SalesTeam class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeam> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 SalesTeam classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of SalesTeam class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeam> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesTeamRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of SalesTeam class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ISalesTeamRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of SalesTeam class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeam> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesTeamRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of SalesTeam class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ISalesTeamRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of SalesTeam class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeam> GetFiltered(long pageNumber, string filterName);



    }
}