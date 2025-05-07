public class Solution {
    public string SimplifyPath(string path) {
        
        string[] splittedPath = path.Split("/");
        LinkedList<string> sb = new LinkedList<string>();
        
        for(int index = 1; index < splittedPath.Length; index++)
        {
            string current = splittedPath[index];
            
            if(string.IsNullOrEmpty(current) || string.Equals(current, "."))
                continue;
            else if(string.Equals(current, ".."))
            {
                if(sb.Count > 0)
                    sb.RemoveLast();
            }  
            else
            {
                sb.AddLast(current);
            }
        }
        StringBuilder result = new StringBuilder();
        while(sb.Count > 0)
        {
            result.Append("/");
            result.Append(sb.First.Value);
            sb.RemoveFirst();
        }
        
        return result.Length == 0 ? "/" : result.ToString();
    }
}