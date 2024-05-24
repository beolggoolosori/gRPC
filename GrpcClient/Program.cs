using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcHelloWorld;


// See https://aka.ms/new-console-template for more information
using var channel = GrpcChannel.ForAddress("http://localhost:5211");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = "World" });
Console.WriteLine("Greeting: " + reply.Message);
