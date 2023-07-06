using Grpc.Net.Client;

namespace GrpcAcces.Grpc;

public class UserGrpcService
{
    static GrpcChannel channel = GrpcChannel.ForAddress("http://localhost:8080");
}