using System;

using R5T.T0142;


namespace R5T.T0209
{
    /// <summary>
    /// Used to uniquely identify a GitHub repository.
    /// </summary>
    [DataTypeMarker]
    public sealed class GitHubRepositoryIdentifier
    {
        public string OwnerName { get; set; }
        public string RepositoryName { get; set; }


        public override string ToString()
        {
            var output = $"{this.OwnerName}/{this.RepositoryName}";
            return output;
        }
    }
}
