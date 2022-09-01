using System;

namespace LinkedList.Code
{
    public class ListForm //Class responsible for creating the list, and for all usability
    {   
        public Node? Head;
        public Node? Tail;

        //method responsible for instantiating the nodes and adding an element to the list
        public dynamic AddValue(dynamic value)
        {
            var newNode = new Node();
            newNode.Value = value;

            if (Head == null)
                Head = newNode; 
            else
                Tail.Next = newNode;

            Tail = newNode;
            return value;
        }

        //Method responsible for printing the list
        public void Print()
        {
            if (Head != null)
            {
                Node print = Head;
                while (print != null)
                {
                    Console.WriteLine(print.Value);
                    print = print.Next;   
                }
            }
        }
        //Method responsible for inverting the elements of the list
        public void InvertList()
        {
            Node point1;
            Node point2;
            Node point3;

            point1 = null;
            point2 = Head;

            while(point2 != null)
            {
                point3 = point2.Next;
                point2.Next = point1;
                point1 = point2;
                point2 = point3;
            }

            Tail = Head;
            Head = point1;
        }
        //method responsible for fetching the elements of the list
        public dynamic Get(int node)
        {
            Node point;
            point = Head;
            int count = 0;

            if(count != node)
            {
                while(count != node)
                {
                    point = point.Next;
                    count += 1;
                }
                return point.Value;
            }
            else
                return Head.Value;
        }
    }
}   