using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppБинарное_дерево16012022
{
    // программный интерфейс бинарного дерева
    internal class BinaryTree<T> where T: IComparable<T>
    {
        private Node<T> root = null;

        public void Add(T value)
        {
            if (root == null)
                root = new Node<T>(value);
            else
                root.Add(value);
        }
        // вывод всего дерева
        public void Display()
        {
            if (root != null)
                root.DisplayNode("");
            else
                Console.WriteLine("empty tree");
        }
    }
}
