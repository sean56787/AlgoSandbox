using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Tree
    {
        public Node? root;
        public Tree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            root = Insert(root, value);
        }

        private Node Insert(Node? root, int value)
        {
            if (root == null) return new Node(value);

            if(value < root.value)
                root.left = Insert(root.left, value);
            else
                root.right = Insert(root.right, value);

            return root;
        }

        public void PreorderTravel()
        {
            Console.WriteLine("Preoder travel:");
            Preoder(root);
            Console.WriteLine();
        }
        private void Preoder(Node? node)
        {
            if (node == null) return;

            Console.Write(node.value + " ");
            Preoder(node.left);
            Preoder(node.right);
        }

        public void InorderTravel()
        {
            Console.WriteLine("Inorder travel:");
            Inoder(root);
            Console.WriteLine();
        }
        private void Inoder(Node? node)
        {
            if (node == null) return;

            Inoder(node.left);
            Console.Write(node.value + " ");
            Inoder(node.right);
        }

        public void PostderTravel()
        {
            Console.WriteLine("Postorder travel:");
            Postorder(root);
            Console.WriteLine();
        }
        private void Postorder(Node? node)
        {
            if (node == null) return;

            Postorder(node.left);
            Postorder(node.right);
            Console.Write(node.value + " ");
            
        }
    }
}
