public class ExampleClass
{
    public int Calculate(int a, int b)
    {
        try
        {
            return a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("DivideByZeroException caught!");
            return 0; // Or handle the exception appropriately
        }
    }
}