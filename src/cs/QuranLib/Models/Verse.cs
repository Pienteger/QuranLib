namespace QuranLib.Models;

public class Verse
{
    internal Verse(ChapterName chapter, ushort verseNumber, string verse)
    {
        Chapter = chapter;
        VerseNumber = verseNumber;
        Text = verse;
    }

    public ChapterName Chapter { get; }
    public string ChapterName => Chapter.GetEnumDescription();
    public ushort VerseNumber { get; }
    public string Text { get; }

    public IEnumerable<string> WordByWord => Text.Split(' ');

    public SajdaType SajdaType => Utils.GetSajdaType(Chapter, VerseNumber);

    public override string ToString()
    {
        // return the text with arabic encoding
        return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(Text));
    }
}
