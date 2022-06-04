using Grpc.Net.Client;
using GrpcGreeterClient;

using var chanel = GrpcChannel.ForAddress("https://localhost:7285");
var client = new Greeter.GreeterClient(chanel);
var response = await client.SayHelloAsync(new HelloRequest
{
    Name = "just Test"
});

Console.WriteLine(response.Message);

var weight = client.PerfectWeight(new UserData{Height = 150, Weight = 60});
Console.WriteLine(weight.PerfectWeight);