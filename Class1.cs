namespace CS8620_dotnet10_bug;

public class Class1
{
    public void Test()
    {
        string s = "Values: ";
        s = s.ConcatWith(MyEnum.Value1, MyEnum.Value2);
    }
}

public static class StringExtensions
{
    extension(string str)
    {
        public string ConcatWith(params MyEnum[] enumValues)
        {
            return str + string.Join(",", enumValues);
        }
    }
}

public enum MyEnum
{
    Value1,
    Value2
}