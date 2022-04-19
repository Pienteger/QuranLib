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
                    Ruku = 1, TotalVerse = 7
                },
                new Chapter()
                {
                    Name = ChapterName.AlBaqarah,
                    ChapterNumber = 2,
                    Juz = new byte[] {1, 2, 3},
                    Ruku = 40, TotalVerse = 286
                },
                new Chapter()
                {
                    Name = ChapterName.AlImran,
                    ChapterNumber = 3,
                    Juz = new byte[] {3, 4},
                    Ruku = 20, TotalVerse = 200
                },
                new Chapter()
                {
                    Name = ChapterName.AnNisa,
                    ChapterNumber = 4,
                    Juz = new byte[] {4, 6},
                    Ruku = 24, TotalVerse = 176
                },
                new Chapter()
                {
                    Name = ChapterName.AlMaidah,
                    ChapterNumber = 5,
                    Juz = new byte[] {6, 7},
                    Ruku = 16, TotalVerse = 120
                },
                new Chapter()
                {
                    Name = ChapterName.AlAnam,
                    ChapterNumber = 6,
                    Juz = new byte[] {7, 8},
                    Ruku = 20, TotalVerse = 165
                },
                new Chapter()
                {
                    Name = ChapterName.AlAraf,
                    ChapterNumber = 7,
                    Juz = new byte[] {8, 9},
                    Ruku = 24, TotalVerse = 206
                },
                new Chapter()
                {
                    Name = ChapterName.AlAnfal,
                    ChapterNumber = 8,
                    Juz = new byte[] {9, 10},
                    Ruku = 10, TotalVerse = 75
                },
                new Chapter()
                {
                    Name = ChapterName.AtTaubah,
                    ChapterNumber = 9,
                    Juz = new byte[] {10, 11},
                    Ruku = 16, TotalVerse = 129
                },
                new Chapter()
                {
                    Name = ChapterName.Yunus,
                    ChapterNumber = 10,
                    Juz = new byte[] {11},
                    Ruku = 11, TotalVerse = 109
                },
                new Chapter()
                {
                    Name = ChapterName.Hud,
                    ChapterNumber = 11,
                    Juz = new byte[] {11, 12},
                    Ruku = 10, TotalVerse = 123
                },
                new Chapter()
                {
                    Name = ChapterName.Yusuf,
                    ChapterNumber = 12,
                    Juz = new byte[] {12, 13},
                    Ruku = 12, TotalVerse = 111
                },
                new Chapter()
                {
                    Name = ChapterName.ArRad,
                    ChapterNumber = 13,
                    Juz = new byte[] {13},
                    Ruku = 6, TotalVerse = 43
                },
                new Chapter()
                {
                    Name = ChapterName.Ibrahim,
                    ChapterNumber = 14,
                    Juz = new byte[] {13},
                    Ruku = 7, TotalVerse = 52
                },
                new Chapter()
                {
                    Name = ChapterName.AlHijr,
                    ChapterNumber = 15,
                    Juz = new byte[] {14},
                    Ruku = 6, TotalVerse = 99
                },
                new Chapter()
                {
                    Name = ChapterName.AnNahl,
                    ChapterNumber = 16,
                    Juz = new byte[] {14},
                    Ruku = 16, TotalVerse = 128
                },
                new Chapter()
                {
                    Name = ChapterName.AlIsra,
                    ChapterNumber = 17,
                    Juz = new byte[] {15},
                    Ruku = 12, TotalVerse = 111
                },
                new Chapter()
                {
                    Name = ChapterName.AlKahf,
                    ChapterNumber = 18,
                    Juz = new byte[] {15, 16},
                    Ruku = 12, TotalVerse = 110
                },
                new Chapter()
                {
                    Name = ChapterName.Maryam,
                    ChapterNumber = 19,
                    Juz = new byte[] {16},
                    Ruku = 6, TotalVerse = 98
                },
                new Chapter()
                {
                    Name = ChapterName.TaHa,
                    ChapterNumber = 20,
                    Juz = new byte[] {16},
                    Ruku = 8, TotalVerse = 135
                },
                new Chapter()
                {
                    Name = ChapterName.AlAnbiya,
                    ChapterNumber = 21,
                    Juz = new byte[] {17},
                    Ruku = 7, TotalVerse = 112
                },
                new Chapter()
                {
                    Name = ChapterName.AlHajj,
                    ChapterNumber = 22,
                    Juz = new byte[] {17},
                    Ruku = 10, TotalVerse = 78
                },
                new Chapter()
                {
                    Name = ChapterName.AlMuminun,
                    ChapterNumber = 23,
                    Juz = new byte[] {18},
                    Ruku = 6, TotalVerse = 118
                },
                new Chapter()
                {
                    Name = ChapterName.AnNur,
                    ChapterNumber = 24,
                    Juz = new byte[] {18},
                    Ruku = 9, TotalVerse = 64
                },
                new Chapter()
                {
                    Name = ChapterName.AlFurqan,
                    ChapterNumber = 25,
                    Juz = new byte[] {18, 19},
                    Ruku = 6, TotalVerse = 77
                },
                new Chapter()
                {
                    Name = ChapterName.AshShuara,
                    ChapterNumber = 26,
                    Juz = new byte[] {19},
                    Ruku = 11, TotalVerse = 227
                },
                new Chapter()
                {
                    Name = ChapterName.AnNaml,
                    ChapterNumber = 27,
                    Juz = new byte[] {19, 20},
                    Ruku = 7, TotalVerse = 93
                },
                new Chapter()
                {
                    Name = ChapterName.AlQasas,
                    ChapterNumber = 28,
                    Juz = new byte[] {20},
                    Ruku = 9, TotalVerse = 88
                },
                new Chapter()
                {
                    Name = ChapterName.AlAnkabut,
                    ChapterNumber = 29,
                    Juz = new byte[] {20, 21},
                    Ruku = 7, TotalVerse = 69
                },
                new Chapter()
                {
                    Name = ChapterName.ArRum,
                    ChapterNumber = 30,
                    Juz = new byte[] {21},
                    Ruku = 6, TotalVerse = 60
                },
                new Chapter()
                {
                    Name = ChapterName.Luqman,
                    ChapterNumber = 31,
                    Juz = new byte[] {21},
                    Ruku = 4, TotalVerse = 34
                },
                new Chapter()
                {
                    Name = ChapterName.AsSajdah,
                    ChapterNumber = 32,
                    Juz = new byte[] {21},
                    Ruku = 3, TotalVerse = 30
                },
                new Chapter()
                {
                    Name = ChapterName.AlAhzab,
                    ChapterNumber = 33,
                    Juz = new byte[] {21, 22},
                    Ruku = 9, TotalVerse = 73
                },
                new Chapter()
                {
                    Name = ChapterName.Saba,
                    ChapterNumber = 34,
                    Juz = new byte[] {22},
                    Ruku = 6, TotalVerse = 54
                },
                new Chapter()
                {
                    Name = ChapterName.Fatir,
                    ChapterNumber = 35,
                    Juz = new byte[] {22},
                    Ruku = 5, TotalVerse = 45
                },
                new Chapter()
                {
                    Name = ChapterName.YaSin,
                    ChapterNumber = 36,
                    Juz = new byte[] {22, 23},
                    Ruku = 5, TotalVerse = 83
                },
                new Chapter()
                {
                    Name = ChapterName.AsSaffat,
                    ChapterNumber = 37,
                    Juz = new byte[] {23},
                    Ruku = 5, TotalVerse = 182
                },
                new Chapter()
                {
                    Name = ChapterName.Sad,
                    ChapterNumber = 38,
                    Juz = new byte[] {23},
                    Ruku = 5, TotalVerse = 88
                },
                new Chapter()
                {
                    Name = ChapterName.AzZumar,
                    ChapterNumber = 39,
                    Juz = new byte[] {23, 24},
                    Ruku = 8, TotalVerse = 75
                },
                new Chapter()
                {
                    Name = ChapterName.Ghafir,
                    ChapterNumber = 40,
                    Juz = new byte[] {24},
                    Ruku = 9, TotalVerse = 85
                },
                new Chapter()
                {
                    Name = ChapterName.Fussilat,
                    ChapterNumber = 41,
                    Juz = new byte[] {24, 25},
                    Ruku = 6, TotalVerse = 54
                },
                new Chapter()
                {
                    Name = ChapterName.AshShura,
                    ChapterNumber = 42,
                    Juz = new byte[] {25},
                    Ruku = 5, TotalVerse = 53
                },
                new Chapter()
                {
                    Name = ChapterName.AzZukhruf,
                    ChapterNumber = 43,
                    Juz = new byte[] {25},
                    Ruku = 7, TotalVerse = 89
                },
                new Chapter()
                {
                    Name = ChapterName.AdDukhan,
                    ChapterNumber = 44,
                    Juz = new byte[] {25},
                    Ruku = 3, TotalVerse = 59
                },
                new Chapter()
                {
                    Name = ChapterName.AlJathiyah,
                    ChapterNumber = 45,
                    Juz = new byte[] {25},
                    Ruku = 4, TotalVerse = 37
                },
                new Chapter()
                {
                    Name = ChapterName.AlAhqaf,
                    ChapterNumber = 46,
                    Juz = new byte[] {26},
                    Ruku = 1 / 2f, TotalVerse = 35
                },
                new Chapter()
                {
                    Name = ChapterName.Muhammad,
                    ChapterNumber = 47,
                    Juz = new byte[] {26},
                    Ruku = 4, TotalVerse = 38
                },
                new Chapter()
                {
                    Name = ChapterName.AlFath,
                    ChapterNumber = 48,
                    Juz = new byte[] {26},
                    Ruku = 4, TotalVerse = 29
                },
                new Chapter()
                {
                    Name = ChapterName.AlHujurat,
                    ChapterNumber = 49,
                    Juz = new byte[] {26},
                    Ruku = 2, TotalVerse = 18
                },
                new Chapter()
                {
                    Name = ChapterName.Qaf,
                    ChapterNumber = 50,
                    Juz = new byte[] {26},
                    Ruku = 3, TotalVerse = 45
                },
                new Chapter()
                {
                    Name = ChapterName.AdDhariyat,
                    ChapterNumber = 51,
                    Juz = new byte[] {26, 27},
                    Ruku = 2, TotalVerse = 60
                },
                new Chapter()
                {
                    Name = ChapterName.AtTur,
                    ChapterNumber = 52,
                    Juz = new byte[] {27},
                    Ruku = 2, TotalVerse = 49
                },
                new Chapter()
                {
                    Name = ChapterName.AnNajm,
                    ChapterNumber = 53,
                    Juz = new byte[] {27},
                    Ruku = 2, TotalVerse = 62
                },
                new Chapter()
                {
                    Name = ChapterName.AlQamar,
                    ChapterNumber = 54,
                    Juz = new byte[] {27},
                    Ruku = 2, TotalVerse = 55
                },
                new Chapter()
                {
                    Name = ChapterName.ArRahman,
                    ChapterNumber = 55,
                    Juz = new byte[] {27},
                    Ruku = 3, TotalVerse = 78
                },
                new Chapter()
                {
                    Name = ChapterName.AlWaqiah,
                    ChapterNumber = 56,
                    Juz = new byte[] {27},
                    Ruku = 3, TotalVerse = 96
                },
                new Chapter()
                {
                    Name = ChapterName.AlHadeed,
                    ChapterNumber = 57,
                    Juz = new byte[] {27},
                    Ruku = 4, TotalVerse = 29
                },
                new Chapter()
                {
                    Name = ChapterName.AlMujadilah,
                    ChapterNumber = 58,
                    Juz = new byte[] {28},
                    Ruku = 3, TotalVerse = 22
                },
                new Chapter()
                {
                    Name = ChapterName.AlHashr,
                    ChapterNumber = 59,
                    Juz = new byte[] {28},
                    Ruku = 3, TotalVerse = 24
                },
                new Chapter()
                {
                    Name = ChapterName.AlMumtahanah,
                    ChapterNumber = 60,
                    Juz = new byte[] {28},
                    Ruku = 2, TotalVerse = 13
                },
                new Chapter()
                {
                    Name = ChapterName.AsSaff,
                    ChapterNumber = 61,
                    Juz = new byte[] {28},
                    Ruku = 1, TotalVerse = 14
                },
                new Chapter()
                {
                    Name = ChapterName.AlJumuah,
                    ChapterNumber = 62,
                    Juz = new byte[] {28},
                    Ruku = 1, TotalVerse = 11
                },
                new Chapter()
                {
                    Name = ChapterName.AlMunafiqun,
                    ChapterNumber = 63,
                    Juz = new byte[] {28},
                    Ruku = 1, TotalVerse = 11
                },
                new Chapter()
                {
                    Name = ChapterName.AtTaghabun,
                    ChapterNumber = 64,
                    Juz = new byte[] {28},
                    Ruku = 2, TotalVerse = 18
                },
                new Chapter()
                {
                    Name = ChapterName.AtTalaq,
                    ChapterNumber = 65,
                    Juz = new byte[] {28},
                    Ruku = 2, TotalVerse = 12
                },
                new Chapter()
                {
                    Name = ChapterName.AtTahreem,
                    ChapterNumber = 66,
                    Juz = new byte[] {28},
                    Ruku = 2, TotalVerse = 12
                },
                new Chapter()
                {
                    Name = ChapterName.AlMulk,
                    ChapterNumber = 67,
                    Juz = new byte[] {29},
                    Ruku = 1, TotalVerse = 30
                },
                new Chapter()
                {
                    Name = ChapterName.AlQalam,
                    ChapterNumber = 68,
                    Juz = new byte[] {29},
                    Ruku = 2, TotalVerse = 52
                },
                new Chapter()
                {
                    Name = ChapterName.AlHaqqah,
                    ChapterNumber = 69,
                    Juz = new byte[] {29},
                    Ruku = 2, TotalVerse = 52
                },
                new Chapter()
                {
                    Name = ChapterName.AlMaaarij,
                    ChapterNumber = 70,
                    Juz = new byte[] {29},
                    Ruku = 1, TotalVerse = 44
                },
                new Chapter()
                {
                    Name = ChapterName.Nuh,
                    ChapterNumber = 71,
                    Juz = new byte[] {29},
                    Ruku = 1, TotalVerse = 28
                },
                new Chapter()
                {
                    Name = ChapterName.AlJinn,
                    ChapterNumber = 72,
                    Juz = new byte[] {29},
                    Ruku = 2, TotalVerse = 28
                },
                new Chapter()
                {
                    Name = ChapterName.AlMuzzammil,
                    ChapterNumber = 73,
                    Juz = new byte[] {29},
                    Ruku = 1, TotalVerse = 20
                },
                new Chapter()
                {
                    Name = ChapterName.AlMuddathir,
                    ChapterNumber = 74,
                    Juz = new byte[] {29},
                    Ruku = 2, TotalVerse = 56
                },
                new Chapter()
                {
                    Name = ChapterName.AlQiyamah,
                    ChapterNumber = 75,
                    Juz = new byte[] {29},
                    Ruku = 1, TotalVerse = 40
                },
                new Chapter()
                {
                    Name = ChapterName.AlInsan,
                    ChapterNumber = 76,
                    Juz = new byte[] {29},
                    Ruku = 2, TotalVerse = 31
                },
                new Chapter()
                {
                    Name = ChapterName.AlMursalat,
                    ChapterNumber = 77,
                    Juz = new byte[] {29},
                    Ruku = 1, TotalVerse = 50
                },
                new Chapter()
                {
                    Name = ChapterName.AnNaba,
                    ChapterNumber = 78,
                    Juz = new byte[] {30},
                    Ruku = 1, TotalVerse = 40
                },
                new Chapter()
                {
                    Name = ChapterName.AnNaziat,
                    ChapterNumber = 79,
                    Juz = new byte[] {30},
                    Ruku = 1, TotalVerse = 46
                },
                new Chapter()
                {
                    Name = ChapterName.Abasa,
                    ChapterNumber = 80,
                    Juz = new byte[] {30},
                    Ruku = 1, TotalVerse = 42
                },
                new Chapter()
                {
                    Name = ChapterName.AtTakwir,
                    ChapterNumber = 81,
                    Juz = new byte[] {30},
                    Ruku = 1, TotalVerse = 29
                },
                new Chapter()
                {
                    Name = ChapterName.AlInfitar,
                    ChapterNumber = 82,
                    Juz = new byte[] {30},
                    Ruku = 1, TotalVerse = 19
                },
                new Chapter()
                {
                    Name = ChapterName.AlMutaffifeen,
                    ChapterNumber = 83,
                    Juz = new byte[] {30},
                    Ruku = 1, TotalVerse = 36
                },
                new Chapter()
                {
                    Name = ChapterName.AlInshiqaq,
                    ChapterNumber = 84,
                    Juz = new byte[] {30},
                    Ruku = 1, TotalVerse = 25
                },
                new Chapter()
                {
                    Name = ChapterName.AlBuruj,
                    ChapterNumber = 85,
                    Juz = new byte[] {30},
                    Ruku = 1, TotalVerse = 22
                },
                new Chapter()
                {
                    Name = ChapterName.AtTariq,
                    ChapterNumber = 86,
                    Juz = new byte[] {30},
                    Ruku = 1 / 2f, TotalVerse = 17
                },
                new Chapter()
                {
                    Name = ChapterName.AlAla,
                    ChapterNumber = 87,
                    Juz = new byte[] {30},
                    Ruku = 1 / 2f, TotalVerse = 19
                },
                new Chapter()
                {
                    Name = ChapterName.AlGhashiyah,
                    ChapterNumber = 88,
                    Juz = new byte[] {30},
                    Ruku = 1, TotalVerse = 26
                },
                new Chapter()
                {
                    Name = ChapterName.AlFajr,
                    ChapterNumber = 89,
                    Juz = new byte[] {30},
                    Ruku = 1, TotalVerse = 30
                },
                new Chapter()
                {
                    Name = ChapterName.AlBalad,
                    ChapterNumber = 90,
                    Juz = new byte[] {30},
                    Ruku = 1 / 2f, TotalVerse = 20
                },
                new Chapter()
                {
                    Name = ChapterName.AshShams,
                    ChapterNumber = 91,
                    Juz = new byte[] {30},
                    Ruku = 1 / 2f, TotalVerse = 15
                },
                new Chapter()
                {
                    Name = ChapterName.AlLail,
                    ChapterNumber = 92,
                    Juz = new byte[] {30},
                    Ruku = 1 / 2f, TotalVerse = 21
                },
                new Chapter()
                {
                    Name = ChapterName.AdDhuha,
                    ChapterNumber = 93,
                    Juz = new byte[] {30},
                    Ruku = 1 / 2f, TotalVerse = 11
                },
                new Chapter()
                {
                    Name = ChapterName.AshSharh,
                    ChapterNumber = 94,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 8
                },
                new Chapter()
                {
                    Name = ChapterName.AtTin,
                    ChapterNumber = 95,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 8
                },
                new Chapter()
                {
                    Name = ChapterName.AlAlaq,
                    ChapterNumber = 96,
                    Juz = new byte[] {30},
                    Ruku = 1 / 2f, TotalVerse = 19
                },
                new Chapter()
                {
                    Name = ChapterName.AlQadr,
                    ChapterNumber = 97,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 5
                },
                new Chapter()
                {
                    Name = ChapterName.AlBayyinah,
                    ChapterNumber = 98,
                    Juz = new byte[] {30},
                    Ruku = 1, TotalVerse = 8
                },
                new Chapter()
                {
                    Name = ChapterName.AzZalzala,
                    ChapterNumber = 99,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 8
                },
                new Chapter()
                {
                    Name = ChapterName.AlAdiyat,
                    ChapterNumber = 100,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 11
                },
                new Chapter()
                {
                    Name = ChapterName.AlQariah,
                    ChapterNumber = 101,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 11
                },
                new Chapter()
                {
                    Name = ChapterName.AtTakathur,
                    ChapterNumber = 102,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 8
                },
                new Chapter()
                {
                    Name = ChapterName.AlAsr,
                    ChapterNumber = 103,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 3
                },
                new Chapter()
                {
                    Name = ChapterName.AlHumazah,
                    ChapterNumber = 104,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 9
                },
                new Chapter()
                {
                    Name = ChapterName.AlFil,
                    ChapterNumber = 105,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 5
                },
                new Chapter()
                {
                    Name = ChapterName.Qurayish,
                    ChapterNumber = 106,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 4
                },
                new Chapter()
                {
                    Name = ChapterName.AlMaun,
                    ChapterNumber = 107,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 7
                },
                new Chapter()
                {
                    Name = ChapterName.AlKawthar,
                    ChapterNumber = 108,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 3
                },
                new Chapter()
                {
                    Name = ChapterName.AlKafirun,
                    ChapterNumber = 109,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 6
                },
                new Chapter()
                {
                    Name = ChapterName.AnNasr,
                    ChapterNumber = 110,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 3
                },
                new Chapter()
                {
                    Name = ChapterName.AlMasad,
                    ChapterNumber = 111,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 5
                },
                new Chapter()
                {
                    Name = ChapterName.AlIkhlas,
                    ChapterNumber = 112,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 4
                },
                new Chapter()
                {
                    Name = ChapterName.AlFalaq,
                    ChapterNumber = 113,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 5
                },
                new Chapter()
                {
                    Name = ChapterName.AnNas,
                    ChapterNumber = 114,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f, TotalVerse = 6
                },

            };
        }

    }
}