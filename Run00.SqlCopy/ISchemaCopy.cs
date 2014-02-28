﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run00.SqlCopy
{
	public interface ISchemaCopy
	{
		void CopySchema(DatabaseInfo source, DatabaseInfo target);
		void CopySchema(DatabaseInfo source, DatabaseInfo target, SchemaRewriteInfo rewriteInfo);
	}
}
