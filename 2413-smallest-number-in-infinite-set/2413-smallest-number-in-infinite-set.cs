public class SmallestInfiniteSet {
    int[] queue;
    int index;

    public SmallestInfiniteSet() {
        queue = new int[1001];
        index = 1;
    }
    
    public int PopSmallest() {
        while(queue[index] == 1)
            index++;
        queue[index] = 1;
        return index;
    }
    
    public void AddBack(int num) {       
        if(num < index)
            index = num;
        queue[num] = 0;
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */