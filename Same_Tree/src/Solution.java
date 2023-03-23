public class Solution {
    public static boolean isSameTree(TreeNode p, TreeNode q) {
        if(p == null || q == null)
            return (p == q);
        return (p.val == q.val) && isSameTree(p.left , q.left) && isSameTree(p.right,q.right);
    }
}