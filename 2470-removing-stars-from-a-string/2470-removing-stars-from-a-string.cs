public class Solution {
    public string RemoveStars(string s) {
        Stack<string> opStack = new Stack<string>();

        foreach(char charOfS in s)
        {
            if(charOfS == '*')
                opStack.Pop();
            else
                opStack.Push(charOfS.ToString());
        }

        StringBuilder result = new StringBuilder();

        while(opStack.Count > 0)
        {
            result.Insert(0, opStack.Pop());
        }

        return result.ToString();
    }
}