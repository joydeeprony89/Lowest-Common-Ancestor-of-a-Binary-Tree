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
      // if root is null or if any of the p or q value same as root, return the root
      // Why ? because root is the common ancestor of any node, and when we had asked root and another node LCA in that case definetly root would be the LCA as an answer.
      if (root == null || p.val == root.val || q.val == root.val) return root;
      // Search the left subtree, as both the nodes can be found in left side.
      var left = LowestCommonAncestor(root.left, p, q);
      // Search the right subtree, as both the nodes can be found in right side.
      var right = LowestCommonAncestor(root.right, p, q);

      // When we have found both the left common ancestor and right common ancestor, then the answer is root
      if (left != null && right != null) return root;
      // When any one of is null the answer would be another not null node
      return left == null ? right : left;
    }
  }
}
