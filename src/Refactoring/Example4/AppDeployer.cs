using System.Collections.Generic;

namespace Refactoring.Example4
{
    public class AppDeployer
    {
        public IEnumerable<string> Deploy(IEnumerable<string> environments)
        {
            var result = new List<string>();

            foreach (var target in environments)
            {
                result.Add("Deployed to " + target);   
            }

            return result;
        }
    }

}
