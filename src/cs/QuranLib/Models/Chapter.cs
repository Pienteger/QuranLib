namespace QuranLib.Models;

public class Chapter
{
    private IEnumerable<Verse> _verses;

    internal Chapter()
    {
        _verses = new List<Verse>();
    }

    public ChapterName Name { get; set; }

    [Obsolete("Use ChapterName instead")]
    public string GetChapterName() => Name.GetEnumDescription();

    public string ChapterName => Name.GetEnumDescription();
    public string ChapterNameArabic { get; set; }
    public string ChapterNameEnglish { get; set; }

    [MaxLength(114)] public byte ChapterNumber { get; set; }

    [MaxLength(114)] public byte Order { get; set; }

    /// <summary>
    /// Every chapter comes with a leading Bismillah verse except Chapter 9.
    /// </summary>
    public IEnumerable<Verse> Verses
    {
        get => _verses ??= new List<Verse>();
        set => _verses = value;
    }

    public ushort TotalVerse { get; init; }
    public PlaceOfRevelation PlaceOfRevelation => Utilities.GetPlaceOfRevelation(ChapterNumber);
    public string JuzNumbers => string.Join(", ", Juz);
    public byte[] Juz { private get; init; }

    [MaxLength(40)] public float Ruku { get; set; }
    public bool HasMuqattaat => Utilities.CheckIfHasMuqattaat(ChapterNumber);

    public override string ToString()
    {
        return ChapterName;
    }
}