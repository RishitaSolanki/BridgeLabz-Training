using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectThree.StackAndQueue
{
    using System;
    using System.Collections.Generic;

    //Main class
    class StockSpanProblem
    {
        //For each day in a stock price array,
        //calculate the span
        public static int[] CalculateSpan(int[] prices)
        {
            int len = prices.Length;

            int[] span = new int[len];

            Stack<int> stack = new Stack<int>();


            for (int i = 0; i < len; i++)
            {
                
                while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                {
                    stack.Pop();
                }

               
                span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());

                
                stack.Push(i);
            }

            return span;
        }

        //Main method
        public static void Main(string[] args)
        {
            int[] prices = { 90, 55, 60, 45, 60, 70, 85 };
            int[] result = CalculateSpan(prices);

            Console.WriteLine("Stock Spans:");
            foreach (int s in result)
            {
                Console.Write(s + " ");
            }
        }
    }

}
