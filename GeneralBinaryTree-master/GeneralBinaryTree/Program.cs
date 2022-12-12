using System;

namespace GeneralBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Node<int>(10);// ➞ 10 is the root of the tree(first node in the tree)
            root.Insert(5);// ➞ a new node is created and added to the Left node of `root`
            root.Insert(11);// ➞ a new node is created and added to the Right node of  `root`
            root.Insert(3);// ➞ a new node is created and added to the Left node of `5`
            root.Insert(6);// ➞ a new node is created and added to the Right node of `root`
            root.GetTreeData();// ➞ [3, 5, 6, 10, 11]
            //root.Data ➞ 10
            //root.Left.Data ➞ 5
            //root.Right.Data ➞ 11
        }
    }
}
