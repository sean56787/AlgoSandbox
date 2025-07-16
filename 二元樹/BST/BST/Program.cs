using BST;

public class Program
{
    public static void Main(string[] args)
    {
        Tree tree = new Tree();
        int[] values = { 5, 3, 7, 2, 4, 6, 8 };

        foreach (var val in values)
            tree.Insert(val);

        // tree.PreorderTravel();
        // tree.InorderTravel();
        // tree.PostderTravel();
        tree.InorderTravel();
        int target = 9;

        tree.Insert(target);
        tree.InorderTravel();

        bool find = tree.Search(target);
        if (find) Console.WriteLine($"{target} found");
        else Console.WriteLine($"{target} not found");

        tree.Delete(target);
        tree.InorderTravel();
    }
}