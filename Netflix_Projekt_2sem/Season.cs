
namespace Netflix_Projekt_2sem
{
    public class Season
    {
        public int SeasonId { get; set; }

        public List<Episode> Episodes { get; set; } = new List<Episode>();

        public Season()
        {
        }

        public Season(int seasonId, List<Episode> episodes)
        {
            SeasonId = seasonId;
            Episodes = episodes;
        }
    }
}
