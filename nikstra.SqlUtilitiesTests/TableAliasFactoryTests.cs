using nikstra.SqlUtilities;
using NUnit.Framework;

namespace nikstra.SqlUtilitiesTests
{
    [TestFixture]
    public class TableAliasFactoryTests
    {
        [Test]
        public void GetOrCreate_Creates_AnInstanceOfATableAlias()
        {
            // Arrange
            var tableAliasFactory = new TableAliasFactory();

            // Act
            var result = tableAliasFactory.GetOrCreate("tablename");

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void GetOrCreate_Creates_AnInstanceOfATableAliasWithTheGivenTableName()
        {
            // Arrange
            var tableAliasFactory = new TableAliasFactory();
            var tableName = "tablename";

            // Act
            var result = tableAliasFactory.GetOrCreate(tableName);

            // Assert
            var expected = "[dbo].[" + tableName + "]";
            Assert.That(result.Name, Is.EqualTo(expected));
        }

        [Test]
        public void GetOrCreate_Creates_AnInstanceOfATableAliasWithTheGivenTableNameAndSchema()
        {
            // Arrange
            var tableAliasFactory = new TableAliasFactory();
            var schemaName = "schemaName";
            var tableName = "tablename";

            // Act
            var result = tableAliasFactory.GetOrCreate(schemaName, tableName);

            // Assert
            var expected = "[" + schemaName + "].[" + tableName + "]";
            Assert.That(result.Name, Is.EqualTo(expected));
        }

        [TestCase("tablename", ExpectedResult = "[t0]")]
        [TestCase("tablename2", ExpectedResult = "[t0]")]
        [TestCase("anothertable", ExpectedResult = "[a0]")]
        public string GetOrCreate_Creates_AnInstanceOfATableAliasWithAGeneratedAlias(string tableName)
        {
            // Arrange
            var tableAliasFactory = new TableAliasFactory();

            // Act
            var result = tableAliasFactory.GetOrCreate(tableName);

            // Assert
            return result.Alias;
        }

        [TestCase("table1", "table2", "table3")]
        [TestCase("string1", "string2", "string3")]
        public void GetOrCreate_Creates_AnInstanceOfATableAliasWithAGeneratedUniqueAliases(
            string name1,
            string name2,
            string name3)
        {
            // Arrange
            var tableAliasFactory = new TableAliasFactory();

            // Act
            var result1 = tableAliasFactory.GetOrCreate(name1);
            var result2 = tableAliasFactory.GetOrCreate(name2);
            var result3 = tableAliasFactory.GetOrCreate(name3);

            // Assert
            Assert.That(result1.Alias, Is.Not.EqualTo(result2.Alias));
            Assert.That(result1.Alias, Is.Not.EqualTo(result3.Alias));
            Assert.That(result2.Alias, Is.Not.EqualTo(result3.Alias));
        }

        [TestCase("table", "table", "table")]
        [TestCase("string", "string", "string")]
        public void GetOrCreate_Creates_AnInstanceOfATableAliasWithAGeneratedAliasesThatAreEqualForTheSameName(
            string name1,
            string name2,
            string name3)
        {
            // Arrange
            var tableAliasFactory = new TableAliasFactory();

            // Act
            var result1 = tableAliasFactory.GetOrCreate(name1);
            var result2 = tableAliasFactory.GetOrCreate(name2);
            var result3 = tableAliasFactory.GetOrCreate(name3);

            // Assert
            Assert.That(result1.Alias, Is.EqualTo(result2.Alias));
            Assert.That(result1.Alias, Is.EqualTo(result3.Alias));
            Assert.That(result2.Alias, Is.EqualTo(result3.Alias));
        }
    }
}
