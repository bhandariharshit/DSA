﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    class BTree
    {
        internal TreeNode rootNode;
        public BTree(int key)
        {
            rootNode = new TreeNode(key);
        }
        public BTree()
        {
            rootNode = null;
        }

        private void printPostorder(TreeNode node)
        {
            if (node == null)
                return;

            // first recur on left subtree 
            printPostorder(node.left);

            // then recur on right subtree 
            printPostorder(node.right);

            // now deal with the node 
            Console.Write(node.value + " ");
        }

        private void printPreOrder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.value + " ");

            printPreOrder(node.left);

            printPreOrder(node.right);

        }

        private void printInOrder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            printInOrder(node.left);
            Console.Write(node.value + " ");
            printInOrder(node.right);
        }

        internal void printPostorder()
        {
            printPostorder(rootNode);
        }

        internal void printPreOrder()
        {
            printPreOrder(rootNode);
        }

        internal void printInOrder()
        {
            printInOrder(rootNode);
        }

        public void InsertNodeBSTUsingQueue(int value)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(this.rootNode);

            TreeNode temp = null;

            while (queue.Count > 0)
            {
                temp = queue.Dequeue();

                if (value <= temp.value)
                {
                    if (temp.left == null)
                    {
                        temp.left = new TreeNode(value);
                        break;
                    }
                    else
                    {
                        queue.Enqueue(temp.left);
                    }
                }
                else if (value > temp.value)
                {
                    if (temp.right == null)
                    {
                        temp.right = new TreeNode(value);
                        break;
                    }
                    else
                    {
                        queue.Enqueue(temp.right);
                    }
                }
            }
        }

        public void InsertBSTNodeItertative(int value)
        {
            TreeNode previous = null;
            TreeNode current = rootNode;

            while(current != null)
            {
                previous = current;
                if(value <= current.value)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }

            if(value <= previous.left.value)
            {
                previous.left = new TreeNode(value);
            }
            else
            {
                previous.right = new TreeNode(value);
            }
        }

        public TreeNode InsertBSTNodeRecurcive(int value, TreeNode node)
        {
            if (node is null)
                return new TreeNode(value);

            if (value <= node.value)
            {
                node.left = InsertBSTNodeRecurcive(value, node.left);
            }
            else
                node.right = InsertBSTNodeRecurcive(value, node.right);

            return node;
        }

        public virtual int size(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return (size(node.left) + 1 + size(node.right));
            }
        }

        TreeNode node = null;

        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root is null)
            {
                return null;
            }

            if (val == root?.value)
            {
                return root;
            }
            else if (root.value > val)
            {
                return SearchBST(root.left, val);
            }
            else
            {
                return SearchBST(root.right, val);
            }
        }
    }
}
