using System.Collections.Generic;
using static DevOps.Primitives.VisualStudio.Solutions.Helpers.Common.SolutionGuidGetter;
using static System.IO.Path;
using static System.String;

namespace DevOps.Primitives.VisualStudio.Solutions.Helpers.VisualStudio15
{
    public static class Vs15Solutions
    {
        public static Solution Create(
            in string name,
            in IEnumerable<SolutionProject> sourceProjects,
            in IEnumerable<SolutionProject> testsProjects)
            => Common.Solutions.Create(
                in name,
                Vs15VersionInfo.Create(),
                in sourceProjects,
                in testsProjects);

        public static Solution SingleProject(in string name)
            => Common.Solutions.SingleProject(
                in name,
                Vs15VersionInfo.Create(),
                new SolutionProject(GetGuid(Concat("proj:", name)), in name, Combine(name, Concat(name, ".csproj"))));

        public static Solution SingleProject(
            in string name,
            in SolutionProject project)
            => Common.Solutions.SingleProject(
                in name,
                Vs15VersionInfo.Create(),
                in project);
    }
}
