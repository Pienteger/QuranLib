using System.ComponentModel.DataAnnotations;
namespace QuranLib
{

    public class Chapter
    {
        private IEnumerable<Verse> verses;

        public ChapterName Name { get; set; }
        public string GetChapterName() => Name.GetEnumDescription();

        /// <summary>
        /// Every chapter comes with a leading Bismillah verse except Chapter 9.
        /// </summary>
        public IEnumerable<Verse> Verses
        {
            get => verses ??= new List<Verse>();
            set => verses = value;
        }

        public ushort TotalVerse { get; set; }
        public byte ChapterNumber { get; set; }
        public PlaceOfRevelation PlaceOfRevelation => Utils.GetPlaceOfRevelation(ChapterNumber);
        public string JuzNumbers => string.Join(", ", Juz);
        public byte[] Juz { private get; set; }
        [MaxLength(40)] public float Ruku { get; set; }
        public bool HasMuqattaat => Utils.CheckIfHasMuqattaat(ChapterNumber);
    }
}