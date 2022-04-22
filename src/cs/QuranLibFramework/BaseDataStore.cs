using System.Collections.Generic;

namespace QuranLib
{
    internal static class BaseDataStore
    {

        public static IEnumerable<Chapter> GetChapters()
        {
            return new Chapter[]
            {
                new Chapter()
                {
                    Name = ChapterName.AlFatihah,
                    ChapterNumber = 1,
                    Juz = new byte[] {1},
                    ChapterNameArabic = "الفاتحة", ChapterNameEnglish = "The Opening", Ruku = 1, Order = 5
                },
                new Chapter()
                {
                    Name = ChapterName.AlBaqarah,
                    ChapterNumber = 2,
                    Juz = new byte[] {1, 2, 3},
                    ChapterNameArabic = "البقرة", ChapterNameEnglish = "The Cow", Ruku = 40, Order = 87
                },
                new Chapter()
                {
                    Name = ChapterName.AlImran,
                    ChapterNumber = 3,
                    Juz = new byte[] {3, 4},
                    ChapterNameArabic = "آل عمران", ChapterNameEnglish = "The Family of Imraan", Ruku = 20, Order = 89

                },
                new Chapter()
                {
                    Name = ChapterName.AnNisa,
                    ChapterNumber = 4,
                    Juz = new byte[] {4, 6},
                    ChapterNameArabic = "النساء", ChapterNameEnglish = "The Women", Ruku = 24, Order = 92

                },
                new Chapter()
                {
                    Name = ChapterName.AlMaidah,
                    ChapterNumber = 5,
                    Juz = new byte[] {6, 7},
                    ChapterNameArabic = "المائدة", ChapterNameEnglish = "The Table", Ruku = 16, Order = 112

                },
                new Chapter()
                {
                    Name = ChapterName.AlAnam,
                    ChapterNumber = 6,
                    Juz = new byte[] {7, 8},
                    ChapterNameArabic = "الأنعام", ChapterNameEnglish = "The Cattle", Ruku = 20, Order = 55

                },
                new Chapter()
                {
                    Name = ChapterName.AlAraf,
                    ChapterNumber = 7,
                    Juz = new byte[] {8, 9},
                    ChapterNameArabic = "الأعراف", ChapterNameEnglish = "The Heights", Ruku = 24, Order = 39

                },
                new Chapter()
                {
                    Name = ChapterName.AlAnfal,
                    ChapterNumber = 8,
                    Juz = new byte[] {9, 10},
                    ChapterNameArabic = "الأنفال", ChapterNameEnglish = "The Spoils of War", Ruku = 10, Order = 88

                },
                new Chapter()
                {
                    Name = ChapterName.AtTaubah,
                    ChapterNumber = 9,
                    Juz = new byte[] {10, 11},
                    ChapterNameArabic = "التوبة", ChapterNameEnglish = "The Repentance", Ruku = 16, Order = 113

                },
                new Chapter()
                {
                    Name = ChapterName.Yunus,
                    ChapterNumber = 10,
                    Juz = new byte[] {11},
                    ChapterNameArabic = "يونس", ChapterNameEnglish = "Jonas", Ruku = 11, Order = 51

                },
                new Chapter()
                {
                    Name = ChapterName.Hud,
                    ChapterNumber = 11,
                    Juz = new byte[] {11, 12},
                    ChapterNameArabic = "هود", ChapterNameEnglish = "Hud", Ruku = 10, Order = 52

                },
                new Chapter()
                {
                    Name = ChapterName.Yusuf,
                    ChapterNumber = 12,
                    Juz = new byte[] {12, 13},
                    ChapterNameArabic = "يوسف", ChapterNameEnglish = "Joseph", Ruku = 12, Order = 53

                },
                new Chapter()
                {
                    Name = ChapterName.ArRad,
                    ChapterNumber = 13,
                    Juz = new byte[] {13},
                    ChapterNameArabic = "الرعد", ChapterNameEnglish = "The Thunder", Ruku = 6, Order = 96
                },
                new Chapter()
                {
                    Name = ChapterName.Ibrahim,
                    ChapterNumber = 14,
                    Juz = new byte[] {13},
                    ChapterNameArabic = "ابراهيم", ChapterNameEnglish = "Abraham", Ruku = 7, Order = 72
                },
                new Chapter()
                {
                    Name = ChapterName.AlHijr,
                    ChapterNumber = 15,
                    Juz = new byte[] {14},
                    ChapterNameArabic = "الحجر", ChapterNameEnglish = "The Rock", Ruku = 6, Order = 54
                },
                new Chapter()
                {
                    Name = ChapterName.AnNahl,
                    ChapterNumber = 16,
                    Juz = new byte[] {14},
                    ChapterNameArabic = "النحل", ChapterNameEnglish = "The Bee", Ruku = 16, Order = 70
                },
                new Chapter()
                {
                    Name = ChapterName.AlIsra,
                    ChapterNumber = 17,
                    Juz = new byte[] {15},
                    ChapterNameArabic = "الإسراء", ChapterNameEnglish = "The Night Journey", Ruku = 12, Order = 50
                },
                new Chapter()
                {
                    Name = ChapterName.AlKahf,
                    ChapterNumber = 18,
                    Juz = new byte[] {15, 16},
                    ChapterNameArabic = "الكهف", ChapterNameEnglish = "The Cave", Ruku = 12, Order = 69
                },
                new Chapter()
                {
                    Name = ChapterName.Maryam,
                    ChapterNumber = 19,
                    Juz = new byte[] {16},
                    ChapterNameArabic = "مريم", ChapterNameEnglish = "Mary", Ruku = 6, Order = 44
                },
                new Chapter()
                {
                    Name = ChapterName.TaHa,
                    ChapterNumber = 20,
                    Juz = new byte[] {16},
                    ChapterNameArabic = "طه", ChapterNameEnglish = "Taa-Haa", Ruku = 8, Order = 45
                },
                new Chapter()
                {
                    Name = ChapterName.AlAnbiya,
                    ChapterNumber = 21,
                    Juz = new byte[] {17},
                    ChapterNameArabic = "الأنبياء", ChapterNameEnglish = "The Prophets", Ruku = 7, Order = 73
                },
                new Chapter()
                {
                    Name = ChapterName.AlHajj,
                    ChapterNumber = 22,
                    Juz = new byte[] {17},
                    ChapterNameArabic = "الحج", ChapterNameEnglish = "The Pilgrimage", Ruku = 10, Order = 103
                },
                new Chapter()
                {
                    Name = ChapterName.AlMuminun,
                    ChapterNumber = 23,
                    Juz = new byte[] {18},
                    ChapterNameArabic = "المؤمنون", ChapterNameEnglish = "The Believers", Ruku = 6, Order = 74
                },
                new Chapter()
                {
                    Name = ChapterName.AnNur,
                    ChapterNumber = 24,
                    Juz = new byte[] {18},
                    ChapterNameArabic = "النور", ChapterNameEnglish = "The Light", Ruku = 9, Order = 102
                },
                new Chapter()
                {
                    Name = ChapterName.AlFurqan,
                    ChapterNumber = 25,
                    Juz = new byte[] {18, 19},
                    ChapterNameArabic = "الفرقان", ChapterNameEnglish = "The Criterion", Ruku = 6, Order = 42
                },
                new Chapter()
                {
                    Name = ChapterName.AshShuara,
                    ChapterNumber = 26,
                    Juz = new byte[] {19},
                    ChapterNameArabic = "الشعراء", ChapterNameEnglish = "The Poets", Ruku = 11, Order = 47
                },
                new Chapter()
                {
                    Name = ChapterName.AnNaml,
                    ChapterNumber = 27,
                    Juz = new byte[] {19, 20},
                    ChapterNameArabic = "النمل", ChapterNameEnglish = "The Ant", Ruku = 7, Order = 48
                },
                new Chapter()
                {
                    Name = ChapterName.AlQasas,
                    ChapterNumber = 28,
                    Juz = new byte[] {20},
                    ChapterNameArabic = "القصص", ChapterNameEnglish = "The Stories", Ruku = 8, Order = 49
                },
                new Chapter()
                {
                    Name = ChapterName.AlAnkabut,
                    ChapterNumber = 29,
                    Juz = new byte[] {20, 21},
                    ChapterNameArabic = "العنكبوت", ChapterNameEnglish = "The Spider", Ruku = 7, Order = 85
                },
                new Chapter()
                {
                    Name = ChapterName.ArRum,
                    ChapterNumber = 30,
                    Juz = new byte[] {21},
                    ChapterNameArabic = "الروم", ChapterNameEnglish = "The Romans", Ruku = 6, Order = 84
                },
                new Chapter()
                {
                    Name = ChapterName.Luqman,
                    ChapterNumber = 31,
                    Juz = new byte[] {21},
                    ChapterNameArabic = "لقمان", ChapterNameEnglish = "Luqman", Ruku = 3, Order = 57
                },
                new Chapter()
                {
                    Name = ChapterName.AsSajdah,
                    ChapterNumber = 32,
                    Juz = new byte[] {21},
                    ChapterNameArabic = "السجدة", ChapterNameEnglish = "The Prostration", Ruku = 3, Order = 75
                },
                new Chapter()
                {
                    Name = ChapterName.AlAhzab,
                    ChapterNumber = 33,
                    Juz = new byte[] {21, 22},
                    ChapterNameArabic = "الأحزاب", ChapterNameEnglish = "The Clans", Ruku = 9, Order = 90
                },
                new Chapter()
                {
                    Name = ChapterName.Saba,
                    ChapterNumber = 34,
                    Juz = new byte[] {22},
                    ChapterNameArabic = "سبإ", ChapterNameEnglish = "Sheba", Ruku = 6, Order = 58
                },
                new Chapter()
                {
                    Name = ChapterName.Fatir,
                    ChapterNumber = 35,
                    Juz = new byte[] {22},
                    ChapterNameArabic = "فاطر", ChapterNameEnglish = "The Originator", Ruku = 5, Order = 43
                },
                new Chapter()
                {
                    Name = ChapterName.YaSin,
                    ChapterNumber = 36,
                    Juz = new byte[] {22, 23},
                    ChapterNameArabic = "يس", ChapterNameEnglish = "Yaseen", Ruku = 5, Order = 41
                },
                new Chapter()
                {
                    Name = ChapterName.AsSaffat,
                    ChapterNumber = 37,
                    Juz = new byte[] {23},
                    ChapterNameArabic = "الصافات", ChapterNameEnglish = "Those drawn up in Ranks", Ruku = 5, Order = 56
                },
                new Chapter()
                {
                    Name = ChapterName.Sad,
                    ChapterNumber = 38,
                    Juz = new byte[] {23},
                    ChapterNameArabic = "ص", ChapterNameEnglish = "The letter Saad", Ruku = 5, Order = 38
                },
                new Chapter()
                {
                    Name = ChapterName.AzZumar,
                    ChapterNumber = 39,
                    Juz = new byte[] {23, 24},
                    ChapterNameArabic = "الزمر", ChapterNameEnglish = "The Groups", Ruku = 8, Order = 59
                },
                new Chapter()
                {
                    Name = ChapterName.Ghafir,
                    ChapterNumber = 40,
                    Juz = new byte[] {24},
                    ChapterNameArabic = "غافر", ChapterNameEnglish = "The Forgiver", Ruku = 9, Order = 60
                },
                new Chapter()
                {
                    Name = ChapterName.Fussilat,
                    ChapterNumber = 41,
                    Juz = new byte[] {24, 25},
                    ChapterNameArabic = "فصلت", ChapterNameEnglish = "Explained in detail", Ruku = 6, Order = 61
                },
                new Chapter()
                {
                    Name = ChapterName.AshShura,
                    ChapterNumber = 42,
                    Juz = new byte[] {25},
                    ChapterNameArabic = "الشورى", ChapterNameEnglish = "Consultation", Ruku = 5, Order = 62
                },
                new Chapter()
                {
                    Name = ChapterName.AzZukhruf,
                    ChapterNumber = 43,
                    Juz = new byte[] {25},
                    ChapterNameArabic = "الزخرف", ChapterNameEnglish = "Ornaments of gold", Ruku = 7, Order = 63
                },
                new Chapter()
                {
                    Name = ChapterName.AdDukhan,
                    ChapterNumber = 44,
                    Juz = new byte[] {25},
                    ChapterNameArabic = "الدخان", ChapterNameEnglish = "The Smoke", Ruku = 3, Order = 64
                },
                new Chapter()
                {
                    Name = ChapterName.AlJathiyah,
                    ChapterNumber = 45,
                    Juz = new byte[] {25},
                    ChapterNameArabic = "الجاثية", ChapterNameEnglish = "Crouching", Ruku = 4, Order = 65
                },
                new Chapter()
                {
                    Name = ChapterName.AlAhqaf,
                    ChapterNumber = 46,
                    Juz = new byte[] {26},
                    ChapterNameArabic = "الأحقاف", ChapterNameEnglish = "The Dunes", Ruku = 4, Order = 66
                },
                new Chapter()
                {
                    Name = ChapterName.Muhammad,
                    ChapterNumber = 47,
                    Juz = new byte[] {26},
                    ChapterNameArabic = "محمد", ChapterNameEnglish = "Muhammad", Ruku = 4, Order = 95
                },
                new Chapter()
                {
                    Name = ChapterName.AlFath,
                    ChapterNumber = 48,
                    Juz = new byte[] {26},
                    ChapterNameArabic = "الفتح", ChapterNameEnglish = "The Victory", Ruku = 4, Order = 111
                },
                new Chapter()
                {
                    Name = ChapterName.AlHujurat,
                    ChapterNumber = 49,
                    Juz = new byte[] {26},
                    ChapterNameArabic = "الحجرات", ChapterNameEnglish = "The Inner Apartments", Ruku = 2, Order = 106
                },
                new Chapter()
                {
                    Name = ChapterName.Qaf,
                    ChapterNumber = 50,
                    Juz = new byte[] {26},
                    ChapterNameArabic = "ق", ChapterNameEnglish = "The letter Qaaf", Ruku = 3, Order = 34
                },
                new Chapter()
                {
                    Name = ChapterName.AdDhariyat,
                    ChapterNumber = 51,
                    Juz = new byte[] {26, 27},
                    ChapterNameArabic = "الذاريات", ChapterNameEnglish = "The Winnowing Winds", Ruku = 3, Order = 67
                },
                new Chapter()
                {
                    Name = ChapterName.AtTur,
                    ChapterNumber = 52,
                    Juz = new byte[] {27},
                    ChapterNameArabic = "الطور", ChapterNameEnglish = "The Mount", Ruku = 2, Order = 76
                },
                new Chapter()
                {
                    Name = ChapterName.AnNajm,
                    ChapterNumber = 53,
                    Juz = new byte[] {27},
                    ChapterNameArabic = "النجم", ChapterNameEnglish = "The Star", Ruku = 3, Order = 23
                },
                new Chapter()
                {
                    Name = ChapterName.AlQamar,
                    ChapterNumber = 54,
                    Juz = new byte[] {27},
                    ChapterNameArabic = "القمر", ChapterNameEnglish = "The Moon", Ruku = 3, Order = 37
                },
                new Chapter()
                {
                    Name = ChapterName.ArRahman,
                    ChapterNumber = 55,
                    Juz = new byte[] {27},
                    ChapterNameArabic = "الرحمن", ChapterNameEnglish = "The Beneficent", Ruku = 3, Order = 97
                },
                new Chapter()
                {
                    Name = ChapterName.AlWaqiah,
                    ChapterNumber = 56,
                    Juz = new byte[] {27},
                    ChapterNameArabic = "الواقعة", ChapterNameEnglish = "The Inevitable", Ruku = 3, Order = 46
                },
                new Chapter()
                {
                    Name = ChapterName.AlHadeed,
                    ChapterNumber = 57,
                    Juz = new byte[] {27},
                    ChapterNameArabic = "الحديد", ChapterNameEnglish = "The Iron", Ruku = 4, Order = 94
                },
                new Chapter()
                {
                    Name = ChapterName.AlMujadilah,
                    ChapterNumber = 58,
                    Juz = new byte[] {28},
                    ChapterNameArabic = "المجادلة", ChapterNameEnglish = "The Pleading Woman", Ruku = 3, Order = 105
                },
                new Chapter()
                {
                    Name = ChapterName.AlHashr,
                    ChapterNumber = 59,
                    Juz = new byte[] {28},
                    ChapterNameArabic = "الحشر", ChapterNameEnglish = "The Exile", Ruku = 3, Order = 101
                },
                new Chapter()
                {
                    Name = ChapterName.AlMumtahanah,
                    ChapterNumber = 60,
                    Juz = new byte[] {28},
                    ChapterNameArabic = "الممتحنة", ChapterNameEnglish = "She that is to be examined", Ruku = 2, Order = 91
                },
                new Chapter()
                {
                    Name = ChapterName.AsSaff,
                    ChapterNumber = 61,
                    Juz = new byte[] {28},
                    ChapterNameArabic = "الصف", ChapterNameEnglish = "The Ranks", Ruku = 2, Order = 109
                },
                new Chapter()
                {
                    Name = ChapterName.AlJumuah,
                    ChapterNumber = 62,
                    Juz = new byte[] {28},
                    ChapterNameArabic = "الجمعة", ChapterNameEnglish = "Friday", Ruku = 2, Order = 110
                },
                new Chapter()
                {
                    Name = ChapterName.AlMunafiqun,
                    ChapterNumber = 63,
                    Juz = new byte[] {28},
                    ChapterNameArabic = "المنافقون", ChapterNameEnglish = "The Hypocrites", Ruku = 2, Order = 104
                },
                new Chapter()
                {
                    Name = ChapterName.AtTaghabun,
                    ChapterNumber = 64,
                    Juz = new byte[] {28},
                    ChapterNameArabic = "التغابن", ChapterNameEnglish = "Mutual Disillusion", Ruku = 2, Order = 108
                },
                new Chapter()
                {
                    Name = ChapterName.AtTalaq,
                    ChapterNumber = 65,
                    Juz = new byte[] {28},
                    ChapterNameArabic = "الطلاق", ChapterNameEnglish = "Divorce", Ruku = 2, Order = 99
                },
                new Chapter()
                {
                    Name = ChapterName.AtTahreem,
                    ChapterNumber = 66,
                    Juz = new byte[] {28},
                    ChapterNameArabic = "التحريم", ChapterNameEnglish = "The Prohibition", Ruku = 2, Order = 107
                },
                new Chapter()
                {
                    Name = ChapterName.AlMulk,
                    ChapterNumber = 67,
                    Juz = new byte[] {29},
                    ChapterNameArabic = "الملك", ChapterNameEnglish = "The Sovereignty", Ruku = 2, Order = 77
                },
                new Chapter()
                {
                    Name = ChapterName.AlQalam,
                    ChapterNumber = 68,
                    Juz = new byte[] {29},
                    ChapterNameArabic = "القلم", ChapterNameEnglish = "The Pen", Ruku = 2, Order = 2
                },
                new Chapter()
                {
                    Name = ChapterName.AlHaqqah,
                    ChapterNumber = 69,
                    Juz = new byte[] {29},
                    ChapterNameArabic = "الحاقة", ChapterNameEnglish = "The Reality", Ruku = 2, Order = 78
                },
                new Chapter()
                {
                    Name = ChapterName.AlMaaarij,
                    ChapterNumber = 70,
                    Juz = new byte[] {29},
                    ChapterNameArabic = "المعارج", ChapterNameEnglish = "The Ascending Stairways", Ruku = 2, Order = 79
                },
                new Chapter()
                {
                    Name = ChapterName.Nuh,
                    ChapterNumber = 71,
                    Juz = new byte[] {29},
                    ChapterNameArabic = "نوح", ChapterNameEnglish = "Noah", Ruku = 2, Order = 71
                },
                new Chapter()
                {
                    Name = ChapterName.AlJinn,
                    ChapterNumber = 72,
                    Juz = new byte[] {29},
                    ChapterNameArabic = "الجن", ChapterNameEnglish = "The Jinn", Ruku = 2, Order = 40
                },
                new Chapter()
                {
                    Name = ChapterName.AlMuzzammil,
                    ChapterNumber = 73,
                    Juz = new byte[] {29},
                    ChapterNameArabic = "المزمل", ChapterNameEnglish = "The Enshrouded One", Ruku = 2, Order = 3
                },
                new Chapter()
                {
                    Name = ChapterName.AlMuddathir,
                    ChapterNumber = 74,
                    Juz = new byte[] {29},
                    ChapterNameArabic = "المدثر", ChapterNameEnglish = "The Cloaked One", Ruku = 2, Order = 4
                },
                new Chapter()
                {
                    Name = ChapterName.AlQiyamah,
                    ChapterNumber = 75,
                    Juz = new byte[] {29},
                    ChapterNameArabic = "القيامة", ChapterNameEnglish = "The Resurrection", Ruku = 2, Order = 31
                },
                new Chapter()
                {
                    Name = ChapterName.AlInsan,
                    ChapterNumber = 76,
                    Juz = new byte[] {29},
                    ChapterNameArabic = "الانسان", ChapterNameEnglish = "Man", Ruku = 2, Order = 98
                },
                new Chapter()
                {
                    Name = ChapterName.AlMursalat,
                    ChapterNumber = 77,
                    Juz = new byte[] {29},
                    ChapterNameArabic = "المرسلات", ChapterNameEnglish = "The Emissaries", Ruku = 2, Order = 33
                },
                new Chapter()
                {
                    Name = ChapterName.AnNaba,
                    ChapterNumber = 78,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "النبإ", ChapterNameEnglish = "The Announcement", Ruku = 2, Order = 80
                },
                new Chapter()
                {
                    Name = ChapterName.AnNaziat,
                    ChapterNumber = 79,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "النازعات", ChapterNameEnglish = "Those who drag forth", Ruku = 2, Order = 81
                },
                new Chapter()
                {
                    Name = ChapterName.Abasa,
                    ChapterNumber = 80,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "عبس", ChapterNameEnglish = "He frowned", Ruku = 1, Order = 24
                },
                new Chapter()
                {
                    Name = ChapterName.AtTakwir,
                    ChapterNumber = 81,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "التكوير", ChapterNameEnglish = "The Overthrowing", Ruku = 1, Order = 7
                },
                new Chapter()
                {
                    Name = ChapterName.AlInfitar,
                    ChapterNumber = 82,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الإنفطار", ChapterNameEnglish = "The Cleaving", Ruku = 1, Order = 82
                },
                new Chapter()
                {
                    Name = ChapterName.AlMutaffifeen,
                    ChapterNumber = 83,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "المطففين", ChapterNameEnglish = "Defrauding", Ruku = 1, Order = 86
                },
                new Chapter()
                {
                    Name = ChapterName.AlInshiqaq,
                    ChapterNumber = 84,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الإنشقاق", ChapterNameEnglish = "The Splitting Open", Ruku = 1, Order = 83
                },
                new Chapter()
                {
                    Name = ChapterName.AlBuruj,
                    ChapterNumber = 85,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "البروج", ChapterNameEnglish = "The Constellations", Ruku = 1, Order = 27
                },
                new Chapter()
                {
                    Name = ChapterName.AtTariq,
                    ChapterNumber = 86,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الطارق", ChapterNameEnglish = "The Morning Star", Ruku = 1, Order = 36
                },
                new Chapter()
                {
                    Name = ChapterName.AlAla,
                    ChapterNumber = 87,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الأعلى", ChapterNameEnglish = "The Most High", Ruku = 1, Order = 8
                },
                new Chapter()
                {
                    Name = ChapterName.AlGhashiyah,
                    ChapterNumber = 88,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الغاشية", ChapterNameEnglish = "The Overwhelming", Ruku = 1, Order = 68
                },
                new Chapter()
                {
                    Name = ChapterName.AlFajr,
                    ChapterNumber = 89,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الفجر", ChapterNameEnglish = "The Dawn", Ruku = 1, Order = 10
                },
                new Chapter()
                {
                    Name = ChapterName.AlBalad,
                    ChapterNumber = 90,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "البلد", ChapterNameEnglish = "The City", Ruku = 1, Order = 35
                },
                new Chapter()
                {
                    Name = ChapterName.AshShams,
                    ChapterNumber = 91,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الشمس", ChapterNameEnglish = "The Sun", Ruku = 1, Order = 26
                },
                new Chapter()
                {
                    Name = ChapterName.AlLail,
                    ChapterNumber = 92,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الليل", ChapterNameEnglish = "The Night", Ruku = 1, Order = 9
                },
                new Chapter()
                {
                    Name = ChapterName.AdDhuha,
                    ChapterNumber = 93,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الضحى", ChapterNameEnglish = "The Morning Hours", Ruku = 1, Order = 11
                },
                new Chapter()
                {
                    Name = ChapterName.AshSharh,
                    ChapterNumber = 94,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الشرح", ChapterNameEnglish = "The Consolation", Ruku = 1, Order = 12
                },
                new Chapter()
                {
                    Name = ChapterName.AtTin,
                    ChapterNumber = 95,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "التين", ChapterNameEnglish = "The Fig", Ruku = 1, Order = 28
                },
                new Chapter()
                {
                    Name = ChapterName.AlAlaq,
                    ChapterNumber = 96,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "العلق", ChapterNameEnglish = "The Clot", Ruku = 1, Order = 1
                },
                new Chapter()
                {
                    Name = ChapterName.AlQadr,
                    ChapterNumber = 97,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "القدر", ChapterNameEnglish = "The Power, Fate", Ruku = 1, Order = 25
                },
                new Chapter()
                {
                    Name = ChapterName.AlBayyinah,
                    ChapterNumber = 98,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "البينة", ChapterNameEnglish = "The Evidence", Ruku = 1, Order = 100
                },
                new Chapter()
                {
                    Name = ChapterName.AzZalzala,
                    ChapterNumber = 99,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الزلزلة", ChapterNameEnglish = "The Earthquake", Ruku = 1, Order = 93
                },
                new Chapter()
                {
                    Name = ChapterName.AlAdiyat,
                    ChapterNumber = 100,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "العاديات", ChapterNameEnglish = "The Chargers", Ruku = 1, Order = 14
                },
                new Chapter()
                {
                    Name = ChapterName.AlQariah,
                    ChapterNumber = 101,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "القارعة", ChapterNameEnglish = "The Calamity", Ruku = 1, Order = 30
                },
                new Chapter()
                {
                    Name = ChapterName.AtTakathur,
                    ChapterNumber = 102,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "التكاثر", ChapterNameEnglish = "Competition", Ruku = 1, Order = 16
                },
                new Chapter()
                {
                    Name = ChapterName.AlAsr,
                    ChapterNumber = 103,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "العصر", ChapterNameEnglish = "The Declining Day, Epoch", Ruku = 1, Order = 13
                },
                new Chapter()
                {
                    Name = ChapterName.AlHumazah,
                    ChapterNumber = 104,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الهمزة", ChapterNameEnglish = "The Traducer", Ruku = 1, Order = 32
                },
                new Chapter()
                {
                    Name = ChapterName.AlFil,
                    ChapterNumber = 105,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الفيل", ChapterNameEnglish = "The Elephant", Ruku = 1, Order = 19
                },
                new Chapter()
                {
                    Name = ChapterName.Qurayish,
                    ChapterNumber = 106,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "قريش", ChapterNameEnglish = "Quraysh", Ruku = 1, Order = 29
                },
                new Chapter()
                {
                    Name = ChapterName.AlMaun,
                    ChapterNumber = 107,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الماعون", ChapterNameEnglish = "Almsgiving", Ruku = 1, Order = 17
                },
                new Chapter()
                {
                    Name = ChapterName.AlKawthar,
                    ChapterNumber = 108,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الكوثر", ChapterNameEnglish = "Abundance", Ruku = 1, Order = 15
                },
                new Chapter()
                {
                    Name = ChapterName.AlKafirun,
                    ChapterNumber = 109,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الكافرون", ChapterNameEnglish = "The Disbelievers", Ruku = 1, Order = 18
                },
                new Chapter()
                {
                    Name = ChapterName.AnNasr,
                    ChapterNumber = 110,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "النصر", ChapterNameEnglish = "Divine Support", Ruku = 1, Order = 114
                },
                new Chapter()
                {
                    Name = ChapterName.AlMasad,
                    ChapterNumber = 111,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "المسد", ChapterNameEnglish = "The Palm Fibre", Ruku = 1, Order = 6
                },
                new Chapter()
                {
                    Name = ChapterName.AlIkhlas,
                    ChapterNumber = 112,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الإخلاص", ChapterNameEnglish = "Sincerity", Ruku = 1, Order = 22
                },
                new Chapter()
                {
                    Name = ChapterName.AlFalaq,
                    ChapterNumber = 113,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الفلق", ChapterNameEnglish = "The Dawn", Ruku = 1, Order = 20
                },
                new Chapter()
                {
                    Name = ChapterName.AnNas,
                    ChapterNumber = 114,
                    Juz = new byte[] {30},
                    ChapterNameArabic = "الناس", ChapterNameEnglish = "Mankind", Ruku = 1, Order = 21
                },

            };
        }

    }
}