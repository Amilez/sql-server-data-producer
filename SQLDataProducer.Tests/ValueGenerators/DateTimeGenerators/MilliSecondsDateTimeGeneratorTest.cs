
using NUnit.Framework;
using MSTest = Microsoft.VisualStudio.TestTools.UnitTesting;
using SQLDataProducer.Entities.DatabaseEntities;
using SQLDataProducer.Entities.Generators.DateTimeGenerators;

namespace SQLDataProducer.Tests.ValueGenerators
{
    [TestFixture]
    [MSTest.TestClass]
    public class MilliSecondsDateTimeGeneratorTest
    {
        public MilliSecondsDateTimeGeneratorTest()
        {
        }

        [Test]
        [MSTest.TestMethod]
        public void ShouldGenerateValue()
        {
            var gen = new MilliSecondsDateTimeGenerator(new ColumnDataTypeDefinition("DateTime2(2)", false));
            var firstValue = gen.GenerateValue(1);
            Assert.That(firstValue, Is.Not.Null);
        }

        [Test]
        [MSTest.TestMethod]
        public void ShouldTestStep()
        {
            Assert.Fail("not implemented");
        }
        [Test]
        [MSTest.TestMethod]
        public void ShouldTestStartValue()
        {
            Assert.Fail("not implemented");
        }
        [Test]
        [MSTest.TestMethod]
        public void ShouldTestOverFlow()
        {
            Assert.Fail("not implemented");
        }
    }
}