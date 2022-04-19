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

        public static bool CheckIfHasMuqattaat(ChapterName chapter)
        {
            return CheckIfHasMuqattaat((byte)chapter);
        }

        public static string GetEnumDescription<T>(this T enumValue)
            where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                return null;

            var description = enumValue.ToString();
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
            => ((TEnum[])Enum.GetValues(typeof(TEnum))).ToList();
    }
}