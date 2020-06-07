using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace nikstra.SqlUtilities
{
    public class TableAlias
    {
        public string Name { get; }
        public string Alias { get; }

        public TableAlias(string name, string alias)
        {
            Name = name;
            Alias = alias;
        }
    }
}
