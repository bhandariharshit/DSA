namespace DSA.Tree
{
    class TreeNode
    {
        internal int value;
        internal TreeNode left, right;
        public TreeNode(int val)
        {
            this.value = val;
            left = right = null;
        }
    }
}
