namespace myleetcode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class SearchInBinarySearchTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            while (root != null && root.val != val)
            {
                root = val < root.val ? root.left : root.right;
            }
            return root;
        }
    }

}