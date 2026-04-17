using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Stack
{   class Stack
    {
        private int top;
        private int max;
        private int[] mystack;

        public int Top { get => top; set => top = value; }
        public int Max { get => max; set => max = value; }
        public int[] Mystack { get => mystack; set => mystack = value; }

        public Stack( int max)
        {
            this.Max = max;
            mystack = new int[max];
            Top = -1;
        }
        public void Push(int data)
        {
            if(Top > Max -1)
            {
                Console.WriteLine("Stack da day ");
            }
            else
            {
                Top++;
                mystack[Top] = data;
            }
        }
        public int Pop()
        {
            if (Top == -1)
            {
                Console.WriteLine("Khong co gi de lay");
                return -1;
            }
            else
            {
                int data = mystack[Top];
                Top--;
                return data;
            }
        }
        public  virtual void Print()
        {
            Console.WriteLine("Du lieu trong stack");
            for(int i= Top; i>=0; i--)
            {
                Console.WriteLine(mystack[i] + " ");
            }
        }
        }
    class PrimeStack:Stack
    { 
           public PrimeStack(int max ) : base(max)
        {
            this.Max = Max;
        }
        public void Solve(int n)
        {
            int tam = n;
            for(int i = 2; i<= tam; i++)
            {
                while(tam%i == 0)
                {
                    this.Push(i);
                    tam /= i;
                }
            }
        }
        public override void Print()
        {
            Console.WriteLine("Day thua so nguyen to");
            for(int i = Top; i >= 0; i--)
            {
                Console.Write(Mystack[i]);
                if (i > 0) Console.Write("*");
                
            }
            
        }
    }
    class HexStack : Stack
    {
        public HexStack(int max) : base(max)
        {
            this.Max = Max;
        }
       public void Solve(int n)
        {
            int tam = n;
            if (tam == 0) this.Push(0);
            while(tam > 0)
            {
                this.Push(tam % 16);
                tam /= 16;
            }
        }
        public override void Print()
        {
            for(int i = Top; i>= 0; i++)
            {
                string hexa = "0123456789ABCDEF";
                Console.WriteLine("Day so luc phan");
                Console.WriteLine(hexa[Mystack[i]]);
            }
        }
    }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        PrimeStack pr1 = new PrimeStack(100);
        pr1.Solve(12);
        pr1.Print();

    }
    }

