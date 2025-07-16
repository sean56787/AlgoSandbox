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

        public bool Search(int value)
        {
            return Search(root, value);
        }
        private bool Search(Node? node, int value)
        {
            if (node == null) return false;
            if (value == node.value) return true;
            if (value < node.value) return Search(node.left, value);
            return Search(node.right, value);
        }

        public void Delete(int value)
        {
            root = Delete(root, value);
        }

        private Node? Delete(Node? node, int value)
        {
            if (node == null) return null;
            if (value < node.value)
                node.left = Delete(node.left, value);
            else if (value > node.value)
                node.right = Delete(node.right, value);
            else // 找到了
            {
                // 只有一邊的情況
                if (node.left == null) return node.right;
                if(node.right == null) return node.left;
                //兩邊都有子
                Node successor = FindMin(node.right); // 從右子樹找最小值來代替
                node.value = successor.value;
                node.right = Delete(node.right, successor.value);
            }

            return node;
        }

        private Node FindMin(Node node) //找到最小
        {
            while (node.left != null)
                node = node.left;

            return node;
        }
    }
}
