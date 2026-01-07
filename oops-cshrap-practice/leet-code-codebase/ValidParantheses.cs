using System.Collections.Generic;

public class ValidParantheses
{
    public bool IsValid(string str)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in str)
        {
            
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            else
            {
               
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop();

                if ((ch == ')' && top != '(') ||
                    (ch == '}' && top != '{') ||
                    (ch == ']' && top != '['))
                {
                    return false;
                }
            }
        }

    
        return stack.Count == 0;
    }
}
