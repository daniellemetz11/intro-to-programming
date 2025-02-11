using System.Runtime.Serialization;
using Todos.Api.Utils;

namespace Todos.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string firstName = "Bob", lastName = "Smith", fullName;

        fullName = Formatters.FormatName(firstName, lastName);

        if(fullName != "Smith, Bob")
        {
            throw new Exception();
        }

        Assert.Equal("Smith, Bob", fullName);
    }


    [Theory]
    [InlineData("Bob", "Smith", "Smith, Bob")]

    public void CanFormatAnyName(string firstName, string lastName, string expecting)
    {
        var fullName = Formatters.FormatName(firstName, lastName);

        Assert.Equal(expecting, fullName);
    }
}
