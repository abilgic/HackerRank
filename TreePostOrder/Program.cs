using TreePostOrder;


var tree = new BinarySearchTree();
/*
		 10
		/ \
	   /   \
	  4     15
	 / \   /
	3   5 12
	-------------
	Build binary search tree
*/
tree.root = tree.addNode(tree.root, 10);
tree.addNode(tree.root, 4);
tree.addNode(tree.root, 3);
tree.addNode(tree.root, 5);
tree.addNode(tree.root, 15);
tree.addNode(tree.root, 12);
// Display tree nodes
Console.WriteLine("Preorder ");
tree.preorder(tree.root);
Console.WriteLine("\nInorder ");
tree.inorder(tree.root);
Console.WriteLine("\nPostorder ");
tree.postorder(tree.root);

