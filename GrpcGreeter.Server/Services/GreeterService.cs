using Grpc.Core;

namespace GrpcGreeter.Server.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;

    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    
    public class Solution {
        public bool ContainsDuplicate(int[] nums)
        {
            var hSet = nums.ToHashSet();
            return hSet.Count == nums.Length;
        }
    }
    public override Task<PerfectUser> PerfectWeight(UserData request, ServerCallContext context)
    {
        if (request.Height is 0 || request.Weight >= request.Height)
            throw new ArgumentException("Height and weight are incorrect.");
        return Task.FromResult(new PerfectUser {PerfectWeight = request.Height - request.Weight});
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }
}