using System.Collections.Generic;
using static DevOps.Primitives.VisualStudio.Solutions.Helpers.Common.SolutionGuidGetter;
using static System.IO.Path;

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

        public static Solution SingleProject(string name)
            => Common.Solutions.SingleProject(
                name,
                Vs15VersionInfo.Create(),
                new SolutionProject(GetGuid($"proj:{name}"), name, Combine(name, $"{name}.csproj")));

        public static Solution SingleProject(
            string name,
            SolutionProject project)
            => Common.Solutions.SingleProject(
                name,
                Vs15VersionInfo.Create(),
                project);
    }
}
