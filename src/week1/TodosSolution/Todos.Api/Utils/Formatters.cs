namespace Todos.Api.Utils;

public class Formatters
{
    //method that takes two strings and returns a string
    //static means method of the type not instance of the type, don't have to create a formatter to call the method
    public static string FormatName(string firstName, string lastName)
    {
        return lastName + ", " + firstName;
    }
}
