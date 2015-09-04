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
// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Public
{
    [PrimaryKey("", autoIncrement=false)]
    [FunctionName("public.crosstab4")]
    [ExplicitColumns]
    public sealed class DbCrosstab4Result : PetaPocoDB.Record<DbCrosstab4Result>, IPoco
    {
        [Column("row_name")]
        [ColumnDbType("text", 0, false, "")] 
        public string RowName { get; set; }
    
        [Column("category_1")]
        [ColumnDbType("text", 0, false, "")] 
        public string Category1 { get; set; }
    
        [Column("category_2")]
        [ColumnDbType("text", 0, false, "")] 
        public string Category2 { get; set; }
    
        [Column("category_3")]
        [ColumnDbType("text", 0, false, "")] 
        public string Category3 { get; set; }
    
        [Column("category_4")]
        [ColumnDbType("text", 0, false, "")] 
        public string Category4 { get; set; }
    }
}