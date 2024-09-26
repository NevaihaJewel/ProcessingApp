/*******************************************************************
* Name: Nevaiha Adams
*
* Unique class.
*/
using System.Runtime.CompilerServices;

public class Unique
{
    private List<int> uniqueVal = new List<int>();

    public Unique()
    {
        while(uniqueVal.Count() < 5)
        {
            try
            {
                Console.Write("Please enter an integer value: ");
                string? input = Console.ReadLine();
                int val = Convert.ToInt32(input);
                if (val<0 || val>100)
                {
                    throw new Exception();
                }
                else if (uniqueVal.Contains(val))
                {
                    throw new FormatException();
                }
                else
                {
                    uniqueVal.Add(val);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You must enter a value between 0 and 100, inclusive."+e.Message);
            }
        }
    }
    public List <int> GetValues()
    {
        return new List<int>(uniqueVal);
    }

    public int Largest()
    {
        int largeNum = uniqueVal.Max();
        return largeNum;
    }
    public int Smallest()
    {
        int smallNum = uniqueVal.Min();
        return smallNum;
    }
    public int Sum()
    {
        int sum = uniqueVal.Sum();
        return sum;
    }
    public int Average()
    {
        int avg = uniqueVal.Sum() / uniqueVal.Count();
        return avg;
    }
    public int Quotient()
    {
        try
        {
            if(uniqueVal.First() != 0)
            {
                return uniqueVal.Last() / uniqueVal.First();
            }
            else
            {
                throw new DivideByZeroException();
            }
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }

   
}