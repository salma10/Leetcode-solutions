public class RandomizedSet {
    Dictionary<int,int> data;
    List<int> position;
    int dataSize;
    Random rand;
    
    /** Initialize your data structure here. */
    public RandomizedSet() {
        data = new Dictionary<int,int>();
        position = new List<int>();
        dataSize = 0;
        rand = new Random();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if(data.ContainsKey(val))
            return false;
        position.Add(val);
        data[val] = dataSize;
        dataSize++;
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        
        if(!data.ContainsKey(val))
            return false;
        
        int pos = data[val];
        int arrElement = position[dataSize - 1];
        position[pos] = position[dataSize - 1];
        data[arrElement] = pos;
        position.RemoveAt(dataSize - 1);
        data.Remove(val);
        dataSize--;
        return true;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        int index = rand.Next(dataSize);
        return position[index];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */