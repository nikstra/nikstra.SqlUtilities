using System;
using System.Collections.Generic;
using System.Text;

namespace nikstra.SqlUtilities
{
    public class TableAliasFactory
    {
        private string _defaultSchema;
        private IDictionary<string, int> _tableAliases { get; set; } =
            new Dictionary<string, int>();

        private IDictionary<string, TableAlias> _tables { get; set; } =
            new Dictionary<string, TableAlias>();

        public TableAlias this[string table] =>
            GetOrCreate(table);

        public TableAlias this[string schema, string table] =>
            GetOrCreate(schema, table);

        public TableAliasFactory()
            : this("[dbo]") { }

        public TableAliasFactory(string defaultSchema) =>
            _defaultSchema = defaultSchema.AddTSqlDelimiters();

        public TableAlias GetOrCreate(string table) =>
            GetOrCreate(_defaultSchema, table);

        public TableAlias GetOrCreate(string schema, string table)
        {
            schema = schema.AddTSqlDelimiters();
            table = table.AddTSqlDelimiters();
            var fullyQualifiedTable = schema + "." + table;

            if (_tables.ContainsKey(fullyQualifiedTable))
            {
                return _tables[fullyQualifiedTable];
            }

            var newTable = new TableAlias(
                fullyQualifiedTable,
                GetUniqueAlias(table));

            _tables[fullyQualifiedTable] = newTable;

            return newTable;
        }

        private string GetUniqueAlias(string table)
        {
            var firstLetter = table[0] == '['
                ? table.Substring(1, 1)
                : table.Substring(0, 1);

            var number = _tableAliases.ContainsKey(firstLetter)
                ? ++_tableAliases[firstLetter]
                : _tableAliases[firstLetter] = 0;

            return (firstLetter + number).AddTSqlDelimiters();
        }
    }
}
