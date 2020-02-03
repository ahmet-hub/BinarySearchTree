using System;
using System.Collections.Generic;
using System.Text;

namespace AvlTree
{
    public class Node
    {
        private int data;
        Node leftNode;
        Node rightNode;
        int height;
        public Node(int data)
        {
            this.data = data;
        }
        public int getData()
        {
            return data;
        }
        public void setData(int data)
        {
            this.data = data;
        }
        public Node getLeftNode()
        {
            return leftNode;
        }
        public void setLeftNode(Node node)
        {
            leftNode = node;
        }
        public Node getRightNode()
        {
            return rightNode;
        }
        public void setRightNode(Node node)
        {
            rightNode = node;
        }
        public int getHeight()
        {
            return height;
        }
        public void setHeight(int height)
        {
            this.height = height;
        }
    }
}
