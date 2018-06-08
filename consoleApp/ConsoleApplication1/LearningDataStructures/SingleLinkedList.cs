using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDataStructures
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void InsertNewNode(int info)
        {
            Node temp = new Node(info);

            if (start == null)
            {
                start = temp;
            }
            else
            {
                Node p = start;
                while(p.link !=null)
                {
                    p = p.link;
                }
                if (p.link == null)
                    p.link = temp;
            }
        }

        public void InsertNodeAtBegining(int info)
        {
            Node temp = new Node(info);
            if (start != null)
            {
                temp.link = start;
                start = temp;
            }            
        }

        public void insertNodeAtEnd(int info)
        {
            Node temp = new Node(info);
            Node p = start;
            while (p.link != null)
            {
                p = p.link;
            }
            p.link = temp;
        }

        public void insertAtNthPosition(int info, int k)
        {
            Node temp = new Node(info);
            Node p = start;
            for (int i = 1; i<k && p.link!= null; i++)
            {
                p = p.link;  
            }

            temp.link = p.link;
            p.link = temp ;
                    
        }

        public void ReverseList()
        {
            Node prev = null;
            Node p = null;
            Node next = null;
            p = start;
            while (p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }
            start = prev;
        }

        public void DisplayList()
        {
            Node p; 

            if(start == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }

            p = start;

            Console.Write("List Is :");

            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }

        public void CountNode()
        {
            int n = 0;
            Node p = start;

            while (p !=null)
            {
                n++;
                p = p.link;
            }

            Console.WriteLine("Number of the nodes in the List are: " + n);
        }

        public void Search(int x)
        {
            int position = 1;

            Node p = start;

            while (p != null)
            {
                if (p.info == x)
                {
                  break;
                }
                position++;
                p = p.link;
            }

            if(p == null)
            {
                Console.WriteLine("The Element is not found in the list.");
            }
            else
            {
                Console.WriteLine("Element Found at " + position + " position in the list");
            }

        }
    }
}
