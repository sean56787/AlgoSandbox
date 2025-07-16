using BST;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("          6\r\n        /   \\\r\n       3     9\r\n      / \\   / \\\r\n     2   5 8  11\r\n    /   /   \\  / \\\r\n   1   4     7 10 12\n\n");
        Tree tree = new Tree();
        int[] values = { 6, 3, 9, 2, 5, 8, 1, 4, 7, 11, 10, 12 };

        foreach (var val in values)
            tree.Insert(val);

        // 前中後序
        // tree.PreorderTravel();
        // tree.InorderTravel();
        // tree.PostderTravel();

        //插入、搜尋、刪除
        /*
        tree.InorderTravel();
        int target = 9;

        tree.Insert(target);
        tree.InorderTravel();

        bool find = tree.Search(target);
        if (find) Console.WriteLine($"{target} found");
        else Console.WriteLine($"{target} not found");

        tree.Delete(target);
        tree.InorderTravel();
        */

        // 最大深度
        // Console.WriteLine(tree.MaxDepth(tree.root));

        //LCA最小共同祖先
        Node? p = tree.Search(1);
        Node? q = tree.Search(4);

        Console.WriteLine($"LCA of {p} & {q}: " + tree.LCA(tree.root, p, q).value);
    }
}