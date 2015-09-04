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
using MixERP.Net.Entities.Office;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Office.Data
{
	/// <summary>
	/// Prepares, validates, and executes the function "office.get_sys_user_id()" on the database.
	/// </summary>
	public class GetSysUserIdProcedure: DbAccess
	{
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
	    public override string ObjectNamespace => "office";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
	    public override string ObjectName => "get_sys_user_id";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
		public long LoginId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		
		/// <summary>
		/// Prepares, validates, and executes the function "office.get_sys_user_id()" on the database.
		/// </summary>
		public GetSysUserIdProcedure()
		{
		}
		/// <summary>
		/// Prepares and executes the function "office.get_sys_user_id".
		/// </summary>
		public int Execute()
		{
			try
			{
				if (!this.SkipValidation)
				{
					if (!this.Validated)
					{
						this.Validate(AccessTypeEnum.Execute, this.LoginId, false);
					}
					if (!this.HasAccess)
					{
						throw new UnauthorizedException("Access is denied.");
					}
				}
				const string query = "SELECT * FROM office.get_sys_user_id();";
				return Factory.Scalar<int>(this.Catalog, query);
			}
			catch (UnauthorizedException ex)
			{
				Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
			}
		} 
	}
}