using QuranLib.Blueprints;
using QuranLib.Extensions;

namespace QuranLib;

public class QuranInstance : IQuranInstance
{
    private readonly Dictionary<ChapterName, Chapter> _chapters;
    private readonly Dictionary<ChapterName, ImmutableList<Verse>> _verses;
    public ScriptType ScriptType { get; set; }

    public QuranInstance(
        ScriptType scriptType = ScriptType.Clean,
        bool autoLoad = false,
        byte start = 1,
        byte end = 114
    )
    {
        _chapters = BaseDataStore.GetChapters().ToDictionary(c => c.Name);
        _verses = new Dictionary<ChapterName, ImmutableList<Verse>>();
        ScriptType = scriptType;
        if (autoLoad)
            LoadChapters(start, end);
    }

    public string GetInTheNameOfAllah() => GetBismillah();

    public string GetBismillah() =>
        ScriptType == ScriptType.Clean
            ? "بسم الله الرحمن الرحيم"
            : "بِسْمِ اللَّهِ الرَّحْمَـٰنِ الرَّحِيمِ";

    public List<string> GetChapterNames(
        byte start = 1,
        byte end = 114,
        ChapterNameType chapterNameType = ChapterNameType.Normal
    )
    {
        if (start < 1 || end > 114 || start > end)
            throw new ArgumentOutOfRangeException(nameof(start), "Invalid chapter range.");

        return chapterNameType switch
        {
            ChapterNameType.Normal => Utilities
                .GetEnumList<ChapterName>()
                .Skip(start - 1)
                .Take(end - start + 1)
                .Select(x => x.GetEnumDescription())
                .ToList(),
            ChapterNameType.ArabicFont => _chapters
                .Values.Skip(start - 1)
                .Take(end - start + 1)
                .Select(c => c.ChapterNameArabic)
                .ToList(),
            ChapterNameType.EnglishName => _chapters
                .Values.Skip(start - 1)
                .Take(end - start + 1)
                .Select(c => c.ChapterNameEnglish)
                .ToList(),
            _ => throw new InvalidEnumArgumentException(
                nameof(chapterNameType),
                (int)chapterNameType,
                typeof(ChapterNameType)
            ),
        };
    }

    public Chapter GetChapter(ChapterName chapterName)
    {
        if (!_chapters.TryGetValue(chapterName, out var chapter))
            throw new KeyNotFoundException("Chapter not found.");

        if (!_verses.ContainsKey(chapterName))
            LoadChapter(chapterName);

        return chapter;
    }

    public Chapter GetChapter(byte chapterNumber) => GetChapter((ChapterName)chapterNumber);

    public ImmutableList<Chapter> GetChapters(ChapterName[] chapterNames) =>
        chapterNames.Select(GetChapter).ToImmutableList();

    public ImmutableList<Chapter> GetChapters(IEnumerable<byte> chapterNumbers) =>
        GetChapters(chapterNumbers.Select(n => (ChapterName)n).ToArray());

    public ImmutableList<Chapter> GetChapters() => _chapters.Values.ToImmutableList();

    public Verse GetVerse(byte chapter, ushort verseNumber)
    {
        var chapterName = (ChapterName)chapter;
        if (!_verses.ContainsKey(chapterName))
            LoadChapter(chapterName);
        return _verses[chapterName].First(v => v.VerseNumber == verseNumber);
    }

    public Verse GetVerse(ChapterName chapter, ushort verseNumber) =>
        GetVerse((byte)chapter, verseNumber);

    public List<Verse> GetVerses(ChapterName chapter)
    {
        if (!_verses.ContainsKey(chapter))
            LoadChapter(chapter);
        return _verses[chapter].ToList();
    }

    public List<Verse> GetVerses(ushort chapterNumber) => GetVerses((ChapterName)chapterNumber);

    public ImmutableList<Verse> GetVerses(byte chapter, ushort startVerse, ushort endVerse)
    {
        var chapterName = (ChapterName)chapter;
        if (!_verses.ContainsKey(chapterName))
            LoadChapter(chapterName);
        return _verses[chapterName]
            .Where(v => v.VerseNumber >= startVerse && v.VerseNumber <= endVerse)
            .ToImmutableList();
    }

    public ImmutableList<Verse> GetVerses(
        ChapterName chapter,
        ushort startVerse,
        ushort endVerse
    ) => GetVerses((byte)chapter, startVerse, endVerse);

    public void LoadChapters(byte start = 1, byte end = 114)
    {
        for (var i = Math.Max((byte)1, start); i <= Math.Min((byte)114, end); i++)
        {
            LoadChapter((ChapterName)i);
        }
    }

    public void LoadChapter(ChapterName chapterName)
    {
        var res = ScriptType switch
        {
            ScriptType.Clean => CleanAyahResource.ResourceManager.GetString(
                $"Clean__{(byte)chapterName}_"
            ),
            ScriptType.WithTashkil => UthmaniWithTashkilAyahResource.ResourceManager.GetString(
                $"Simple__{(byte)chapterName}_"
            ),
            _ => throw new ArgumentOutOfRangeException(nameof(chapterName), "Invalid chapter name"),
        };

        if (string.IsNullOrEmpty(res))
            return;

        var verses = res.Split("\n")
            .Select((text, index) => new Verse(chapterName, (ushort)(index + 1), text))
            .ToImmutableList();
        _verses[chapterName] = verses;
        _chapters[chapterName].Verses = verses;
    }

    public ImmutableList<Verse> FindMatchingVerses(string searchTerm)
    {
        var cleanSearchTerm = searchTerm.RemoveTashkil();
        var results = new List<Verse>();

        LoadChapters();

        foreach (var (_, verses) in _verses)
        {
            results.AddRange(
                verses.Where(verse =>
                    verse
                        .Text.RemoveTashkil()
                        .Contains(cleanSearchTerm, StringComparison.OrdinalIgnoreCase)
                )
            );
        }

        return results.ToImmutableList();
    }

    public ImmutableList<Verse> FindMatchingVerses(string searchTerm, ChapterName chapterName)
    {
        if (!_verses.ContainsKey(chapterName))
            LoadChapter(chapterName);

        var cleanSearchTerm = searchTerm.RemoveTashkil();

        return _verses[chapterName]
            .Where(v =>
                v.Text.RemoveTashkil().Contains(cleanSearchTerm, StringComparison.OrdinalIgnoreCase)
            )
            .ToImmutableList();
    }
}
