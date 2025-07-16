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

        public Node? Search(int value)
        {
            return Search(root, value);
        }
        private Node? Search(Node? node, int value)
        {
            if (node == null) return null;
            if (value == node.value) return node;
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

        public int MaxDepth(Node? node)
        {
            if (node == null) return 0;

            int leftDepth = MaxDepth(node.left);
            int rightDepth = MaxDepth(node.right);

            return Math.Max(leftDepth, rightDepth) + 1;
        }

        public Node? LCA(Node? node, Node p, Node q)
        {
            // 命中節點直接回傳
            if(node == null || node == p || node == q)
            {
                return node;
            }

            var left = LCA(node.left, p, q);//下一層如果命中 這個left就當祖先
            var right = LCA(node.right, p, q); //下一層如果命中 這個node就當祖先

            //兩邊都命中
            if (left != null && right != null) 
            {
                return node;
            }

            return left ?? right;
        }
    }
}
