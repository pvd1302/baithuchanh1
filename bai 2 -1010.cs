using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_1010
{
    public class Stack<T>
    {
        private int n;
        private int top;
        public T[] a;
        public int Top
        {
            get { return top; }
            set { top = value; }
        }
        public Stack(int n)
        {
            top = -1;
            this.n = n;
            a = new T[n];
        }
        public bool isEmpty()
        {
            return top == -1;
        }
        public bool isFull()
        {
            return top == n - 1;
        }
        public void Push(T pt)
        {
            if (!isFull())
            {
                top = top + 1;
                a[top] = pt;
            }
            else
            {
                Console.WriteLine("Stack day!");
            }
        }
        public void Pop()
        {
            if (!isEmpty())
            {
                top = top - 1;
            }
            else
            {
                Console.WriteLine("Stack rong");
            }
        }
        public void Hienthi()
        {
            if (!isEmpty())
            {
                for (int i = 0; i <= top; i++)
                    Console.Write("{0}", a[i].ToString());
                Console.WriteLine();
            }
            else
                Console.WriteLine("Stack rong roi");
        }
    }
    public class Test
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>(5);
            if (st.isEmpty())
                Console.WriteLine("Stack rong");
            Console.WriteLine("**Thuc hien thao tac**");
            Console.WriteLine("\n");
            Console.WriteLine("//them {0} phan tu", st.a.Length);
            st.Push(3);
            st.Push(4);
            st.Push(5);
            st.Push(6);
            st.Push(7);
            st.Hienthi();
            if (st.isFull())
                Console.WriteLine("Stack da day");
            Console.WriteLine("\n");
            Console.WriteLine("//Xoa 1 phan tu");
            st.Pop();
            st.Hienthi();
            Console.WriteLine("\n");
            //
            Stack<string> st2 = new Stack<string>(3);
            if (st2.isEmpty())
                Console.WriteLine("Stack rong");
            Console.WriteLine("**Thuc hien thao tac**");
            Console.WriteLine("\n");
            Console.WriteLine("//them {0} phan tu", st2.a.Length);
            st2.Push("a");
            st2.Push("b");
            st2.Push("c");
            st2.Hienthi();
            if (st2.isFull())
                Console.WriteLine("Stack da day");
            Console.WriteLine("\n");
            Console.WriteLine("//Xoa 3 phan tu");
            st2.Pop();
            st2.Pop();
            st2.Pop();
            st2.Hienthi();
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
