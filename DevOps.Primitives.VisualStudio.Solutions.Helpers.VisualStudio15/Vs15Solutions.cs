using System.Collections.Generic;

namespace DevOps.Primitives.VisualStudio.Solutions.Helpers.VisualStudio15
{
    public static class Vs15Solutions
    {
        public static Solution Create(
            string name,
            IEnumerable<SolutionProject> sourceProjects,
            IEnumerable<SolutionProject> testsProjects)
            => Common.Solutions.Create(
                name,
                Vs15VersionInfo.Create(),
                sourceProjects,
                testsProjects);
    }
}
