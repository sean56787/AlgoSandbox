using BST;

public class Program
{
    public static void Main(string[] args)
    {
        Tree tree = new Tree();
        int[] values = { 5, 3, 7, 2, 4, 6, 8 };

        foreach (var val in values)
            tree.Insert(val);

        tree.PreorderTravel();
        tree.InorderTravel();
        tree.PostderTravel();
    }
}