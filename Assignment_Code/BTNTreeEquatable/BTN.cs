namespace Assignment.BinaryTreeEquatable
{
    using Assignment.BTNInterfaces;
    using System;

    public class BTN : IBTN, IEquatable<IBTN>
    {
        private int val;
        private IBTN left;
        private IBTN right;

        public int Val { get => val; }
        public IBTN Left { get => left; }
        public IBTN Right { get => right; }

        public void InitializeNode(int value, IBTN leftNode, IBTN rightNode)
        {
            this.val = value;
            this.left = leftNode;
            this.right = rightNode;
        }

        public bool Equals(IBTN other)
        {
            return (this.Val == other.Val) &&
                ((this.Left == null && other.Left == null) || this.Left.Equals(other.Left)) &&
                ((this.Right == null && other.Right == null) || this.Right.Equals(other.Right));
        }

        public override bool Equals(object other)
        {
            if (other is IBTN)
                return this.Equals((IBTN)other);
            else
                return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                // Choose large primes to avoid hashing collisions
                const int HashingBase = (int)2166136261;
                const int HashingMultiplier = 16777619;

                int hash = HashingBase;
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, this.Val) ? this.Val.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, this.Left) ? this.Left.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, this.Right) ? this.right.GetHashCode() : 0);
                return hash;
            }
        }
    }
}