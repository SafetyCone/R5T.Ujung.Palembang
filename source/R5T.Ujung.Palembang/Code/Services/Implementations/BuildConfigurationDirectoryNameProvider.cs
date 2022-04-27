using System;

using R5T.Palembang;using R5T.T0064;


namespace R5T.Ujung.Palembang
{[ServiceImplementationMarker]
    /// <summary>
    /// A <see cref="IBuildConfigurationDirectoryNameProvider"/> implementation using the <see cref="IBuildConfigurationNameProvider"/> service that presumes that the build configuration directory name is the same as the build configuration name.
    /// </summary>
    public class BuildConfigurationDirectoryNameProvider : IBuildConfigurationDirectoryNameProvider,IServiceImplementation
    {
        private IBuildConfigurationNameProvider BuildConfigurationNameProvider { get; }


        public BuildConfigurationDirectoryNameProvider(IBuildConfigurationNameProvider buildConfigurationNameProvider)
        {
            this.BuildConfigurationNameProvider = buildConfigurationNameProvider;
        }

        public string GetBuildConfigurationDirectoryName()
        {
            var buildConfigurationName = this.BuildConfigurationNameProvider.GetBuildConfigurationName();

            var buildConfigurationDirectoryName = buildConfigurationName; // Presume the build configuration directory name is the same as the build configuration name.
            return buildConfigurationDirectoryName;
        }
    }
}
