using DevOps.Primitives.VisualStudio.Solutions.Helpers.Common;

namespace DevOps.Primitives.VisualStudio.Solutions.Helpers.VisualStudio15
{
    public static class Vs15VersionInfo
    {
        public const string VersionComment = "Visual Studio 15";
        public const string VisualStudioVersion = "15.0.27130.2010";

        public static VisualStudioVersionInfo Create()
            => new VisualStudioVersionInfo(VersionComment, VisualStudioVersion);
    }
}
