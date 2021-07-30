using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csApp1   //stack implement
{

    public interface Stack
    {
        int size();
        bool isEmpty();
        void push(Object e);
        Object pop();
        Object peek();
        String toString();
        int search(Object e);

    }


    class stackie : Stack
    {
        private int Size;
        private object[] arr;
        public stackie()
        {
            Size = 0;
            arr = new object[5];

        }

        public int size()
        {
            return Size;
        }

        public bool isEmpty()
        {
            if (Size == 0) return true;
            else return false;
        }

        public void push(Object e)
        {
            if (Size == arr.Length)
            {
                throw new StackOverflowException();
            }
            arr[Size] = e;
            Size++;
        }



        public Object pop()
        {
            if (Size == 0)
            {
                throw new StackUnderflowException();
            }
            else
            {
                Object x = arr[Size - 1];
                arr[Size - 1] = null;
                Size--;
                return x;
            }
        }

        public Object peek()
        {
            if (Size == 0)
            {
                throw new StackUnderflowException();
            }
            else
            {
                return arr[Size - 1];
            }
        }


        public String toString()
        {
            String n = "";
            for (int i = Size - 1; i >= 0; i--)
            {
                n = n + arr[i] + " ";
            }
            if (n == "")
            {
                return "Empty stack";
            }
            return n;
        }

        public int search(Object e)
        {
            for (int i = Size - 1, j = 0; i >= 0; i--, j++)
            {
                if (arr[i] == e)
                {
                    return j;
                }
            }
            return -1;
        }


    }




    public class StackOverflowException : Exception
    {
        public StackOverflowException()
        {

            Console.WriteLine("you are having an overflow expection!");
        }
    }

    public class StackUnderflowException : Exception
    {
        public StackUnderflowException()
        {

            Console.WriteLine("you are having a underflow expection!");
        }
    }


    class ProgramforStack
    {

        static void Main(string[] args)
        {
            stackie s = new stackie();
            try
            {
                s.push(10); s.push(20); s.push(30); s.push(40); s.push(50); s.push(60);
            }
            catch (StackOverflowException) { }

            try
            {
                Console.WriteLine(s.peek());
            }
            catch (StackOverflowException) { }

            try
            {
                s.pop(); s.pop();
            }
            catch (StackUnderflowException) { }

            Console.WriteLine("hello!");
        }

    }

}
