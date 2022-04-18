﻿using System.Collections.Immutable;

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
            return baseChapterList.FirstOrDefault(x => x.Name == chapterName)!;
        }

        public Chapter GetChapter(byte chapterNumber)
        {
            return GetChapter((ChapterName)chapterNumber);
        }

        public ImmutableList<Chapter> GetChapters(ChapterName[] chapterNames)
        {
            return baseChapterList
                .Where(x => chapterNames.Contains(x.Name))
                .ToImmutableList();
        }

        public ImmutableList<Chapter> GetChapters(byte[] chapterNumbers)
        {
            ChapterName[] chapterNames = chapterNumbers.Select(x => (ChapterName)x).ToArray();
            return GetChapters(chapterNames);
        }

        public ImmutableList<Chapter> GetChapters()
        {
            return baseChapterList.ToImmutableList();
        }

        public Verse GetVerse(byte chapter, ushort verseNumber)
        {
            return baseVerseList.FirstOrDefault(a => a.Chapter == (ChapterName)chapter && a.VerseNumber == verseNumber)
                !;
        }

        public Verse GetVerse(ChapterName chapter, ushort verseNumber)
        {
            return GetVerse((byte)chapter, verseNumber);
        }

        public ImmutableList<Verse> GetVerses(byte chapter, ushort startVerse, ushort endVerse)
        {
            return baseVerseList.Where(a =>
                    a.Chapter == (ChapterName)chapter && a.VerseNumber >= startVerse && a.VerseNumber <= endVerse)
                .ToImmutableList();
        }

        public ImmutableList<Verse> GetVerses(ChapterName chapter, ushort startVerse, ushort endVerse)
        {
            return GetVerses((byte)chapter, startVerse, endVerse);
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
                string? res = ScriptType switch
                {
                    ScriptType.Clean => CleanAyahResource.ResourceManager.GetString($"_{i}"),
                    ScriptType.WithTashkil => UthmaniWithTashkilAyahResource.ResourceManager.GetString(
                        $"UthmaniWithTashkil__{i}_"),
                    _ => throw new ArgumentOutOfRangeException()
                };
                string[] lineByLine = res!.Split("\n");
                ushort verseNumber = 1;
                foreach (string s in lineByLine)
                {
                    var verse = new Verse((ChapterName)i, verseNumber, s);
                    baseVerseList.Add(verse);
                    verseNumber++;
                }

                byte i1 = i;
                baseChapterList.Single(c => c.Name == (ChapterName)i1).Verses =
                    baseVerseList.Where(v => v.Chapter == (ChapterName)i1).ToImmutableList();
            }

        }
    }
}