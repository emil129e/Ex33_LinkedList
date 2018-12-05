using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public class MyLinkedList
    {
        private class Node
        {
            public Node Next { get; set; }
            public object Data { get; set; }
            public Node(object objekt)
            {
                Next = (Node)Data;
                Data = objekt;
            }
        }
        private Node Head { get; set; }

        
        public int Count { get; set; }

        public void Insert(object objekt)
        { 
            if (Head == null)
            {
                Node node = new Node(objekt);
                Head = node;
            }
            else
            {
                Node newNode = new Node(objekt);
                newNode.Next = Head;
                Head = newNode;
            }
            Count++;
        }
        public void Insert(object objekt, int index) { }
        public void Delete()
        {

        }
        public void Delete(int index){ }
        public object ItemAt(int index)
        {
            return null;
        }
        public override string ToString()
        {
                     
            string toString = $"{Head.Data.ToString()}\n";
           

            while (Head.Next != null)
            {
                toString = toString + $"{Head.Next.Data.ToString()}\n";
                Head = Head.Next;
            }


            return toString;

            /* 
                         string toString = $"{Head.Data.ToString()}\n";
            Node current = Head;

            while (current.Next != null)
            {
               toString = toString + $"{current.Next.Data.ToString()}\n";
                current = current.Next;
            }


            return toString;
             */
        }
    }
}

//public void Delete()
//{
//    if (Head == null)
//    {
//    }
//    else
//    {
//        Head = Head.Next;
//    }
//    Count--;
//}

//public object ItemAt(int index)
//{
//    Node ItemAt = Head;

//    for (int i = 0; i < index; i++)
//    {
//        ItemAt = ItemAt.Next;
//    }


//    return ItemAt.Data;
//}