using System.ComponentModel;
using System.Reflection;
namespace QuranLib
{
    internal static class Utils
    {
        public static PlaceOfRevelation GetPlaceOfRevelation(byte chapter)
        {
            var madaniChapters = new byte[]
            {
                2, 3, 4, 5, 8, 9, 22, 24, 33, 47,
                48, 49, 55, 57, 58, 59, 60, 61,
                62, 63, 64, 65, 66, 76, 98, 110
            };

            return madaniChapters.Contains(chapter) ? PlaceOfRevelation.Madinah : PlaceOfRevelation.Makkah;
        }

        public static PlaceOfRevelation GetPlaceOfRevelation(ChapterName chapter)
        {
            return GetPlaceOfRevelation((byte)chapter);
        }

        public static bool CheckIfHasMuqattaat(byte chapter)
        {
            var muqattaatChapters = new byte[]
            {
                2, 3, 7, 10, 11, 12, 13, 14, 15, 19, 20, 26,
                27, 28, 29, 30, 31, 32, 36, 38, 40, 41, 42, 43,
                44, 45, 46, 50, 68
            };
            return muqattaatChapters.Contains(chapter);
        }

        public static SajdaType GetSajdaType(ChapterName chapterName, ushort verseNumber)
        {
            var sajdaDict = new Dictionary<string, SajdaType>
            {
                { "22 + 18", SajdaType.Recommended },
                { "22 + 77", SajdaType.Recommended },
                { "27 + 26", SajdaType.Recommended },
                { "41 + 38", SajdaType.Obligatory },
                { "13 + 15", SajdaType.Recommended },
                { "17 + 109", SajdaType.Recommended },
                { "96 + 19", SajdaType.Obligatory },
                { "32 + 15", SajdaType.Obligatory },
                { "7 + 206", SajdaType.Recommended },
                { "16 + 50", SajdaType.Recommended },
                { "19 + 58", SajdaType.Recommended },
                { "38 + 24", SajdaType.Recommended },
                { "84 + 21", SajdaType.Recommended },
                { "53 + 62", SajdaType.Obligatory },
                { "25 + 60", SajdaType.Recommended }
            };

            var key = $"{(int)chapterName} + {verseNumber}";
            return sajdaDict.TryGetValue(key, out SajdaType value) ? value : SajdaType.None;
        }
        public static bool CheckIfHasMuqattaat(ChapterName chapter)
        {
            return CheckIfHasMuqattaat((byte)chapter);
        }

        public static string GetEnumDescription<T>(this T enumValue)
            where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                return string.Empty;

            string description = enumValue.ToString() ?? string.Empty;
            FieldInfo? fieldInfo = enumValue.GetType().GetField(enumValue.ToString() ?? string.Empty);

            if (fieldInfo == null) return description;
            object[] attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
            if (attrs is { Length: > 0 })
            {
                description = ((DescriptionAttribute)attrs[0]).Description;
            }

            return description;
        }

        public static List<TEnum> GetEnumList<TEnum>() where TEnum : Enum
        {
            return ((TEnum[])Enum.GetValues(typeof(TEnum))).ToList();
        }
    }
}