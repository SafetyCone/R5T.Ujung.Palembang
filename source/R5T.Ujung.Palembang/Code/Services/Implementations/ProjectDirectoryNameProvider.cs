using System;

using R5T.Palembang;


namespace R5T.Ujung.Palembang
{
    /// <summary>
    /// A <see cref="IProjectDirectoryNameProvider"/> implementation using the <see cref="IProjectNameProvider"/> service that presumes that the project directory name is the same as the project name.
    /// </summary>
    public class ProjectDirectoryNameProvider : IProjectDirectoryNameProvider
    {
        private IProjectNameProvider ProjectNameProvider { get; }


        public ProjectDirectoryNameProvider(IProjectNameProvider projectNameProvider)
        {
            this.ProjectNameProvider = projectNameProvider;
        }

        public string GetProjectDirectoryName()
        {
            var projectName = this.ProjectNameProvider.GetProjectName();

            var projectDirectoryName = projectName; // Presume the project directory name is the same as the project name.
            return projectDirectoryName;
        }
    }
}
