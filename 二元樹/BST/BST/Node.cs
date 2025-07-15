using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Node
    {
        public int value;
        public string? name;
        public Node? left;
        public Node? right;
        public Node(int value = 999, string? name = null, Node? left = null, Node? right = null)
        {
            this.value = value;
            this.name = name;
            this.left = left;
            this.right = right;
        }
    }
}
