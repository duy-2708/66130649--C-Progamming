using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_5
{
    class Stack
    {
        private int top;
        private int Max;
        private int[] stack;

        public Stack(int max)
        {
            Max = max;
            stack = new int[max];
            top = -1;
        }
        public bool IsEmty()
        {
            return top == -1;
        }
        public bool Isfull()
        {
            return top == Max - 1;
        }
        public void Push(int data)
        {
            if (Isfull())
            {
                Console.WriteLine("Stack da day ");
            }
            else
            {
                top++;
                stack[top] = data;
            }
        }
        public int Pop()
        {
            if (IsEmty())
            {
                Console.WriteLine("Rong khong co gi de lay");
                return -1;
            }
            else
            {
                int data = stack[top];
                top--;
                return data;
            }
        }
        public void Xuat()
        {
            if (IsEmty())
            {
                Console.WriteLine("Rong khong co gi de xuat");
            }
            else
            {
                Console.WriteLine("Cac phan tu trong stack la");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]+" " );
                }
            }
        }
        public void Peek()
        {
            if (IsEmty())
            {
                Console.WriteLine("Rong khong co gi de lay");
            }
            else
            {
                Console.WriteLine("Phan tu tren dau stack la: {0}", stack[top]);
            }
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap mot so nguyen");
            int n = int.Parse(Console.ReadLine());
            int tam = n;
            Stack stack = new Stack(100);
            //lay so nguyen
            for (int i = 2; i <= tam; i++)
            {
                while(tam % i == 0 )
                {
                    stack.Push(i);
                    tam /= i;
                }
            }
            while(!stack.IsEmty())
            {
                Console.Write(stack.Pop());
                if(!stack.IsEmty())
                {
                    Console.Write(" * ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
