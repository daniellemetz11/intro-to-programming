using System.Security.Cryptography.X509Certificates;
using Alba;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Todos.Api.Todos;

public class GettingTodos
{

    [Fact]
    public async Task GetsAOkStatusCode()
    {
        ////http client is a data type in .NET, you have to set a few things for it
        //var client = new HttpClient();
        //client.BaseAddress = new Uri("http://localhost:1337");

        ////can only use the await keyword with async methods, no other lines will run until the await line is complete
        //var response = await client.GetAsync("/todos");


        //using program.cs as the argument
        var host = await AlbaHost.For<Program>();

        //references an instance of http
        await host.Scenario(api =>
        {
            //testing that when i get htis url that the status coode is OK
            api.Get.Url("/todos");
            api.StatusCodeShouldBeOk();//200
        });
    }


    [Fact]
    public async Task CanAddItemToTheTodoList()
    {
        var host = await AlbaHost.For<Program>();

        var itemToAdd = new TodoListCreateItem
        {
            Description = "Make Tacos " + Guid.NewGuid()
        };

        await host.Scenario(api =>
        {
            api.Post.Json(itemToAdd).ToUrl("/todos");
            api.StatusCodeShouldBeOk();
        });


        var getResponse = await host.Scenario(api => {
            api.Get.Url("/todos");
        });


        var listOfTodos = getResponse.ReadAsJson<List<TodoListItem>>();

        Assert.NotNull(listOfTodos);

        bool found = false;

       //fewer elements , less stuff than regular for loop
        foreach (TodoListItem v in listOfTodos)
        {
            if(v.Description == itemToAdd.Description)
            {
                found = true;
                break;
            }
        }

        //var hasMyItem = listOfTodos.Any(item => item.Description == itemToAdd.Description);

        Assert.True(found);
    }

}
