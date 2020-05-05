using System;

using R5T.Palembang;


namespace R5T.Ujung.Palembang
{
    /// <summary>
    /// A <see cref="ITargetFrameworkDirectoryNameProvider"/> implementation using the <see cref="ITargetFrameworkDirectoryNameProvider"/> service that presumes that the target framework directory name is the same as the target framework name.
    /// </summary>
    public class TargetFrameworkDirectoryNameProvider : ITargetFrameworkDirectoryNameProvider
    {
        private ITargetFrameworkNameProvider TargetFrameworkNameProvider { get; }


        public TargetFrameworkDirectoryNameProvider(ITargetFrameworkNameProvider targetFrameworkNameProvider)
        {
            this.TargetFrameworkNameProvider = targetFrameworkNameProvider;
        }

        public string GetTargetFrameworkDirectoryName()
        {
            var targetFrameworkName = this.TargetFrameworkNameProvider.GetTargetFrameworkName();

            var targetFrameworkDirectoryName = targetFrameworkName; // Presume the target framework directory name is the same as the target framework name.
            return targetFrameworkDirectoryName;
        }
    }
}
