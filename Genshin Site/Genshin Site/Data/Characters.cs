namespace Genshin_Site.Data
{
    public class Character
    {
        public string CharacterName { get; set; }
        public string Element { get; set; }
        public string Weapon { get; set; }
        public bool Show { get; set; }
        public string Image { get; set; }
        public List<Build> Builds { get; set; }    

        public Character(string CharacterName, string Element, string Weapon, bool Show, string Image, List<Build> builds)
        {
            this.CharacterName = CharacterName;
            this.Element = Element;
            this.Weapon = Weapon;
            this.Show = Show;
            this.Image = Image;
            Builds = builds;
        }
    }
}