﻿using Run00.SqlCopy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Run00.SqlCopySqlServer
{
	public class TableBulkCopy : ITableBulkCopy
	{
		void ITableBulkCopy.Copy(DatabaseInfo targetDatabase, DataTable dataTable)
		{
			System.Diagnostics.Debug.WriteLine(String.Format("Copying {0} rows for table {1}", dataTable.Rows.Count, dataTable.TableName));
			var copy = new SqlBulkCopy(targetDatabase.ConnectionString, SqlBulkCopyOptions.KeepIdentity | SqlBulkCopyOptions.KeepNulls);
			copy.BulkCopyTimeout = 60000;
			if (dataTable.TableName.Equals("dbo.user"))
			{
				dataTable.TableName = "[dbo].[user]";
			}
			copy.DestinationTableName = dataTable.TableName;
			copy.WriteToServer(dataTable);
		}
	}
}