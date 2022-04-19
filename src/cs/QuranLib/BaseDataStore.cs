namespace QuranLib
{
    internal static class BaseDataStore
    {

        public static IEnumerable<Chapter> GetChapters()
        {
            return new Chapter[]
            {
                new()
                {
                    Name = ChapterName.AlFatihah,
                    ChapterNumber = 1,
                    Juz = new byte[] {1},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AlBaqarah,
                    ChapterNumber = 2,
                    Juz = new byte[] {1, 2, 3},
                    Ruku = 40
                },
                new()
                {
                    Name = ChapterName.AlImran,
                    ChapterNumber = 3,
                    Juz = new byte[] {3, 4},
                    Ruku = 20
                },
                new()
                {
                    Name = ChapterName.AnNisa,
                    ChapterNumber = 4,
                    Juz = new byte[] {4, 6},
                    Ruku = 24
                },
                new()
                {
                    Name = ChapterName.AlMaidah,
                    ChapterNumber = 5,
                    Juz = new byte[] {6, 7},
                    Ruku = 16
                },
                new()
                {
                    Name = ChapterName.AlAnam,
                    ChapterNumber = 6,
                    Juz = new byte[] {7, 8},
                    Ruku = 20
                },
                new()
                {
                    Name = ChapterName.AlAraf,
                    ChapterNumber = 7,
                    Juz = new byte[] {8, 9},
                    Ruku = 24
                },
                new()
                {
                    Name = ChapterName.AlAnfal,
                    ChapterNumber = 8,
                    Juz = new byte[] {9, 10},
                    Ruku = 10
                },
                new()
                {
                    Name = ChapterName.AtTaubah,
                    ChapterNumber = 9,
                    Juz = new byte[] {10, 11},
                    Ruku = 16
                },
                new()
                {
                    Name = ChapterName.Yunus,
                    ChapterNumber = 10,
                    Juz = new byte[] {11},
                    Ruku = 11
                },
                new()
                {
                    Name = ChapterName.Hud,
                    ChapterNumber = 11,
                    Juz = new byte[] {11, 12},
                    Ruku = 10
                },
                new()
                {
                    Name = ChapterName.Yusuf,
                    ChapterNumber = 12,
                    Juz = new byte[] {12, 13},
                    Ruku = 12
                },
                new()
                {
                    Name = ChapterName.ArRad,
                    ChapterNumber = 13,
                    Juz = new byte[] {13},
                    Ruku = 6
                },
                new()
                {
                    Name = ChapterName.Ibrahim,
                    ChapterNumber = 14,
                    Juz = new byte[] {13},
                    Ruku = 7
                },
                new()
                {
                    Name = ChapterName.AlHijr,
                    ChapterNumber = 15,
                    Juz = new byte[] {14},
                    Ruku = 6
                },
                new()
                {
                    Name = ChapterName.AnNahl,
                    ChapterNumber = 16,
                    Juz = new byte[] {14},
                    Ruku = 16
                },
                new()
                {
                    Name = ChapterName.AlIsra,
                    ChapterNumber = 17,
                    Juz = new byte[] {15},
                    Ruku = 12
                },
                new()
                {
                    Name = ChapterName.AlKahf,
                    ChapterNumber = 18,
                    Juz = new byte[] {15, 16},
                    Ruku = 12
                },
                new()
                {
                    Name = ChapterName.Maryam,
                    ChapterNumber = 19,
                    Juz = new byte[] {16},
                    Ruku = 6
                },
                new()
                {
                    Name = ChapterName.TaHa,
                    ChapterNumber = 20,
                    Juz = new byte[] {16},
                    Ruku = 8
                },
                new()
                {
                    Name = ChapterName.AlAnbiya,
                    ChapterNumber = 21,
                    Juz = new byte[] {17},
                    Ruku = 7
                },
                new()
                {
                    Name = ChapterName.AlHajj,
                    ChapterNumber = 22,
                    Juz = new byte[] {17},
                    Ruku = 10
                },
                new()
                {
                    Name = ChapterName.AlMuminun,
                    ChapterNumber = 23,
                    Juz = new byte[] {18},
                    Ruku = 6
                },
                new()
                {
                    Name = ChapterName.AnNur,
                    ChapterNumber = 24,
                    Juz = new byte[] {18},
                    Ruku = 9
                },
                new()
                {
                    Name = ChapterName.AlFurqan,
                    ChapterNumber = 25,
                    Juz = new byte[] {18, 19},
                    Ruku = 6
                },
                new()
                {
                    Name = ChapterName.AshShuara,
                    ChapterNumber = 26,
                    Juz = new byte[] {19},
                    Ruku = 11
                },
                new()
                {
                    Name = ChapterName.AnNaml,
                    ChapterNumber = 27,
                    Juz = new byte[] {19, 20},
                    Ruku = 7
                },
                new()
                {
                    Name = ChapterName.AlQasas,
                    ChapterNumber = 28,
                    Juz = new byte[] {20},
                    Ruku = 9
                },
                new()
                {
                    Name = ChapterName.AlAnkabut,
                    ChapterNumber = 29,
                    Juz = new byte[] {20, 21},
                    Ruku = 7
                },
                new()
                {
                    Name = ChapterName.ArRum,
                    ChapterNumber = 30,
                    Juz = new byte[] {21},
                    Ruku = 6
                },
                new()
                {
                    Name = ChapterName.Luqman,
                    ChapterNumber = 31,
                    Juz = new byte[] {21},
                    Ruku = 4
                },
                new()
                {
                    Name = ChapterName.AsSajdah,
                    ChapterNumber = 32,
                    Juz = new byte[] {21},
                    Ruku = 3
                },
                new()
                {
                    Name = ChapterName.AlAhzab,
                    ChapterNumber = 33,
                    Juz = new byte[] {21, 22},
                    Ruku = 9
                },
                new()
                {
                    Name = ChapterName.Saba,
                    ChapterNumber = 34,
                    Juz = new byte[] {22},
                    Ruku = 6
                },
                new()
                {
                    Name = ChapterName.Fatir,
                    ChapterNumber = 35,
                    Juz = new byte[] {22},
                    Ruku = 5
                },
                new()
                {
                    Name = ChapterName.YaSin,
                    ChapterNumber = 36,
                    Juz = new byte[] {22, 23},
                    Ruku = 5
                },
                new()
                {
                    Name = ChapterName.AsSaffat,
                    ChapterNumber = 37,
                    Juz = new byte[] {23},
                    Ruku = 5
                },
                new()
                {
                    Name = ChapterName.Sad,
                    ChapterNumber = 38,
                    Juz = new byte[] {23},
                    Ruku = 5
                },
                new()
                {
                    Name = ChapterName.AzZumar,
                    ChapterNumber = 39,
                    Juz = new byte[] {23, 24},
                    Ruku = 8
                },
                new()
                {
                    Name = ChapterName.Ghafir,
                    ChapterNumber = 40,
                    Juz = new byte[] {24},
                    Ruku = 9
                },
                new()
                {
                    Name = ChapterName.Fussilat,
                    ChapterNumber = 41,
                    Juz = new byte[] {24, 25},
                    Ruku = 6
                },
                new()
                {
                    Name = ChapterName.AshShura,
                    ChapterNumber = 42,
                    Juz = new byte[] {25},
                    Ruku = 5
                },
                new()
                {
                    Name = ChapterName.AzZukhruf,
                    ChapterNumber = 43,
                    Juz = new byte[] {25},
                    Ruku = 7
                },
                new()
                {
                    Name = ChapterName.AdDukhan,
                    ChapterNumber = 44,
                    Juz = new byte[] {25},
                    Ruku = 3
                },
                new()
                {
                    Name = ChapterName.AlJathiyah,
                    ChapterNumber = 45,
                    Juz = new byte[] {25},
                    Ruku = 4
                },
                new()
                {
                    Name = ChapterName.AlAhqaf,
                    ChapterNumber = 46,
                    Juz = new byte[] {26},
                    Ruku = 1 / 2f
                },
                new()
                {
                    Name = ChapterName.Muhammad,
                    ChapterNumber = 47,
                    Juz = new byte[] {26},
                    Ruku = 4
                },
                new()
                {
                    Name = ChapterName.AlFath,
                    ChapterNumber = 48,
                    Juz = new byte[] {26},
                    Ruku = 4
                },
                new()
                {
                    Name = ChapterName.AlHujurat,
                    ChapterNumber = 49,
                    Juz = new byte[] {26},
                    Ruku = 2
                },
                new()
                {
                    Name = ChapterName.Qaf,
                    ChapterNumber = 50,
                    Juz = new byte[] {26},
                    Ruku = 3
                },
                new()
                {
                    Name = ChapterName.AdDhariyat,
                    ChapterNumber = 51,
                    Juz = new byte[] {26, 27},
                    Ruku = 2
                },
                new()
                {
                    Name = ChapterName.AtTur,
                    ChapterNumber = 52,
                    Juz = new byte[] {27},
                    Ruku = 2
                },
                new()
                {
                    Name = ChapterName.AnNajm,
                    ChapterNumber = 53,
                    Juz = new byte[] {27},
                    Ruku = 2
                },
                new()
                {
                    Name = ChapterName.AlQamar,
                    ChapterNumber = 54,
                    Juz = new byte[] {27},
                    Ruku = 2
                },
                new()
                {
                    Name = ChapterName.ArRahman,
                    ChapterNumber = 55,
                    Juz = new byte[] {27},
                    Ruku = 3
                },
                new()
                {
                    Name = ChapterName.AlWaqiah,
                    ChapterNumber = 56,
                    Juz = new byte[] {27},
                    Ruku = 3
                },
                new()
                {
                    Name = ChapterName.AlHadeed,
                    ChapterNumber = 57,
                    Juz = new byte[] {27},
                    Ruku = 4
                },
                new()
                {
                    Name = ChapterName.AlMujadilah,
                    ChapterNumber = 58,
                    Juz = new byte[] {28},
                    Ruku = 3
                },
                new()
                {
                    Name = ChapterName.AlHashr,
                    ChapterNumber = 59,
                    Juz = new byte[] {28},
                    Ruku = 3
                },
                new()
                {
                    Name = ChapterName.AlMumtahanah,
                    ChapterNumber = 60,
                    Juz = new byte[] {28},
                    Ruku = 2
                },
                new()
                {
                    Name = ChapterName.AsSaff,
                    ChapterNumber = 61,
                    Juz = new byte[] {28},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AlJumuah,
                    ChapterNumber = 62,
                    Juz = new byte[] {28},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AlMunafiqun,
                    ChapterNumber = 63,
                    Juz = new byte[] {28},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AtTaghabun,
                    ChapterNumber = 64,
                    Juz = new byte[] {28},
                    Ruku = 2
                },
                new()
                {
                    Name = ChapterName.AtTalaq,
                    ChapterNumber = 65,
                    Juz = new byte[] {28},
                    Ruku = 2
                },
                new()
                {
                    Name = ChapterName.AtTahreem,
                    ChapterNumber = 66,
                    Juz = new byte[] {28},
                    Ruku = 2
                },
                new()
                {
                    Name = ChapterName.AlMulk,
                    ChapterNumber = 67,
                    Juz = new byte[] {29},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AlQalam,
                    ChapterNumber = 68,
                    Juz = new byte[] {29},
                    Ruku = 2
                },
                new()
                {
                    Name = ChapterName.AlHaqqah,
                    ChapterNumber = 69,
                    Juz = new byte[] {29},
                    Ruku = 2
                },
                new()
                {
                    Name = ChapterName.AlMaaarij,
                    ChapterNumber = 70,
                    Juz = new byte[] {29},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.Nuh,
                    ChapterNumber = 71,
                    Juz = new byte[] {29},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AlJinn,
                    ChapterNumber = 72,
                    Juz = new byte[] {29},
                    Ruku = 2
                },
                new()
                {
                    Name = ChapterName.AlMuzzammil,
                    ChapterNumber = 73,
                    Juz = new byte[] {29},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AlMuddathir,
                    ChapterNumber = 74,
                    Juz = new byte[] {29},
                    Ruku = 2
                },
                new()
                {
                    Name = ChapterName.AlQiyamah,
                    ChapterNumber = 75,
                    Juz = new byte[] {29},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AlInsan,
                    ChapterNumber = 76,
                    Juz = new byte[] {29},
                    Ruku = 2
                },
                new()
                {
                    Name = ChapterName.AlMursalat,
                    ChapterNumber = 77,
                    Juz = new byte[] {29},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AnNaba,
                    ChapterNumber = 78,
                    Juz = new byte[] {30},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AnNaziat,
                    ChapterNumber = 79,
                    Juz = new byte[] {30},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.Abasa,
                    ChapterNumber = 80,
                    Juz = new byte[] {30},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AtTakwir,
                    ChapterNumber = 81,
                    Juz = new byte[] {30},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AlInfitar,
                    ChapterNumber = 82,
                    Juz = new byte[] {30},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AlMutaffifeen,
                    ChapterNumber = 83,
                    Juz = new byte[] {30},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AlInshiqaq,
                    ChapterNumber = 84,
                    Juz = new byte[] {30},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AlBuruj,
                    ChapterNumber = 85,
                    Juz = new byte[] {30},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AtTariq,
                    ChapterNumber = 86,
                    Juz = new byte[] {30},
                    Ruku = 1 / 2f
                },
                new()
                {
                    Name = ChapterName.AlAla,
                    ChapterNumber = 87,
                    Juz = new byte[] {30},
                    Ruku = 1 / 2f
                },
                new()
                {
                    Name = ChapterName.AlGhashiyah,
                    ChapterNumber = 88,
                    Juz = new byte[] {30},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AlFajr,
                    ChapterNumber = 89,
                    Juz = new byte[] {30},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AlBalad,
                    ChapterNumber = 90,
                    Juz = new byte[] {30},
                    Ruku = 1 / 2f
                },
                new()
                {
                    Name = ChapterName.AshShams,
                    ChapterNumber = 91,
                    Juz = new byte[] {30},
                    Ruku = 1 / 2f
                },
                new()
                {
                    Name = ChapterName.AlLail,
                    ChapterNumber = 92,
                    Juz = new byte[] {30},
                    Ruku = 1 / 2f
                },
                new()
                {
                    Name = ChapterName.AdDhuha,
                    ChapterNumber = 93,
                    Juz = new byte[] {30},
                    Ruku = 1 / 2f
                },
                new()
                {
                    Name = ChapterName.AshSharh,
                    ChapterNumber = 94,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AtTin,
                    ChapterNumber = 95,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AlAlaq,
                    ChapterNumber = 96,
                    Juz = new byte[] {30},
                    Ruku = 1 / 2f
                },
                new()
                {
                    Name = ChapterName.AlQadr,
                    ChapterNumber = 97,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AlBayyinah,
                    ChapterNumber = 98,
                    Juz = new byte[] {30},
                    Ruku = 1
                },
                new()
                {
                    Name = ChapterName.AzZalzala,
                    ChapterNumber = 99,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AlAdiyat,
                    ChapterNumber = 100,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AlQariah,
                    ChapterNumber = 101,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AtTakathur,
                    ChapterNumber = 102,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AlAsr,
                    ChapterNumber = 103,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AlHumazah,
                    ChapterNumber = 104,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AlFil,
                    ChapterNumber = 105,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.Qurayish,
                    ChapterNumber = 106,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AlMaun,
                    ChapterNumber = 107,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AlKawthar,
                    ChapterNumber = 108,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AlKafirun,
                    ChapterNumber = 109,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AnNasr,
                    ChapterNumber = 110,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AlMasad,
                    ChapterNumber = 111,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AlIkhlas,
                    ChapterNumber = 112,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AlFalaq,
                    ChapterNumber = 113,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },
                new()
                {
                    Name = ChapterName.AnNas,
                    ChapterNumber = 114,
                    Juz = new byte[] {30},
                    Ruku = 1 / 3f
                },

            };
        }

    }
}