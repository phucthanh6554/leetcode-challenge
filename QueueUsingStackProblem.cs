using System.Buffers;

namespace Leetcode.Algorithm;

// Implement queue using stack
public class MyQueue {
    private Stack<int> _stack;

    public MyQueue() 
    {
        _stack = new Stack<int>();
    }
    
    public void Push(int x) 
    {
        if (_stack.Count == 0)
        {
            _stack.Push(x);
            return;
        }
        
        var arr = new int[_stack.Count];
        
        var i = 0;
        while(_stack.Count > 0)
            arr[i++] = _stack.Pop();
        
        _stack.Push(x);

        for (var j = i - 1; j >= 0; j--)
        {
            _stack.Push(arr[j]);
        }
    }
    
    public int Pop() 
    {
        return _stack.Pop();
    }
    
    public int Peek() 
    {
        return _stack.Peek();
    }
    
    public bool Empty() {
        return _stack.Count == 0;
    }
}