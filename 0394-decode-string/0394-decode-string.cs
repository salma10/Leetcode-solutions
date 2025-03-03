public class Solution {
    public string DecodeString(string s) {
        Stack<char> inputString = new Stack<char>();
        Stack<char> inputString2 = new Stack<char>();      
        Dictionary<char, int> numbers = new Dictionary<char, int>{
            {'0', 0}, {'1',1}, {'2', 2}, {'3', 3}, {'4', 4}, {'5', 5}, {'6', 6}, {'7', 7}, {'8', 8}, {'9', 9}
        };
        Stack<char> result = new Stack<char>();
        int currentBrackets = 0;

        for(int i = 0; i < s.Length; i++)
            inputString.Push(s[i]);

        while(inputString.Count > 0)
        {
            if(inputString.Peek() == ']')
            {
                while(inputString.Peek() != '[')
                {
                    inputString2.Push(inputString.Pop());
                }

                inputString.Pop();
                int repeat = 0;
                string currentNumber = string.Empty;

                while(inputString.Count > 0 && numbers.ContainsKey(inputString.Peek()))
                {
                    currentNumber = inputString.Pop() + currentNumber;
                }
                
                repeat = int.Parse(currentNumber);
                StringBuilder currentString = new StringBuilder();

                while(inputString2.Peek() != ']')
                {
                    currentString.Append(inputString2.Pop());
                }
                inputString2.Pop();
                while(repeat > 0)
                {
                    for (int i = 0; i < currentString.Length; i++)
                        inputString.Push(currentString[i]);
                    repeat--;
                }
                while(inputString2.Count > 0)
                {
                    inputString.Push(inputString2.Pop());
                }

            }
            else
                result.Push(inputString.Pop());
        }
        string decodedString = string.Empty;

        while(result.Count > 0)
            decodedString += result.Pop();

        return decodedString;
    }
}