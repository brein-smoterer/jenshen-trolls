namespace Genshin_Site.Data
{
    public class Character
    {
        public string CharacterName { get; }
        public string Element { get; }
        public string Weapon { get; }
        public bool Show { get; set; }
        public string Imege { get; }

        public Character(string CharacterName1, string Element1, string Weapon1,bool Show1, string imgae)
        {
            CharacterName = CharacterName1;
            Element = Element1;
            Weapon = Weapon1;
            Show = Show1;
            Imege = imgae;
        }
    }
}