using System;

namespace Lowest_Common_Ancestor_of_a_Binary_Tree
{
  class Program
  {
    https://www.youtube.com/watch?v=13m9ZCB8gjw
    static void Main(string[] args)
    {
      TreeNode root = new TreeNode(3)
      {
        left = new TreeNode(5)
      };
      root.left.left = new TreeNode(6);
      root.left.right = new TreeNode(2)
      {
        left = new TreeNode(7),
        right = new TreeNode(4)
      };

      root.right = new TreeNode(1)
      {
        left = new TreeNode(0),
        right = new TreeNode(8)
      };

      Program p = new Program();
      var result = p.LowestCommonAncestor(root, new TreeNode(2), new TreeNode(0));
      Console.WriteLine(result.val);
    }

    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; left = right = null; }
    }
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
      if (root == null || root.val == p.val || root.val == q.val) return root;
      var left = LowestCommonAncestor(root.left, p, q);
      var right = LowestCommonAncestor(root.right, p, q);
      if (left == null && right == null) return null;
      if (left != null && right != null) return root;
      return left ?? right;
    }
  }
}
