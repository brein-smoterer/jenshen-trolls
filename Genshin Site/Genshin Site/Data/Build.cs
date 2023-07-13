namespace Genshin_Site.Data
{
    public class Build
    {
        public List<string> Weapons {get; set; }
        public List<string> ArtifactSets { get; set; }
        public List<string> Stats { get; set; }
        public Build(List<string> weapons, List<string> artifactSets, List<string> stats)
        {
            Weapons = weapons;
            ArtifactSets = artifactSets;
            Stats = stats;
        }

    }
}
