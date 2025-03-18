namespace ProgrammingChallenges.LeetCode;

public static class ValidParentheses
{
    /*
     Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

    An input string is valid if:

    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.
    Every close bracket has a corresponding open bracket of the same type.
     */
    public static bool IsValid(string s)
    {
        Stack<char> stack = [];

        foreach (var letter in s)
        {
            if (letter == '(' || letter == '[' || letter == '{')
                stack.Push(letter);
            else
            {
                if (stack.Count == 0) 
                    return false;

                var top = stack.Pop();

                if ((letter == ')' && top != '(') || (letter == ']' && top != '[') || (letter == '}' && top != '{'))
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
