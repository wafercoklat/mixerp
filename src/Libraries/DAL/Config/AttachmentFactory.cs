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
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using Npgsql;
using PetaPoco;
using Serilog;

namespace MixERP.Net.Schemas.Config.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "config.attachment_factory".
    /// </summary>
    public class AttachmentFactory : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "config".
        /// </summary>
	    public override string ObjectNamespace => "config";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "attachment_factory".
        /// </summary>
	    public override string ObjectName => "attachment_factory";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "config.attachment_factory".
		/// </summary>
		/// <returns>Returns the number of rows of the table "config.attachment_factory".</returns>
		public long Count()
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return 0;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "SELECT COUNT(*) FROM config.attachment_factory;";
				return Factory.Scalar<long>(this.Catalog, sql);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Executes a select query on the table "config.attachment_factory" with a where filter on the column "key" to return a single instance of the "AttachmentFactory" class. 
		/// </summary>
		/// <param name="key">The column "key" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "AttachmentFactory" class mapped to the database row.</returns>
		public MixERP.Net.Entities.Config.AttachmentFactory Get(string key)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "SELECT * FROM config.attachment_factory WHERE key=@0;";
				return Factory.Get<MixERP.Net.Entities.Config.AttachmentFactory>(this.Catalog, sql, key).FirstOrDefault();
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of config.attachment_factory.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table config.attachment_factory</returns>
		public IEnumerable<DisplayField> GetDisplayFields()
		{
			List<DisplayField> displayFields = new List<DisplayField>();

			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return displayFields;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "SELECT key AS key, key as value FROM config.attachment_factory;";
				using (NpgsqlCommand command = new NpgsqlCommand(sql))
				{
					using (DataTable table = DbOperation.GetDataTable(this.Catalog, command))
					{
						if (table?.Rows == null || table.Rows.Count == 0)
						{
							return displayFields;
						}

						foreach (DataRow row in table.Rows)
						{
							if (row != null)
							{
								DisplayField displayField = new DisplayField
								{
									Key = row["key"].ToString(),
									Value = row["value"].ToString()
								};

								displayFields.Add(displayField);
							}
						}
					}
				}

				return displayFields;
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Inserts the instance of AttachmentFactory class on the database table "config.attachment_factory".
		/// </summary>
		/// <param name="attachmentFactory">The instance of "AttachmentFactory" class to insert.</param>
		public void Add(MixERP.Net.Entities.Config.AttachmentFactory attachmentFactory)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Create, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				Factory.Insert(this.Catalog, attachmentFactory);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Updates the row of the table "config.attachment_factory" with an instance of "AttachmentFactory" class against the primary key value.
		/// </summary>
		/// <param name="attachmentFactory">The instance of "AttachmentFactory" class to update.</param>
		/// <param name="key">The value of the column "key" which will be updated.</param>
		public void Update(MixERP.Net.Entities.Config.AttachmentFactory attachmentFactory, string key)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Edit, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				Factory.Update(this.Catalog, attachmentFactory, key);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Deletes the row of the table "config.attachment_factory" against the primary key value.
		/// </summary>
		/// <param name="key">The value of the column "key" which will be deleted.</param>
		public void Delete(string key)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Delete, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "DELETE FROM config.attachment_factory WHERE key=@0;";
				Factory.NonQuery(this.Catalog, sql, key);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Performs a select statement on table "config.attachment_factory" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "AttachmentFactory" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Config.AttachmentFactory> GetPagedResult()
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "SELECT * FROM config.attachment_factory ORDER BY key LIMIT 25 OFFSET 0;";
				return Factory.Get<MixERP.Net.Entities.Config.AttachmentFactory>(this.Catalog, sql);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Performs a select statement on table "config.attachment_factory" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "AttachmentFactory" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Config.AttachmentFactory> GetPagedResult(long pageNumber)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				long offset = (pageNumber -1) * 25;
				const string sql = "SELECT * FROM config.attachment_factory ORDER BY key LIMIT 25 OFFSET @0;";
				
				return Factory.Get<MixERP.Net.Entities.Config.AttachmentFactory>(this.Catalog, sql, offset);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}
	}
}