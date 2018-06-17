namespace Assignment.BinaryTreeRecursive
{
    using Assignment.BTNInterfaces;

    public class BTN : IBTN
    {
        private int val;
        private IBTN left;
        private IBTN right;

        public int Val => val;
        public IBTN Left => left;
        public IBTN Right => right;

        public void InitializeNode(int value, IBTN leftNode, IBTN rightNode)
        {
            this.val = value;
            this.left = leftNode;
            this.right = rightNode;
        }
    }
}