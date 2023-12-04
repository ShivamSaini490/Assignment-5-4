using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            int value = 58;

            if (value == 58)
            {
                throw new CustomException("Custom Exception: Value cannot be 58.");
            }

            Console.WriteLine("Value is not 58. Program continues...");
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
