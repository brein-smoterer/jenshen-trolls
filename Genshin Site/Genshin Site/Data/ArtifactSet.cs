namespace Genshin_Site.Data
{
    public class ArtifactSet
    {
        public string Img;
        //public FileInfo[] files = d.GetFiles();
        public string ArtifactSetName { get; }
        public string ArtifactSetPassive { get; }
        public bool Show = false;
        public ArtifactSet(string artifactSetName, string artifactSetPassive, string img)
        {
            ArtifactSetName = artifactSetName;
            ArtifactSetPassive = artifactSetPassive;
            Img = img;
        }
    }
}
