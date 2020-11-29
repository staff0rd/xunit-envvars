using Microsoft.Extensions.Configuration;
using Xunit;
using Shouldly;

namespace MyTestProject
{
    public class UnitTest1
    {
        public readonly IConfiguration _config;
        
        public UnitTest1(IConfiguration config)
        {
            _config = config;
        }

        [Fact]
        public void Test1()
        {
            _config.GetValue<string>("MyEnvVar").ShouldBe("Hello");
        }
    }
}
