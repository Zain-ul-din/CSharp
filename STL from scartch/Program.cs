using System;
using System.Collections;
using System.Collections.Generic;

class Program{
    public static void Main(){
        DLinkedList<int> dLinkedList = new DLinkedList<int>();
        dLinkedList.Push(1);
        dLinkedList.Push(2);
        dLinkedList.Push(3);
        dLinkedList.Push(4);
        dLinkedList.Push(5);
        dLinkedList.Push(6);
        dLinkedList.Push_After(
           dLinkedList.GetElement(4),90
        );

        dLinkedList.Display();
    }
}

    class Node<T> where T : IComparable
    {
        public T data;
        public Node<T> prev, next;
    }

    class DLinkedList<T> where T : IComparable{
        private Node<T> head, tail;

        public DLinkedList() {
            head = null;
            tail = null;
        }

        public void Push(T data)
        {
            Node<T> newNode = new Node<T> { data = data };

            newNode.prev = null;
            newNode.next = null;

            if (head == null && tail == null)
            {
                head = newNode;
                tail = newNode;
                return;
            }

            newNode.next = head;
            head.prev = newNode;
            head = newNode;
            return;
        }

        public void Push_Back(T data)
        {
            Node<T> newNode = new Node<T>() { data = data };

            newNode.next = null;
            newNode.prev = null;

            if (head == null && tail == null)
            {
                head = newNode;
                tail = newNode;
                return;
            }

            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
            return;
        }

        public Node<T> GetElement(T element)
        {
            if (head == null && tail == null) return null;
            Node<T> itrNode = head;
            while (itrNode != null)
            {
                if (itrNode.data.CompareTo(element)) return itrNode;
                itrNode = itrNode.next;
            }
            return null;
        }

        public void Push_After(Node<T> node, T data)
        {
            Node<T> newNode = new Node<T> { data = data };
            newNode.next = node.next;
            node.next = newNode;
            newNode.prev = node;
            newNode.prev.next = node;
        }

        public void Display(){
            if(head == null) return;
            Node<T> itr = head;
            while(itr != null){
                Console.WriteLine(" " + itr.data + " ");
                itr = itr.next;
            }
            return;
        }

        ~DLinkedList()
        {
            head = null;
            tail = null;
        }
    }
