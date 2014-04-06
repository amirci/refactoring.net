using NUnit.Framework;
using Refactoring.Example4;

namespace Refactoring.Tests.Example4
{
    class AppDeployerTest
    {
        class DeployMethod
        {
            [Test]
            public void When_calling_with_multiple_environments()
            {
                var deployer = new AppDeployer();

                var environments = new [] { "Production", "Staging", "UAT" };

                var actual = deployer.Deploy(environments);

                var expected = new[] {"Deployed to Production", "Deployed to Staging", "Deployed to UAT"};

                Assert.That(actual, Is.EquivalentTo(expected));
            }
        }
    }
}
