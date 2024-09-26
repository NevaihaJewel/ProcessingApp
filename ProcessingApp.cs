/*******************************************************************
* Name: Nevaiha Adams
*
* Main application (program) class.
*/
public class App
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nevaiha - Data Processing Application\n");

        //initiate
        Unique u = new Unique();
        List<int> uniqueVal = u.GetValues();


        //print objects
        Console.WriteLine($"\nUnique Values Entered:\n{string.Join(" ",uniqueVal)}");
        Console.WriteLine($"\nMin Value Entered: {u.Smallest()}");
        Console.WriteLine($"Max Value Entered: {u.Largest()}");
        Console.WriteLine($"Sum of Values Entered: {u.Sum()}");
        Console.WriteLine($"Average Value Entered: {u.Average()}");
        Console.WriteLine($"Last Value divided by First Value: {u.Quotient()}");
        Console.WriteLine("\nAll processing completed!");
    }
}
