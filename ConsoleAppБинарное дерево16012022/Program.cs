using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppБинарное_дерево16012022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //for (int i = 0; i < 10; i++)
            //    tree.Add(i);

            //tree.Display();

            Random random = new Random();
            for (int i = 0; i < 10; i++)
               tree.Add(random.Next(0, 50));
            tree.Display();
            Console.ReadLine();

            //Node<int> node = new Node<int>();

            //node.Add(3);
            //node.Add(5);
            //Console.WriteLine(node);

            //public void Display


        }
    }
}
