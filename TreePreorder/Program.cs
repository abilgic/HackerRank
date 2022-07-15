using TreePreorder;
using static TreePreorder.Tree;

Tree binaryTree = new Tree();
binaryTree.root = null;
binaryTree.root  = binaryTree.Insert(binaryTree.root, 1);
binaryTree.root= binaryTree.Insert(binaryTree.root,2);
binaryTree.root= binaryTree.Insert(binaryTree.root, 5);
binaryTree.root= binaryTree.Insert(binaryTree.root, 3);
binaryTree.root= binaryTree.Insert(binaryTree.root, 6);
binaryTree.root= binaryTree.Insert(binaryTree.root, 4);
binaryTree.Preorder(binaryTree.root);