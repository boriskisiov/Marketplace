using System.ComponentModel.Design;
using System.Net.Http.Headers;


var product = Console.ReadLine();
var dayOfWeek = Console.ReadLine();

if (product == "Banana")
{
    if (dayOfWeek == "Weekday")
    {
        Console.WriteLine("2.50");
    }
    else
    {
        Console.WriteLine("2.70");
    }

}
else if (product == "Apple")
{
    if (dayOfWeek == "Weekday")
    {
        Console.WriteLine("1.30");
    }
    else
    {
        Console.WriteLine("1.60");
    }
}
else if (product == "Kiwi")
{
    if(dayOfWeek == "Weekday")
    {
        Console.WriteLine("2.20");
    }
    else {
        Console.WriteLine("3.00");
    }
}
    

    
