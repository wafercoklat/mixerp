/********************************************************************************
Copyright (C) MixERP Inc. (http://mixof.org).
This file is part of MixERP.
MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.

MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/
//Resharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
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
	/// Prepares, validates, and executes the function "core.get_base_quantity_by_unit_id(pg_arg0 integer, pg_arg1 integer)" on the database.
	/// </summary>
	public class GetBaseQuantityByUnitIdProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_base_quantity_by_unit_id";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Maps to "pg_arg0" argument of the function "core.get_base_quantity_by_unit_id".
		/// </summary>
		public int PgArg0 { get; set; }
		/// <summary>
		/// Maps to "pg_arg1" argument of the function "core.get_base_quantity_by_unit_id".
		/// </summary>
		public int PgArg1 { get; set; }

		/// <summary>
		/// Prepares, validates, and executes the function "core.get_base_quantity_by_unit_id(pg_arg0 integer, pg_arg1 integer)" on the database.
		/// </summary>
		public GetBaseQuantityByUnitIdProcedure()
		{
		}

		/// <summary>
		/// Prepares, validates, and executes the function "core.get_base_quantity_by_unit_id(pg_arg0 integer, pg_arg1 integer)" on the database.
		/// </summary>
		/// <param name="pgArg0">Enter argument value for "pg_arg0" parameter of the function "core.get_base_quantity_by_unit_id".</param>
		/// <param name="pgArg1">Enter argument value for "pg_arg1" parameter of the function "core.get_base_quantity_by_unit_id".</param>
		public GetBaseQuantityByUnitIdProcedure(int pgArg0,int pgArg1)
		{
			this.PgArg0 = pgArg0;
			this.PgArg1 = pgArg1;
		}
		/// <summary>
		/// Prepares and executes the function "core.get_base_quantity_by_unit_id".
		/// </summary>
		public decimal Execute()
		{
			if (!this.SkipValidation)
			{
				if (!this.Validated)
				{
					this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
				}
				if (!this.HasAccess)
				{
                    Log.Information("Access to the function \"GetBaseQuantityByUnitIdProcedure\" was denied to the user with Login ID {LoginId}.", this.LoginId);
					throw new UnauthorizedException("Access is denied.");
				}
			}
			const string query = "SELECT * FROM core.get_base_quantity_by_unit_id(@0::integer, @1::integer);";
			return Factory.Scalar<decimal>(this.Catalog, query, this.PgArg0, this.PgArg1);
		} 
	}
}