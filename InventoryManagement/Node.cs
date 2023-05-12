using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    public class Node
    {
        public int data;
        public string company;
        public Node next;

        public Node(int data,string company)
        {
            this.company = company;
            this.data = data;
        }
    }
   
}
