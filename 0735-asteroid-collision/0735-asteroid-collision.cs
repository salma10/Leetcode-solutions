public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {

        Stack<int> result = new Stack<int>();
        result.Push(asteroids[0]);

        for(int i = 1; i < asteroids.Length; i++)
        {
            while(true)
            {
                if(result.Count > 0 && result.Peek() > 0 && asteroids[i] < 0)
                {
                    if(result.Peek() == Math.Abs(asteroids[i]))
                    {
                        result.Pop();
                        break;
                    }
                    else if(result.Peek() > Math.Abs(asteroids[i]))
                        break;
                    else
                        result.Pop();
                }
                else
                {
                    result.Push(asteroids[i]); 
                    break;
                }               
            }
        }

        int[] finalResult = new int[result.Count];
        
        for(int i = result.Count - 1; i >= 0; i--)
        {
            finalResult[i] = result.Pop();
        }

        return finalResult;
    }
}