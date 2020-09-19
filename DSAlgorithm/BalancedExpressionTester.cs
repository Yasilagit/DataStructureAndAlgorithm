using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithm
{
    class BalancedExpressionTester
    {
        static List<char> leftExpressionList = new List<char> { '(', '[', '{', '<' };
        static List<char> rightExpressionList = new List<char> { ')', ']', '}', '>' };
        public static bool IsBalancedExpression(string expression)
        {
            var stack = new Stack<char>();
            var charArray = expression.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (leftExpressionList.Contains(charArray[i]))
                {
                    stack.Push(charArray[i]);
                }
                else if (rightExpressionList.Contains(charArray[i]))
                {
                    if (stack.IsEmpty()) return false;
                    var top = stack.Pop();
                    if (!IsMathParanthesis(top, charArray[i]))
                    {
                        return false;
                    }
                }

            }
            return stack.IsEmpty();
        }

        private static bool IsMathParanthesis(char char1, char char2)
        {
            if (char1 == '(' && char2 == ')')
            {
                return true;
            }
            if (char1 == '{' && char2 == '}')
            {
                return true;
            }
            if (char1 == '[' && char2 == ']')
            {
                return true;
            }
            if (char1 == '<' && char2 == '>')
            {
                return true;
            }

            return false;

        }
    }
}
