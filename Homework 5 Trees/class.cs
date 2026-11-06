using System;
using System.Collections.Generic;
using System.Text;

// ======================= CLASSES =======================
public class Node
{
    public int Value;
    public Node? Left;
    public Node? Right;
    public Node(int value) { Value = value; }
}
public class BinarySearchTree
{
    private Node? root;
    public Node? Root => root;
    public bool Insert(int value)
    {
        Node newNode = new Node(value);
        if (root == null) { root = newNode; return true; }
        Node temp = root;
        while (true)
        {
            if (newNode.Value == temp.Value) return false;
            if (newNode.Value < temp.Value)
            {
                if (temp.Left == null) { temp.Left = newNode; return true; }
                temp = temp.Left;
            }
            else
            {
                if (temp.Right == null) { temp.Right = newNode; return true; }
                temp = temp.Right;
            }
        }
    }
    public bool Contains(int value)
    {
        Node? temp = root;
        while (temp != null)
        {
            if (value < temp.Value) temp = temp.Left;
            else if (value > temp.Value) temp = temp.Right;
            else return true;
        }
        return false;
    }
    // TODO: return the smallest value in the tree. (You can assume the tree is not empty.)
    public int Min()
    {
        Node? temp = root;
        while (temp.Left != null)
        {
            temp = temp.Left;
        }
        return temp.Value;
    }
    // TODO: return the biggest value in the tree. (You can assume the tree is no empty.)
    public int Max()
    {
        Node? temp = root;
        while (temp.Right != null)
        {
            temp = temp.Right;
        }
        return temp.Value;
    }
    // TODO: return the depth of the node that holds "value".
    // The root has depth 0. If the value is not in the tree, return -1.
    // Hint: it works like Contains, but count the steps as you go down.
    public int Depth(int value)
    {
        Node? temp = root;
        int depth = 0;
        while (temp != null)
        {
            if (value == temp.Value)
            {
                return depth;
            }
            if (value < temp.Value)
            {
                temp = temp.Left;
            }
            else
            {
                temp = temp.Right;
            }
            depth++;
        }
        return -1;
    }
}






















/* ======================= WRITTEN ANSWERS (Questions 1 to 5)
=======================
Type your answers here. Draw trees with spaces and slashes, like the trees on
the
assignment page.
---- Question 1 ----
a) root: 50
b) leaves: 80,35,45,20qw
c) internal nodes: 50, 30, 40, 70.
d) parent of 35: 40 / sibling of 20: 40
e) depth of 35: 3 height of node 30: 2
f) height of tree: 3 size: 8
g) degree of 70: 1
h) valid BST? why: Yes, because for every node, all values in the left subtree are smaller and all values in the right subtree are larger.
---- Question 2 ---- (Yes / No)
                               Tree A                            Tree B                      Tree C
Full?                           yes                               yes                        yes
Perfect?                        no                                yes                        no
Complete?                       yes                               yes                        no
Reasons for each No:
---- Question 3 ----
a) tree:
b) height: 3 number of leaves: 5
c) Contains(32) visits: 41-20-29-32 returns: true
Contains(60) visits: 41-65-50 returns: false
---- Question 4 ----
a) tree:
height:4
b) nodes visited by Contains(50):5 Big O: O(n) acts like: Linked List
---- Question 5 ----
a) tree:
b) children of 70 (show math): left = 2(1) + 1 = 3, right = 2(1) + 2 = 3 / left = 40, right = 65
c) parent of 35 (show math):   [8-1/2] = 3.5 = 3 / parent = 40
d) why 65 is a leaf (show math): 65 has no children, so it is a leaf.
doiung the math 2(4)+1=9, 2(4)+2=10 either of these indixes exist on the array.
*/
