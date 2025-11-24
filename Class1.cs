namespace CS8620_dotnet10_bug;

public class Class1
{
    public void Test()
    {
        string s = "Values: ";
        s = s.ConcatWith(1, 2, 3);
    }
}

public static class StringExtensions
{
    extension(string str)
    {
        public string ConcatWith(params int[] intValues)
        {
            return str + string.Join(",", intValues.ToString());
        }
    }
}