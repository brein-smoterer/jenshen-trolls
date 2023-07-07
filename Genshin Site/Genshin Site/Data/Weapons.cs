namespace Genshin_Site.Data
{
    public class Weapon
    { 
        public string Image { get; }
        public bool Show = false;
        public string Name { get; }
        public string Type { get; }
        public string Substat { get; }
        public string Passive { get; }
        public Weapon(string name, string type, string substat, string passive, string image)
        {
            Name = name;
            Type = type;
            Substat = substat;
            Passive = passive;
            Image = image;
        }
    }
}
