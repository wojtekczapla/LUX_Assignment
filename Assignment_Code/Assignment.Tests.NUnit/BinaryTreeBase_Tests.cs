namespace Assignment.Tests.NUnit
{
    using Assignment.BTNInterfaces;

    public class BinaryTreeBase_Tests
    {
        public IBTN binaryTreeOne = null;
        public IBTN binaryTreeTwo = null;
        public IBTN btnChildLeft = null;
        public IBTN btnChildRight = null;
        public IComparer comparer = null;

        public IBTN Test_ThatAddLeftNodeWillSuccess()
        {
            // Arrange
            btnChildLeft.InitializeNode(1, null, null);

            //Act
            binaryTreeOne.InitializeNode(2, btnChildLeft, null);

            return binaryTreeOne;
        }

        public IBTN Test_ThatAddRightNodeWillSuccess()
        {
            // Arrange
            btnChildRight.InitializeNode(3, null, null);

            //Act
            binaryTreeOne.InitializeNode(2, null, btnChildRight);

            return binaryTreeOne;
        }

        public bool Test_ThatComparingTwoNullTreesEqual()
        {
            // Arrange

            //Act
            var result = comparer.Compare(binaryTreeOne, binaryTreeTwo);

            return result;
        }

        public bool Test_ThatComparingTwoIdenticalTreesEqual()
        {
            // Arrange
            btnChildLeft.InitializeNode(1, null, null);
            btnChildRight.InitializeNode(3, null, null);

            binaryTreeOne.InitializeNode(2, btnChildLeft, btnChildRight);

            //Act
            var result = comparer.Compare(binaryTreeOne, binaryTreeOne);

            return result;
        }

        public bool Test_ThatComparingTwoDifferentTreesDifferent()
        {
            // Arrange
            btnChildLeft.InitializeNode(1, null, null);
            btnChildRight.InitializeNode(3, null, null);

            binaryTreeOne.InitializeNode(2, btnChildLeft, btnChildRight);

            binaryTreeTwo.InitializeNode(2, btnChildRight, btnChildLeft);

            //Act
            var result = comparer.Compare(binaryTreeOne, binaryTreeTwo);

            return result;
        }

    }
}
