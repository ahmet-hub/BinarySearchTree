using System;
using System.Collections.Generic;
using System.Text;

namespace AvlTree
{
    public class AvlTree : Tree
    {
        private Node root;

        public void Insert(int data)
        {
            root = Insert( root, data);
        }

        private Node Insert(Node node, int data)
        {
            if (node == null) return new Node(data);
            if (data < node.getData())
            {
                node.setLeftNode(Insert(node.getLeftNode(), data));
            }
            else
            {
                node.setRightNode(Insert(node.getRightNode(), data));
            }

            node = settleViolation(data, node);

            node.setHeight(Math.Max(height(node.getLeftNode()), height(node.getRightNode())) + 1);

            return null;
        }

        private int height(Node node)
        {
            if (node == null) return -1;
            return node.getHeight();
        }

        private Node settleViolation(int data, Node node)
        {
            int balance = getBalance(node);
            if (balance > 1 && data < node.getLeftNode().getData()) //left - left
            {
                return rightRotation(node);
            }

            if (balance < -1 && data > node.getLeftNode().getData()) //right - right
            {
                return leftRotation(node);
            }
            if (balance > 1 && data > node.getLeftNode().getData())
            {
                node.setLeftNode(leftRotation(node.getLeftNode())); //right-left
                return rightRotation(node);
            }
            if (balance < -1 && data < node.getRightNode().getData())
            {
                node.setRightNode(rightRotation(node.getRightNode())); //left-right
                return leftRotation(node);
            }

            return node;

        }

        private Node leftRotation(Node node)
        {
            
        }

        private Node rightRotation(Node node)
        {
            throw new NotImplementedException();
        }

        private int getBalance(Node node)
        {
            if (node == null) return 0;
            return height(node.getLeftNode()) - height(node.getRightNode());
        }

        public void Traverse()
        {
            if (root == null) return;
            inOrderTraverse(root);
        }

        private void inOrderTraverse(Node node)
        {
            if (node.getLeftNode() != null)
            {
                inOrderTraverse(node.getLeftNode());
            }
            Console.Write(node);
            if (node.getRightNode() != null)
            {
                inOrderTraverse(node.getRightNode());
            }
        }
    }
}
