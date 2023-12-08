// See https://aka.ms/new-console-template for more information
using Microsoft_Graph_Api_Example;
using Microsoft.Graph.Models;
using Microsoft_Graph_Api_Example;

Console.WriteLine("Hello, World!");

var tenantId = "3fec68b5-351a-41ee-97fe-7d61de9bbeb2";
var clientId = "ccfac8c3-4b8a-4185-9a61-89c394e80feb";
var clientSecret = "SxT8Q~R34_afg8F2~tqco6Qmg5DczeFksKsRIaCG";
GraphApiHandler apiHandler = new GraphApiHandler(tenantId, clientId, clientSecret);

var users = await apiHandler.getGraphClient().Users.GetAsync();

Console.WriteLine("========User list under a tenant=========");
foreach (var user in users.Value)
{
    Console.WriteLine(user.DisplayName);
}
