
namespace Netflix_Projekt_2sem
{
    public class Series
    {
        public int SeriesId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ReleaseYear { get; set; }

        //tilføjet startværdier til listerne
        public List<Tag> Tags { get; set; } = new List<Tag>();

        public List<Season> Seasons { get; set; } = new List<Season>();

        // NY Parameterløs constructor til Entity Framework
        public Series()
        {
        }

        // oprindelige constructor
        public Series(int seriesId, string title, string description, int releaseYear, List<Tag> tags, List<Season> seasons)
        {
            SeriesId = seriesId;
            Title = title;
            Description = description;
            ReleaseYear = releaseYear;
            Tags = tags;
            Seasons = seasons;
        }
    }
}
