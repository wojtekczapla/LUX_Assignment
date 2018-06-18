namespace Assignment.BinaryTreeRecursive
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
                return tree1.Val == tree2.Val &&
                    CompareLocal(tree1.Left, tree2.Left) &&
                    CompareLocal(tree1.Right, tree2.Right);
            }

            return false;
        }
    }
}
