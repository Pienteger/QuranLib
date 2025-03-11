namespace QuranLib;

public class QuranInstance
{
    public QuranInstance(
        ScriptType scriptType = ScriptType.Clean,
        bool autoLoad = false,
        byte start = 1,
        byte end = 114)
    {
        _baseVerseList = new List<Verse>();
        _baseChapterList = BaseDataStore.GetChapters().ToList();
        ScriptType = scriptType;
        if (autoLoad)
            LoadChapters(start, end);
    }

    public string GetInTheNameOfAllah()
    {
        return GetBismillah();
    }

    public string GetBismillah()
    {
        return ScriptType == ScriptType.Clean
            ? "بسم الله الرحمن الرحيم"
            : "بِسْمِ اللَّهِ الرَّحْمَـٰنِ الرَّحِيمِ";
    }

    public List<string> GetChapterNames(
        byte start = 1,
        byte end = 114,
        ChapterNameType chapterNameType = ChapterNameType.Normal)
    {
        switch (chapterNameType)
        {
            case ChapterNameType.Normal:
            {
                List<ChapterName> chapterList = Utils.GetEnumList<ChapterName>();
                return chapterList
                    .GetRange(start - 1, end - start + 1)
                    .Select(x => x.GetEnumDescription())
                    .ToList();
            }
            case ChapterNameType.ArabicFont:
                return _baseChapterList.Select(c => c.ChapterNameArabic).ToList();
            case ChapterNameType.EnglishName:
                return _baseChapterList.Select(c => c.ChapterNameEnglish).ToList();
            default:
                throw new InvalidEnumArgumentException(nameof(chapterNameType), (int)chapterNameType, typeof(Chapter));
        }
    }

    public Chapter GetChapter(ChapterName chapterName)
    {
        Chapter chapter = _baseChapterList
            .FirstOrDefault(x => x.Name == chapterName)!;
        if (!chapter.Verses.Any())
            LoadChapter(chapterName);
        return chapter;
    }

    public Chapter GetChapter(byte chapterNumber)
    {
        return GetChapter((ChapterName)chapterNumber);
    }

    public ImmutableList<Chapter> GetChapters(ChapterName[] chapterNames)
    {
        return _baseChapterList
            .Where(x => chapterNames.Contains(x.Name))
            .ToImmutableList();
    }

    public ImmutableList<Chapter> GetChapters(IEnumerable<byte> chapterNumbers)
    {
        ChapterName[] chapterNames = chapterNumbers.Select(x => (ChapterName)x).ToArray();
        return GetChapters(chapterNames);
    }

    public ImmutableList<Chapter> GetChapters()
    {
        return _baseChapterList.ToImmutableList();
    }

    public Verse GetVerse(
        byte chapter, 
        ushort verseNumber)
    {
        return _baseVerseList.First(a => a.Chapter == (ChapterName)chapter && a.VerseNumber == verseNumber);
    }

    public Verse GetVerse(
        ChapterName chapter, 
        ushort verseNumber)
    {
        return GetVerse((byte)chapter, verseNumber);
    }

    public List<Verse> GetVerses(ChapterName chapter)
    {
        return _baseVerseList.Where(a => a.Chapter == chapter).ToList();
    }

    public List<Verse> GetVerses(ushort chapterNumber)
    {
        return GetVerses((ChapterName)chapterNumber);
    }

    public ImmutableList<Verse> GetVerses(
        byte chapter, 
        ushort startVerse, 
        ushort endVerse)
    {
        return _baseVerseList.Where(a =>
                a.Chapter == (ChapterName)chapter && a.VerseNumber >= startVerse && a.VerseNumber <= endVerse)
            .ToImmutableList();
    }

    public ImmutableList<Verse> GetVerses(
        ChapterName chapter, 
        ushort startVerse, 
        ushort endVerse)
    {
        return GetVerses((byte)chapter, startVerse, endVerse);
    }

    private readonly List<Verse> _baseVerseList;
    private readonly List<Chapter> _baseChapterList;
    public ScriptType ScriptType { get; set; }

    public void LoadChapters(byte start = 1, byte end = 114)
    {
        if (end > 114 | start > end)
            end = 114;
        if (start < 1 | start > end)
            start = 1;
        for (byte i = start; i <= end; i++)
        {
            LoadChapter(i);
        }
    }

    public void LoadChapter(byte chapterNumber)
    {
        string? res = ScriptType switch
        {
            ScriptType.Clean => CleanAyahResource.ResourceManager.GetString($"Clean__{chapterNumber}_"),
            ScriptType.WithTashkil => UthmaniWithTashkilAyahResource.ResourceManager.GetString(
                $"Simple__{chapterNumber}_"),
            _ => throw new ArgumentOutOfRangeException(nameof(chapterNumber), chapterNumber, "Invalid chapter number")
        };
            
        Span<string> lineByLine = res!.Split("\n").AsSpan();
            
        ushort verseNumber = 1;
        foreach (string s in lineByLine)
        {
            var verse = new Verse((ChapterName)chapterNumber, verseNumber, s);
            _baseVerseList.Add(verse);
            verseNumber++;
        }

        byte i1 = chapterNumber;
        _baseChapterList.Single(c => c.Name == (ChapterName)i1).Verses =
            _baseVerseList.Where(v => v.Chapter == (ChapterName)i1).ToImmutableList();
    }

    public void LoadChapter(ChapterName chapterName)
    {
        LoadChapter((byte)chapterName);
    }
}