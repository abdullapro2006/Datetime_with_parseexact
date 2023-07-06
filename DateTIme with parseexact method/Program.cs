// See https://aka.ms/new-console-template for more information



using System.Globalization;

public class Program 
{
    public static void Main(string[] args)
    {
        DateTime  datetime = DateTime.ParseExact("06_07_2023", "dd_MM_yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(datetime);
		try
		{

		}
		catch (Exception ex)
		{
            Console.WriteLine(ex.Message);
        }
        Console.Read();
    }
}

