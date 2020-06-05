using nikstra.SqlUtilities;
using NUnit.Framework;

namespace nikstra.SqlUtilitiesTests
{
    public class SqlBuilderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange
            var sb = new SqlBuilder();

            // Act
            var result = sb.Foo();

            // Assert
            Assert.That(result, Is.EqualTo(true));
        }
    }
}