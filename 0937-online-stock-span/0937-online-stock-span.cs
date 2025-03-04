public class StockSpanner {
    Stack<int[]> data; 
    public StockSpanner() {
        data = new Stack<int[]>();
    }
    
    public int Next(int price) {
        int result = 1;
        while(data.Count != 0 && ((int[])data.Peek())[0] <= price)
        {
            result += ((int[])data.Pop())[1];
        }

        data.Push(new int[]{price,result});       
        return result;        
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */