﻿namespace Genshin_Site.Data
{
    public class ArtifactSet
    {
        public string ArtifactSetName { get; }
        public string ArtifactSetPassive { get; }
        public bool Show = false;
        public ArtifactSet(string artifactSetName, string artifactSetPassive)
        {
            ArtifactSetName = artifactSetName;
            ArtifactSetPassive = artifactSetPassive;
        }
    }
}
