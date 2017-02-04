class Stack<T>
{
    T[] buffer;
    int top;
    
    public Stack(int max)
    {
        this.buffer = new T[max];
        this.top = 0;
    }
    
    public void Push(T value)
    {
        this.buffer[this.top++] = value;
    }
    
    public T Pop()
    {
        return this.buffer[--this.top];
    }

    public int Size
    {
        get {return this.top;}
    }

    public int MaxSize
    {
        get {return this.buffer.Length;}
    }
}