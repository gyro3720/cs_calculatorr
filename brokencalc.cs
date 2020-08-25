
using System;
using System.Numerics;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            String exp = " ";
            Console.WriteLine("enter your expression (separate values and operators w spaces thanks)");
            exp = Console.ReadLine();
            String[] exp2 = format(exp);

            if (exp2.Length > 3)
            {

            }

            Expression Calc = new Expression(int.Parse(exp2[0]), int.Parse(exp2[2]), exp2[1]);
            Console.WriteLine(Calc.calculate2Val());
        }

        static String[] format(String x)
        {
            String[] parts = x.Split(' ');
            return parts;
        }
    }

    class Expression
    {
        private int val1;
        private int val2;
        private int op;
        private String[] vals;

        public Expression(int va1, int va2, String o, String[] n)
        {
            val1 = va1;
            val2 = va2;
            op = operatorFormat(o);
            vals = n;
        }

        public Expression(int va1, int va2, String o)
        {
            val1 = va1;
            val2 = va2;
            op = operatorFormat(o);
            vals = new string[1];
        }

        public Expression(String[] n)
        {
            val1 = 0;
            val2 = 0;
            op = 0;
            vals = n;
        }

        public int operatorFormat(String x)
        {
            /*
             * 1 = add
             * 2 = subtract
             * 3 = multiply
             * 4 = divide
             * 5 = mod
             * 0 -> invalid
             */
            if (x.Equals("+"))
                return 1;
            else if (x.Equals("-"))
                return 2;
            else if (x.Equals("*"))
                return 3;
            else if (x.Equals("x"))
                return 3;
            else if (x.Equals("/"))
                return 4;
            else if (x.Equals("%"))
                return 5;
            return 0;
        }

        public int calculate2Val()
        {
            int x = 0;
            if (op == 0)
                x = 0;
            else if (op < 2)
                x = add(val1, val2);
            else if (op < 3)
                x = subtract(val1, val2);
            else if (op < 4)
                x = multiply(val1, val2);
            else if (op < 5)
                x = divide(val1, val2);
            else if (op < 6)
                x = mod(val1, val2);
            else
                x = 0;
            return x;
        }

        public int calculateLarge()
        {
            int x;
            String[] operators = new string[(vals.Length / 2) + 1];
            int[] newVals = new int[vals.Length];

            int opPos = 0;
            int valPos = 0;
            for(int i = 0; i < vals.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newVals[valPos] = int.Parse(vals[i]);
                    valPos++;
                }
                else
                {
                    operators[opPos] = vals[i];
                    opPos++;
                }
            }

            return x;

            for (i = 0; i < newVals.Length; i++)
            {
                if(newVals[i] == 0 && newVals[i + 1] == 0)

        }

        public int add(int x, int y)
        {
            return (x + y);
        }

        public int subtract(int x, int y)
        {
            return (x - y);
        }

        public int multiply(int x, int y)
        {
            return (x * y);
        }

        public int divide(int x, int y)
        {
            return (x / y);
        }

        public int mod(int x, int y)
        {
            return (x % y);
        }

        public int getVal1()
        {
            return val1;
        }

        public void setVal1(int x)
        {
            val1 = x;
        }

        public int getVal2()
        {
            return val2;
        }

        public void setVal2(int x)
        {
            val2 = x;
        }

        public int getOp()
        {
            return op;
        }

        public void setOp(int x)
        {
            op = x;
        }

        public int[] getVals()
        {
            return vals;
        }

        public void setVals(int[] x)
        {
            vals = x;
        }
    }
}
