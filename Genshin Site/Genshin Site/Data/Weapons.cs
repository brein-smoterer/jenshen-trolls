namespace Genshin_Site.Data
{
    public class Weapon
    {
        public string Name { get; }
        public string Type { get; }
        public string Substat { get; }
        public string Passive { get; }
        public Weapon(string name, string type, string substat, string passive)
        {
            Name = name;
            Type = type;
            Substat = substat;
            Passive = passive;
        }
    }
}
