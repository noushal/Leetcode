public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        for(int i = 0; i < s.Length; i++){
            char c = s[i];
            if(stack.Any())
            {
                if(c==')')
                {
                    if(stack.Peek()!='(')
                    {
                        return false;
                    }
                    stack.Pop();
                }
                else if(c=='}')
                {
                    if(stack.Peek()!='{')
                    {
                        return false;
                    }
                    stack.Pop();
                }
                else if(c==']')
                {
                    if(stack.Peek()!='[')
                    {
                        return false;
                    }
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            else
            {
                stack.Push(c);
            }

        }
        if(stack.Any())
        {
            return false;
        }
        return true;

    }
}