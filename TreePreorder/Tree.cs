using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreePreorder
{
    public class Tree
    {
        public Node root=null;
        public class Node
        {
            public int Data;
            public Node Left;
            public Node Right;
        }

        public Node Insert(Node node, int Data)
        {
            if (node == null)
            {
                var newnode = new Node();
                newnode.Data = Data;
                newnode.Left = null;
                newnode.Right = null;               
                return newnode;

            }
            else
            {
                Node current = new Node();
                if (Data <= node.Data)
                {
                    current = Insert(node.Left, Data);
                    node.Left = current;

                }
                else
                {
                    current = Insert(node.Right, Data);
                    node.Right=current;
                }
                return node;

            }

        }
        
        public void Preorder(Node root)
        {
            var current = root;
            if (current==null)
                return;

            Console.Write(current.Data + " ");
            Preorder(current.Left);
            Preorder(current.Right);            

        }
    }
}
