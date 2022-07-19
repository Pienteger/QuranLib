![Nuget](https://img.shields.io/nuget/dt/Pienteger.QuranLib?style=flat-square)
![Nuget](https://img.shields.io/nuget/v/Pienteger.QuranLib?style=flat-square)

# Quran Lib

A portable Quran library that gives read-only access to the entire Holy Quran.

## Available Versions

* .NET 6
* .NET Framework 4.5

## Installation

In the NuGet package manager console type -

```powershell
Install-Package Pienteger.QuranLib
```
Or paste this code directly in the **.csproj** file.

```xml
<PackageReference Include="Pienteger.QuranLib" Version="6.0.3" />
```

## Usage

```csharp
using Pienteger.QuranLib;
```
```csharp
QuranInstance quran = new QuranInstance();
quran.LoadChapters(1, 5);
Chapter? chapter = quran.GetChapter(1);
string randomAyah = chapter.Verses.ToList()[random.Next(0, chapter.TotalVerse)].Text;
```

## API Documentation

### Script Type

Two script types are available:

1. `ScriptType.Clean` - The script is a clean script that does not contain any Harkat or Tashkeel.
2. `ScriptType.WithTashkil` - The script is a script that contains Harkat and Tashkeel.

`ScriptType.Clean` is set to default. If you want to use `ScriptType.WithTashkil`, you can set it in the constructor.

### Constructor Parameters

`QuranInstance` constructor has four parameters:

* `scriptType` - The script type. (Default is set to `ScriptType.Clean`)
* `autoLoad` - If `true`, the library will automatically load the chapters. (Default is set to `false`)
* `start` and `end` - The start and end chapter numbers. (Default is set to `1` and `114`. If `autoLoad` is `true`, the library will load chapters within this range.)

You can load chapters manually by calling `LoadChapters` method. ~~**Without loading chapters, the library will not be able to work properly.**~~ If the chapter is not loaded, the library will load it automatically when you call `GetChapter` method.

### Methods


| Method                                                               | Description                                |
| -------------------------------------------------------------------- | ------------------------------------------ |
| `LoadChapters(byte start = 1, byte end = 114)`                       | Loads chapters within the specified range. |
| `GetChapterNames(byte start = 1, byte end = 114)`                    | Returns a list of chapter names.           |
| `GetBismillah()`											           | Returns Bismillahir Rahmanir  Rahim in selected script |
| `GetInTheNameOfAllah()`									           | Returns Bismillahir Rahmanir  Rahim in selected script |
| `GetChapter(ChapterName chapterName)`                                | Returns a `Chapter` object.                |
| `GetChapter(byte chapterNumber)`                                     | Returns a `Chapter` object.                |
| `GetChapters(ChapterName[] chapterNames)`                            | Returns a `ImmutableList<Chapter>` object. |
| `GetChapters(byte[] chapterNumbers)`                                 | Returns a `ImmutableList<Chapter>` object. |
| `GetChapters()`                                                      | Returns a `ImmutableList<Chapter>` object. |
| `GetVerse(byte chapter, ushort verseNumber)`                         | Returns a `Verse` object.                  |
| `GetVerse(ChapterName chapter, ushort verseNumber)`                  | Returns a `Verse` object.                  |
| `GetVerses(ChapterName chapter)`                                     | Returns a `ImmutableList<Verse>` object.   |
| `GetVerses(ushort chapterNumber)`                                    | Returns a `ImmutableList<Verse>` object.   |
| `GetVerses(byte chapter, ushort startVerse, ushort endVerse)`        | Returns a `ImmutableList<Verse>` object.   |
| `GetVerses(ChapterName chapter, ushort startVerse, ushort endVerse)` | Returns a `ImmutableList<Verse>` object.   |

> All the text, and properties are read-only.
