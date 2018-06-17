using Assignment.BinaryTreeRecursive;
using Assignment.BTNInterfaces;
using NUnit.Framework;

namespace Assignment.Tests.NUnit
{
    [TestFixture]
    public class BinaryTreeRecursive_Tests
    {
        IBTN binaryTreeOne = null;
        IBTN binaryTreeTwo = null;
        IBTN btnChildLeft = null;
        IBTN btnChildRight = null;
        IComparer comparer = null;

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
        public void Test_ThatAddLeftNodeWillSuccess()
        {
            // Arrange
            btnChildLeft.InitializeNode(1, null, null);
            binaryTreeOne = new BTN();

            //Act
            binaryTreeOne.InitializeNode(2, btnChildLeft, null);

            // Assert
            Assert.IsTrue(binaryTreeOne.Left != null);
        }

        [Test]
        public void Test_ThatAddRightNodeWillSuccess()
        {
            // Arrange
            btnChildRight.InitializeNode(3, null, null);
            binaryTreeOne = new BTN();

            //Act
            binaryTreeOne.InitializeNode(2, null, btnChildRight);

            // Assert
            Assert.IsTrue(binaryTreeOne.Right != null);
        }

        [Test]
        public void Test_ThatComparingTwoNullTreesEqual()
        {
            // Arrange

            //Act
            var result = comparer.Compare(binaryTreeOne, binaryTreeTwo);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_ThatComparingTwoIdenticalTreesEqual()
        {
            // Arrange
            btnChildLeft.InitializeNode(1, null, null);
            btnChildRight.InitializeNode(3, null, null);

            binaryTreeOne = new BTN();
            binaryTreeOne.InitializeNode(2, btnChildLeft, btnChildRight);

            //Act
            var result = comparer.Compare(binaryTreeOne, binaryTreeOne);


            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_ThatComparingTwoDifferentTreesDifferent()
        {
            // Arrange
            btnChildLeft.InitializeNode(1, null, null);
            btnChildRight.InitializeNode(3, null, null);

            binaryTreeOne.InitializeNode(2, btnChildLeft, btnChildRight);

            binaryTreeTwo.InitializeNode(2, btnChildRight, btnChildLeft);

            //Act
            var result = comparer.Compare(binaryTreeOne, binaryTreeTwo);


            // Assert
            Assert.IsFalse(result);
        }
    }
}
