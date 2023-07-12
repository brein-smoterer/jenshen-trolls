namespace Genshin_Site.Data
{
    public class ArtifactSet
    {
        public string Name { get; set; }
        public string Passive { get; set; }
        public Artifacts[] Artifacts { get; set; }
        public string Img { get; set; }
        public bool Show { get; set; }
        public ArtifactSet(string Name, string Passive, Artifacts[] Artifacts, string Img = null, bool Show = false)
        {
            this.Name = Name;
            this.Passive = Passive;
            this.Artifacts = Artifacts;
            this.Img = Img;
            this.Show = Show;
        }
    }
}
