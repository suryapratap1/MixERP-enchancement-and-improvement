// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IStateRepository
    {
        /// <summary>
        /// Counts the number of State in IStateRepository.
        /// </summary>
        /// <returns>Returns the count of IStateRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of State. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of State.</returns>
        IEnumerable<MixERP.Net.Entities.Core.State> GetAll();

        /// <summary>
        /// Returns all instances of State to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of State.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the State against stateId. 
        /// </summary>
        /// <param name="stateId">The column "state_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of State.</returns>
        MixERP.Net.Entities.Core.State Get(int stateId);

        /// <summary>
        /// Gets the first record of State.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of State.</returns>
        MixERP.Net.Entities.Core.State GetFirst();

        /// <summary>
        /// Gets the previous record of State sorted by stateId. 
        /// </summary>
        /// <param name="stateId">The column "state_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of State.</returns>
        MixERP.Net.Entities.Core.State GetPrevious(int stateId);

        /// <summary>
        /// Gets the next record of State sorted by stateId. 
        /// </summary>
        /// <param name="stateId">The column "state_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of State.</returns>
        MixERP.Net.Entities.Core.State GetNext(int stateId);

        /// <summary>
        /// Gets the last record of State.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of State.</returns>
        MixERP.Net.Entities.Core.State GetLast();

        /// <summary>
        /// Returns multiple instances of the State against stateIds. 
        /// </summary>
        /// <param name="stateIds">Array of column "state_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of State.</returns>
        IEnumerable<MixERP.Net.Entities.Core.State> Get(int[] stateIds);

        /// <summary>
        /// Custom fields are user defined form elements for IStateRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for State.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding State.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for State.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of State class to IStateRepository.
        /// </summary>
        /// <param name="state">The instance of State class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic state, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of State class to IStateRepository.
        /// </summary>
        /// <param name="state">The instance of State class to insert.</param>
        object Add(dynamic state);

        /// <summary>
        /// Inserts or updates multiple instances of State class to IStateRepository.;
        /// </summary>
        /// <param name="states">List of State class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> states);


        /// <summary>
        /// Updates IStateRepository with an instance of State class against the primary key value.
        /// </summary>
        /// <param name="state">The instance of State class to update.</param>
        /// <param name="stateId">The value of the column "state_id" which will be updated.</param>
        void Update(dynamic state, int stateId);

        /// <summary>
        /// Deletes State from  IStateRepository against the primary key value.
        /// </summary>
        /// <param name="stateId">The value of the column "state_id" which will be deleted.</param>
        void Delete(int stateId);

        /// <summary>
        /// Produces a paginated result of 10 State classes.
        /// </summary>
        /// <returns>Returns the first page of collection of State class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.State> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 State classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of State class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.State> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStateRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of State class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IStateRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of State class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.State> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStateRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of State class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IStateRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of State class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.State> GetFiltered(long pageNumber, string filterName);



    }
}