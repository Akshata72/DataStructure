namespace LinkedList
{
    class program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node node_1 = new Node(22);
            Node node_2 = new Node(23);
            Node node_3 = new Node(24);
           
            linkedList.AddNode(node_1);
            linkedList.AddNode(node_2);
            linkedList.AddNode(node_3);
            linkedList.Display();

            Console.WriteLine("\nEnter a number to Append");
            int data = int.Parse(Console.ReadLine());
            linkedList.AppendNode(data);
            linkedList.Display();

            Console.WriteLine("\nEnter a Number to AddStart");
            int First = int.Parse(Console.ReadLine());
            linkedList.AddNodeAtStart(First);
            linkedList.Display();

            linkedList.DeleteFirstNode();
            linkedList.Display();
        }
    }
}