namespace Assignment.BinaryTreeEquatable
{
    using Assignment.BTNInterfaces;

    public class Comparer : IComparer
    {
        public bool Compare(IBTN tree1, IBTN tree2)
        {
            return CompareLocal(tree1, tree2);
        }

        public static bool CompareLocal(IBTN tree1, IBTN tree2)
        {
            if (tree1 == null && tree2 == null)
            {
                return true;
            }

            if (tree1 != null && tree2 != null)
            {
                return tree1.Equals(tree2);
            }

            return false;
        }
    }
}