// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public class RandomizedSet
{
    private Random _random;
    private Dictionary<int, int> _dict;
    private List<int> _list;
    private int _count;
    public RandomizedSet()
    {
        _count = 0;
        _random = new Random();
        _dict = new Dictionary<int, int>();
        _list = new List<int>();
    }
    
    public bool Insert(int val) {
        
        if (!_dict.ContainsKey(val))
        {
            _list.Add(val);
            _dict[val] = _list.Count - 1;
            _count++;
            
            return true;
        }

        return false;
    }

    
    public bool Remove(int val) {
        
        if (_dict.ContainsKey(val))
        {
            var index = _dict[val];
            var lastElement = _list[_list.Count - 1];

            _dict[lastElement] = index;
            _list[index] = lastElement;
            
            _list.RemoveAt(_list.Count - 1);
            _dict.Remove(val);
            _count--;

            return true;
        }
        
        return false;
    }
    
    public int GetRandom() {
        return _list[_random.Next(_count)];
    }
}

