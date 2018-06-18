using Assignment.BinaryTreeEquatable;
using NUnit.Framework;

namespace Assignment.Tests.NUnit
{
    [TestFixture]
    public class BinaryTreeEquatable_Tests : BinaryTreeBase_Tests
    {
        [SetUp]
        public void Setup()
        {
            binaryTreeOne = new BTN();
            binaryTreeTwo = new BTN();
            btnChildLeft = new BTN();
            btnChildRight = new BTN();
            comparer = new Comparer();
        }

        [Test]
        public void Test_ThatEquatableAddLeftNodeWillSuccess()
        {
            // Arrange
            // Act
            var result = base.Test_ThatAddLeftNodeWillSuccess();

            // Assert
            Assert.IsTrue(result.Left != null);
        }

        [Test]
        public void Test_ThatEquatableAddRightNodeWillSuccess()
        {
            // Arrange
            // Act
            var result = base.Test_ThatAddRightNodeWillSuccess();

            // Assert
            Assert.IsTrue(result.Right != null);
        }

        [Test]
        public void Test_ThatEquatableComparingTwoNullTreesEqual()
        {
            // Arrange
            // Act
            var result = base.Test_ThatComparingTwoNullTreesEqual();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_ThatEquatableComparingTwoIdenticalTreesEqual()
        {
            // Arrange
            // Act
            var result = base.Test_ThatComparingTwoIdenticalTreesEqual();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_ThatEquatableComparingTwoDifferentTreesDifferent()
        {
            // Arrange
            // Act
            var result = base.Test_ThatComparingTwoDifferentTreesDifferent();

            // Assert
            Assert.IsFalse(result);
        }
    }
}
