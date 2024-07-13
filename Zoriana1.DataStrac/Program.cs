using System;
using System.Collections;
using System.Collections.Generic;
using DataStructures.Library;
using DataStructures.Library.Interfaces;

namespace DataStructures.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestList();
            TestBinarySearchTree();
            TestSinglyLinkedList();
            TestQueue();
            TestStack();
        }

        static void TestList()
        {
            IList list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(1, 1.5);
            list.Remove(2);
            list.Reverse();

            Console.WriteLine("List:");
            foreach (var item in list.ToArray())
            {
                Console.WriteLine(item);
            }
        }

        static void TestBinarySearchTree()
        {
            var bst = new BinarySearchTree();
            bst.Add(5);
            bst.Add(3);
            bst.Add(7);
            bst.Add(2);
            bst.Add(4);
            bst.Add(6);
            bst.Add(8);

            Console.WriteLine("Binary Search Tree:");
            Console.WriteLine("Contains 4: " + bst.Contains(4));
            Console.WriteLine("Contains 9: " + bst.Contains(9));

            foreach (var item in bst.ToArray())
            {
                Console.WriteLine(item);
            }
        }

        static void TestSinglyLinkedList()
        {
            ISinglyLinkedList sll = new SinglyLinkedList();
            sll.Add("first");
            sll.Add("second");
            sll.Add("third");

            Console.WriteLine("Singly Linked List:");
            foreach (var item in sll.ToArray())
            {
                Console.WriteLine(item);
            }
        }

        static void TestQueue()
        {
            IQueue queue = new Queue();
            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");
            Console.WriteLine("Queue Peek: " + queue.Peek());

            Console.WriteLine("Queue:");
            foreach (var item in queue.ToArray())
            {
                Console.WriteLine(item);
            }
        }

        static void TestStack()
        {
            IStack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Stack Peek: " + stack.Peek());

            Console.WriteLine("Stack:");
            foreach (var item in stack.ToArray())
            {
                Console.WriteLine(item);
            }
        }
    }
}