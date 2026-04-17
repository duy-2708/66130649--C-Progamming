using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_1
{   class Stack
    {
        private int max;
        private int top;
        
        private int[] stack;
        public int Max { get => max; set=>max = value; }
        public int Top { get => top; set=>top = value; }
      
       

        public Stack(int max ,int top , int[]stack ){
            this.max = max;
            this.top = -1;
            
            this.stack = new int[max]; 
        }
        public Stack(int max)
        {
            this.max = max;
            this.top = -1;

            this.stack = new int[max];
        }
        public virtual void push(int data)
        {
            if (top >= max - 1)
            {
                Console.WriteLine("Day");
            }
            else
            {
                top++;
                stack[top] = data;
            }
        }
        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Khong co gi ");
                return -1;
            }
            else
            {
                int data = stack[top];
                top--;
                return data;
               

            }
        }
        public virtual void Print()
        {
            for(int i = 0; i<= top; i++)
            {
                Console.WriteLine(stack[i] + " ");
            }
        }
     

    }
    class PrimeStack : Stack
    {
        public PrimeStack(int max) : base(max)
        {

        }
        private bool soNguyen(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i <=Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            
            }
            return true;
        }
        public override void push(int data)
        {
            if (soNguyen(data))
            {
                base.push(data);
            }
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack(100);
            PrimeStack s1 = new PrimeStack(5);
            s1.push(1);
            s1.push(2);
            s1.push(3);
            s1.push(4);
            s1.push(5);
            s1.Print();
        }
    }
}
