using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreePostPreInOrder
{

	public class TreeNode
	{
		public int data;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int data)
		{
			this.data = data;
			this.left = null;
			this.right = null;
		}
	}
	public class BinarySearchTree
	{
		public TreeNode root;
		public BinarySearchTree()
		{
			this.root = null;
		}
		// Insert a node element
		public TreeNode addNode(TreeNode node, int data)
		{
			if (node != null)
			{
				if (node.data >= data)
				{
					// When new element is smaller or
					// equal to current node
					node.left = this.addNode(node.left, data);
				}
				else
				{
					// When new element is higher to current node
					node.right = this.addNode(node.right, data);
				}
				// important to manage root node
				return node;
			}
			else
			{
				return new TreeNode(data);
			}
		}
		// Display preorder
		public void preorder(TreeNode node)
		{
			if (node != null)
			{
				// Display node value
				Console.Write("  " + node.data);
				// Visit to left subtree
				this.preorder(node.left);
				// Visit to right subtree
				this.preorder(node.right);
			}
		}
		public void inorder(TreeNode node)
		{
			if (node != null)
			{
				// Visit to left subtree
				this.inorder(node.left);
				// Display node value
				Console.Write("  " + node.data);
				// Visit to right subtree
				this.inorder(node.right);
			}
		}
		public void postorder(TreeNode node)
		{
			if (node != null)
			{
				// Visit to left subtree
				this.postorder(node.left);
				// Visit to right subtree
				this.postorder(node.right);
				// Display node value
				Console.Write("  " + node.data);
			}
		}
	}
}
