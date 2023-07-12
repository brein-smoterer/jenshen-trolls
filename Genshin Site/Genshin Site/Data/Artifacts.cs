namespace Genshin_Site.Data
{
    public class Artifacts
    {
        public string Name { get; set; }
        public string Slot { get; set; }
        public string Image { get; set; }
        public Artifacts(string Name, string Slot, string Image) { 
            this.Name = Name;
            this.Slot = Slot;
            this.Image = Image;
        }
    }
}
