namespace Netflix_Projekt_2sem
{
    public class Season
    {
        int SeasonId { get; set; }

        List<Episode> Episodes { get; set; }

        public Season(int seasonId, List<Episode> episodes)
        {
            SeasonId = seasonId;
            Episodes = episodes;
        }
    }
}
