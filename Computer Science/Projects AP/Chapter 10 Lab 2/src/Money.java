public abstract class Money
{
    int count = 1;  // how many quality of that money
    double value;
    // constructor access private variable


    public Money()
    {

    }
    
    public double getAmount()
    {
        return this.value * count;
    }
    

    public String toString()
    {
        return "Bill{" + "count=" + count + ", value=" + value + "\n";
    }
}
