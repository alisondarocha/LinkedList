namespace LinkedList_Web.Models
{
    public class ListForm
    {
        public Node Head;
        public Node Tail;
  
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
            Node point1 = null;
            Node point2 = Head;
            Node point3;          

            while (point2 != null)
            {
                point3 = point2.Next;
                point2.Next = point1;
                point1 = point2;
                point2 = point3;
            }

            Tail = Head;
            Head = point1;
        }

        //Method responsible for counting the elements of the list
        public int Size()
        {
            Node point = Head;
            int count = 0;

            while (point != null)
            {
                point = point.Next;
                count += 1;
            }
                Console.WriteLine(count + " elementos na lista");
                return count;

        }

        //method responsible for fetching the elements of the list
        public dynamic Get(int node)
        {
            Node point = Head;
            int count = 0;

            if (count != node)
            {
                while (count != node)
                {
                    point = point.Next;
                    count += 1;
                }
                return point.Value;
            }
            else
                return Head.Value;
        }

        //Method responsible for removing elements from the list
        public void RemoveElement(dynamic element)
        {
            Node pointer = Head;
            Node previous = null;

            string elementString = Convert.ToString(element);
            string headValueString = Convert.ToString(Head.Value);

            if(Head == null)
                Console.WriteLine("Lista vazia!");
            else if(headValueString == elementString)
                Head = Head.Next;
            else
            {
                previous = Head;
                pointer = Head.Next;

                while (pointer != null)
                {  
                    string pointerValueString = Convert.ToString(pointer.Value);

                    if(pointerValueString == elementString)
                    {
                        previous.Next = pointer.Next;
                    }
                    previous = pointer;
                    pointer = pointer.Next;
                }
            }
        }
    }
}