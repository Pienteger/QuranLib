using System;
using System.Collections.Generic;
using System.Linq;

namespace QuranLib
{

    public class Chapter
    {
        private IEnumerable<Verse> verses;

        public ChapterName Name { get; set; }
        [Obsolete("Use ChapterName instead")]
        public string GetChapterName() => Name.GetEnumDescription();

        public string ChapterName => Name.GetEnumDescription();
        public string ChapterNameArabic { get; set; }
        public string ChapterNameEnglish { get; set; }
        public byte ChapterNumber { get; set; }
        public byte Order { get; set; }
        /// <summary>
        /// Every chapter comes with a leading Bismillah verse except Chapter 9.
        /// </summary>
        public IEnumerable<Verse> Verses
        {
            get => verses ?? (verses = new List<Verse>());
            set => verses = value;
        }

        public ushort TotalVerse => (ushort)Verses.Count();
        public PlaceOfRevelation PlaceOfRevelation => Utils.GetPlaceOfRevelation(ChapterNumber);
        public string JuzNumbers => string.Join(", ", Juz);
        public byte[] Juz { private get; set; }
        public float Ruku { get; set; }
        public bool HasMuqattaat => Utils.CheckIfHasMuqattaat(ChapterNumber);
    }
}