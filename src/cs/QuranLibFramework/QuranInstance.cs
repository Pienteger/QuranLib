using System;
using System.Collections.Generic;
using System.Linq;
using QuranLibFramework;

namespace QuranLib
{

    public class QuranInstance
    {
        public QuranInstance(ScriptType scriptType = ScriptType.Clean, bool autoLoad = false, byte start = 1,
            byte end = 114)
        {
            baseVerseList = new List<Verse>();
            baseChapterList = BaseDataStore.GetChapters().ToList();
            ScriptType = scriptType;
            if (autoLoad)
                LoadChapters(start, end);
        }

        public List<string> GetChapterNames(byte start = 1, byte end = 114)
        {
            List<ChapterName> chapterList = Utils.GetEnumList<ChapterName>();
            return chapterList.GetRange(start - 1, end - start + 1)
                .Select(x => x.GetEnumDescription()).ToList();
        }

        public Chapter GetChapter(ChapterName chapterName)
        {
            return baseChapterList.FirstOrDefault(x => x.Name == chapterName);
        }

        public Chapter GetChapter(byte chapterNumber)
        {
            return GetChapter((ChapterName)chapterNumber);
        }

        public List<Chapter> GetChapters(ChapterName[] chapterNames)
        {
            return baseChapterList
                .Where(x => chapterNames.Contains(x.Name))
                .ToList();
        }

        public List<Chapter> GetChapters(byte[] chapterNumbers)
        {
            ChapterName[] chapterNames = chapterNumbers.Select(x => (ChapterName)x).ToArray();
            return GetChapters(chapterNames);
        }

        public List<Chapter> GetChapters()
        {
            return baseChapterList.ToList();
        }

        public Verse GetVerse(byte chapter, ushort verseNumber)
        {
            return baseVerseList.FirstOrDefault(a => a.Chapter == (ChapterName)chapter && a.VerseNumber == verseNumber);
        }

        public Verse GetVerse(ChapterName chapter, ushort verseNumber)
        {
            return GetVerse((byte)chapter, verseNumber);
        }

        public List<Verse> GetVerses(byte chapter, ushort startVerse, ushort endVerse)
        {
            return baseVerseList.Where(a =>
                    a.Chapter == (ChapterName)chapter && a.VerseNumber >= startVerse && a.VerseNumber <= endVerse)
                .ToList();
        }

        public List<Verse> GetVerses(ChapterName chapter, ushort startVerse, ushort endVerse)
        {
            return GetVerses((byte)chapter, startVerse, endVerse);
        }

        public List<Verse> GetVerses(ChapterName chapter)
        {
            return baseVerseList.Where(a => a.Chapter == chapter).ToList();
        }

        public List<Verse> GetVerses(ushort chapterNumber)
        {
            return GetVerses((ChapterName)chapterNumber);
        }
        private readonly List<Verse> baseVerseList;
        private readonly List<Chapter> baseChapterList;
        public ScriptType ScriptType { get; set; }

        public void LoadChapters(byte start = 1, byte end = 114)
        {
            if (end > 114 | start > end)
                end = 114;
            if (start < 1 | start > end)
                start = 1;


            for (byte i = start; i <= end; i++)
            {
                string res = string.Empty;
                switch (ScriptType)
                {
                    case ScriptType.Clean:
                        res = CleanAyahResource.ResourceManager.GetString($"_{i}");
                        break;
                    case ScriptType.WithTashkil:
                        res = UthmaniWithTashkilAyahResource.ResourceManager.GetString($"UthmaniWithTashkil__{i}_");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                string[] lineByLine = res.Split(new[] { "\n" }, StringSplitOptions.None);
                ushort verseNumber = 1;
                foreach (string s in lineByLine)
                {
                    var verse = new Verse((ChapterName)i, verseNumber, s);
                    baseVerseList.Add(verse);
                    verseNumber++;
                }

                byte i1 = i;
                baseChapterList.Single(c => c.Name == (ChapterName)i1).Verses =
                    baseVerseList.Where(v => v.Chapter == (ChapterName)i1).ToList();
            }

        }
    }
}