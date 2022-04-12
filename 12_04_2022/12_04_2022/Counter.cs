// See https://aka.ms/new-console-template for more information
public class Counter
{
    private string id;
    private int count;
    private Counter nextCounter;
    public Counter NextCounter
    {
        get
        {
            return nextCounter;
        }
        set
        {
            nextCounter = value;
        }
    }
    public int Count
    {
        get
        {
            return count;
        }
    }
    public Counter(string id)
    {
        this.id = id;
        nextCounter = null;
    }

    internal void Increment()
    {
        count++;
        if (count == 10)
        {
            count = 0;
            if (nextCounter != null)
            {
                nextCounter.Increment();
            }
        }
    }
    public override string ToString()
    {
        return $"[Counter <{id}> : {count}]";
    }
    internal void Reset()
    {
        count = 0;
    }
}