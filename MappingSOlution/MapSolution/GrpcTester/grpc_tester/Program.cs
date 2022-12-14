// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using Mapped.Api.Protos;


    var channel = GrpcChannel.ForAddress(new Uri("https://localhost:7024"));
    var client = new DistanceInfo.DistanceInfoClient(channel);

    var response = await client.GetDistanceAsync(new Cities
    {
        OriginCity = "Topeka,KS",
        DestinationCity = "Los Angeles,CA"
    });

    Console.WriteLine(response.Miles);

    Console.ReadKey();
