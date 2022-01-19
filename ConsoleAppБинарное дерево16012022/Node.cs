using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppБинарное_дерево16012022
{
   internal class Node<T> where T:IComparable<T>
    {
        //поле обобщенного типа, которое хранит значение узла дерева
        public T Value { get; set; }

        //ссылки в дереве
        private Node<T> left = null;
        private Node<T> right = null;
       
        // Конструктор по умолчанию
        public Node()
        {
            Value=default;// это оператор который позволяет записать дефолтное значение для типа
            
        }

        public Node(T value)
        {
            Value = value;
        }
        public void Add(T value)
        {
            if (Value.CompareTo(value) < 0)// Value<value
            {
                // добавление нового узла в дерево узлов
                if (left == null)
                    left = new Node<T>(value);// создаем новый узел слева
                else
                    left.Add(value);
            }else
            { //Value>=value
                // пойдем в правое поддерево
                if (right == null)
                    right = new Node<T>(value);
                else
                    right.Add(value);
            }
        }
            // рекурсивный вывод дерева на экран
        public void DisplayNode(string offset)
        {
            //вывод смещения
            Console.WriteLine(offset);
            // вывод самого узла
            Console.WriteLine("(" + ToString());
            // работа с правым поддеревом
            if (right != null)
                right.DisplayNode(offset + '\t');
            else
                Console.WriteLine(offset + "(null");
            // работа с левым поддеревом
            if (left != null)
                left.DisplayNode(offset + '\t');
            else
                Console.WriteLine(offset + "(null)");

            // перенос строки
            Console.WriteLine($"\n{offset})");
        }

        // получение строки узла дерева
        public override string ToString()
        {
            if(Value !=null)
            return Value.ToString();
            return null;
        }
    }
}
