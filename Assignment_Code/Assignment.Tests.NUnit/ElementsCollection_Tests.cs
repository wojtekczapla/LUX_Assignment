using Assignment.ElementsCollection;
using Assignment.ElementsCollection.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Assignment.Tests.NUnit
{
    [TestFixture]
    public class ElementsCollection_Tests
    {
        ICollection<IElement> collection = null;

        [SetUp]
        public void Setup()
        {
            collection = new Collection<IElement>();
        }

        [Test]
        public void Test_IfNullCollectionEmptyResult()
        {
            // Arrange
            collection = null;

            //Act
            var result = ElementsCollectionSelector.GetElementsUniqueByNumAndAgeMoreThanTwenty(collection);

            // Assert
            Assert.IsTrue(result == null);
        }

        [Test]
        public void Test_IfElementsUniqueByNumAndAgeMoreThanTwentyTrue()
        {
            // Arrange
            IElement element1 = new Element();
            element1.InitElement(2, "Element1", 27);
            collection.Add(element1);

            IElement element2 = new Element();
            element2.InitElement(2, "Element2", 27);
            collection.Add(element2);

            IElement element3 = new Element();
            element1.InitElement(3, "Element3", 19);
            collection.Add(element3);

            IElement element4 = new Element();
            element4.InitElement(4, "Element4", 27);
            collection.Add(element4);

            //Act
            var result = ElementsCollectionSelector.GetElementsUniqueByNumAndAgeMoreThanTwenty(collection);

            // Assert
            Assert.IsTrue(result.Count == 2);
        }
    }
}
