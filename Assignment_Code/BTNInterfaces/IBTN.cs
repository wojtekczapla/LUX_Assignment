namespace Assignment.BTNInterfaces
{
    public interface IBTN
    {
        int Val { get; }

        IBTN Left { get; }

        IBTN Right { get; }

        void InitializeNode(int value, IBTN leftNode, IBTN rightNode);
    }
}
