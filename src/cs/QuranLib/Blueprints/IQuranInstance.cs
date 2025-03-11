namespace QuranLib.Blueprints;

public interface IQuranInstance
{
    /// <summary>
    /// Set the script type for the Quran instance.
    /// </summary>
    ScriptType ScriptType { get; set; }

    /// <summary>
    /// Get the Bismillah verse.
    /// </summary>
    /// <returns></returns>
    string GetInTheNameOfAllah();

    /// <summary>
    /// Get the Bismillah verse.
    /// </summary>
    /// <returns></returns>
    string GetBismillah();


    /// <summary>
    /// Get the chapter names.
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="chapterNameType"></param>
    /// <returns></returns>
    List<string> GetChapterNames(byte start = 1, byte end = 114,
        ChapterNameType chapterNameType = ChapterNameType.Normal);

    /// <summary>
    /// Get a chapter by name.
    /// </summary>
    /// <param name="chapterName"></param>
    /// <returns></returns>
    Chapter GetChapter(ChapterName chapterName);

    /// <summary>
    /// Get a chapter by number.
    /// </summary>
    /// <param name="chapterNumber"></param>
    /// <returns></returns>
    Chapter GetChapter(byte chapterNumber);

    /// <summary>
    /// Get a list of chapters by name.
    /// </summary>
    /// <param name="chapterNames"></param>
    /// <returns></returns>
    ImmutableList<Chapter> GetChapters(ChapterName[] chapterNames);

    /// <summary>
    /// Get a list of chapters by number.
    /// </summary>
    /// <param name="chapterNumbers"></param>
    /// <returns></returns>
    ImmutableList<Chapter> GetChapters(IEnumerable<byte> chapterNumbers);

    /// <summary>
    /// Get all the chapters.
    /// </summary>
    /// <returns></returns>
    ImmutableList<Chapter> GetChapters();

    /// <summary>
    /// Get a verse by chapter and verse number.
    /// </summary>
    /// <param name="chapter"></param>
    /// <param name="verseNumber"></param>
    /// <returns></returns>
    Verse GetVerse(byte chapter, ushort verseNumber);

    /// <summary>
    /// Get a verse by chapter name and verse number.
    /// </summary>
    /// <param name="chapter"></param>
    /// <param name="verseNumber"></param>
    /// <returns></returns>
    Verse GetVerse(ChapterName chapter, ushort verseNumber);

    /// <summary>
    /// Get a list of verses by chapter.
    /// </summary>
    /// <param name="chapter"></param>
    /// <returns></returns>
    List<Verse> GetVerses(ChapterName chapter);

    /// <summary>
    /// Get a list of verses by chapter number.
    /// </summary>
    /// <param name="chapterNumber"></param>
    /// <returns></returns>
    List<Verse> GetVerses(ushort chapterNumber);

    /// <summary>
    /// Get a list of verses by chapter, start verse, and end verse.
    /// </summary>
    /// <param name="chapter"></param>
    /// <param name="startVerse"></param>
    /// <param name="endVerse"></param>
    /// <returns></returns>
    ImmutableList<Verse> GetVerses(byte chapter, ushort startVerse, ushort endVerse);

    /// <summary>
    /// Get a list of verses by chapter name, start verse, and end verse.
    /// </summary>
    /// <param name="chapter"></param>
    /// <param name="startVerse"></param>
    /// <param name="endVerse"></param>
    /// <returns></returns>
    ImmutableList<Verse> GetVerses(ChapterName chapter, ushort startVerse, ushort endVerse);

    /// <summary>
    /// Load the chapters from the start to the end.
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    void LoadChapters(byte start = 1, byte end = 114);

    /// <summary>
    /// Load a chapter by name.
    /// </summary>
    /// <param name="chapterName"></param>
    void LoadChapter(ChapterName chapterName);

    /// <summary>
    /// Find verses that match the search term in the Quran.
    /// </summary>
    /// <param name="searchTerm"></param>
    /// <returns></returns>
    ImmutableList<Verse> FindMatchingVerses(string searchTerm);

    /// <summary>
    /// Find verses that match the search term in the chapter.
    /// </summary>
    /// <param name="searchTerm"></param>
    /// <param name="chapterName"></param>
    /// <returns></returns>
    ImmutableList<Verse> FindMatchingVerses(string searchTerm, ChapterName chapterName);
}