using System.Collections.Generic;
using System.Linq;

namespace Refactoring.Example4
{
    public class AppDeployer
    {
        public IEnumerable<string> Deploy(IEnumerable<string> environments)
        {
            return environments.Select(target => "Deployed to " + target);
        }
    }

}
