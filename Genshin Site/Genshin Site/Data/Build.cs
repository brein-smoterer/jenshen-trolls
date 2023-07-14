namespace Genshin_Site.Data
{
    public class Build
    {
        public string Name { get; set; }
        public bool Shown = false;
        public List<string> Weapons {get; set; }
        public List<string> ArtifactSets { get; set; }
        public List<string> Stats { get; set; }
        public Build(
            string name,
            List<string> weapons,
            List<string> artifactSets, 
            List<string> stats)
        {
            Name = name;
            Weapons = weapons;
            ArtifactSets = artifactSets;
            Stats = stats;
        }

    }
}
