// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Core;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Core.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "core.create_kanban(_object_name character varying, _user_id integer, _kanban_name character varying, _description text)" on the database.
    /// </summary>
    public class CreateKanbanProcedure : DbAccess, ICreateKanbanRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "create_kanban";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
        public long _LoginId { get; set; }
        /// <summary>
        /// User id of application user accessing this table.
        /// </summary>
        public int _UserId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string _Catalog { get; set; }

        /// <summary>
        /// Maps to "_object_name" argument of the function "core.create_kanban".
        /// </summary>
        public string ObjectName { get; set; }
        /// <summary>
        /// Maps to "_user_id" argument of the function "core.create_kanban".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_kanban_name" argument of the function "core.create_kanban".
        /// </summary>
        public string KanbanName { get; set; }
        /// <summary>
        /// Maps to "_description" argument of the function "core.create_kanban".
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_kanban(_object_name character varying, _user_id integer, _kanban_name character varying, _description text)" on the database.
        /// </summary>
        public CreateKanbanProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_kanban(_object_name character varying, _user_id integer, _kanban_name character varying, _description text)" on the database.
        /// </summary>
        /// <param name="objectName">Enter argument value for "_object_name" parameter of the function "core.create_kanban".</param>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "core.create_kanban".</param>
        /// <param name="kanbanName">Enter argument value for "_kanban_name" parameter of the function "core.create_kanban".</param>
        /// <param name="description">Enter argument value for "_description" parameter of the function "core.create_kanban".</param>
        public CreateKanbanProcedure(string objectName, int userId, string kanbanName, string description)
        {
            this.ObjectName = objectName;
            this.UserId = userId;
            this.KanbanName = kanbanName;
            this.Description = description;
        }
        /// <summary>
        /// Prepares and executes the function "core.create_kanban".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"CreateKanbanProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.create_kanban(@ObjectName, @UserId, @KanbanName, @Description);";

            query = query.ReplaceWholeWord("@ObjectName", "@0::character varying");
            query = query.ReplaceWholeWord("@UserId", "@1::integer");
            query = query.ReplaceWholeWord("@KanbanName", "@2::character varying");
            query = query.ReplaceWholeWord("@Description", "@3::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.ObjectName);
            parameters.Add(this.UserId);
            parameters.Add(this.KanbanName);
            parameters.Add(this.Description);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}