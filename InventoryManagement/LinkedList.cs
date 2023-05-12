using System;
namespace InventoryManagement
{
    class LinkedList
    {
        public Node head;
        
        public void Add(int data,string company)
        {
            Node node = new Node(data,company);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Company shares added ",node.company);
        }
       public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Company has no Shares");
                return;
            }
            while (temp != null) 
            {
                Console.WriteLine("{0} Shares and Name of Company {1} ", temp.data, temp.company);
                temp = temp.next;
            }

        }
    }
}
