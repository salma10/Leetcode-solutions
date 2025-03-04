public class StockSpanner {
    Stack<int[]> data; 
    public StockSpanner() {
        data = new Stack<int[]>();
    }
    
    public int Next(int price) {
        if(data.Count == 0)
        {
            int[] stData = new int[]{price,1};
            data.Push(stData);
            return 1;
        }
        int result = 1;
        int[] temp = (int[])data.Peek();
        if(temp[0] > price)
        {
            int[] stData = new int[]{price,result};
            data.Push(stData);
        }
        else if(temp[0] == price)
        {
            result += temp[1];
            data.Pop();
            int[] stData = new int[]{price,result};
            data.Push(stData);
        }
        else
        {
            while(data.Count != 0 && ((int[])data.Peek())[0] <= price)
            {
                result += ((int[])data.Pop())[1];
            }
            int[] stData = new int[]{price,result};
            data.Push(stData);
        }
        
        return result;
        
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */