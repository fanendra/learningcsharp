using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            list.InsertNewNode(1);
            list.InsertNewNode(2);
            list.InsertNewNode(3);
            list.InsertNewNode(4);
            list.InsertNewNode(5);
            list.InsertNewNode(6);
            list.InsertNewNode(7);
            list.DisplayList();
            //list.CountNode();
            //list.Search(10);
            list.InsertNodeAtBegining(11);
            list.DisplayList();

            list.insertNodeAtEnd(12);
            list.DisplayList();


            list.insertAtNthPosition(13,5);
            list.DisplayList();

            list.ReverseList();
            list.DisplayList();
            Console.Read();
        }
    }
}
