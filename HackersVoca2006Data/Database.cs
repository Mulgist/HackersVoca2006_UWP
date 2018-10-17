using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace HackersVoca2006Data
{
    public static class Database
    {
        // 데이터베이스 초기화
        public static void InitializeDatabase()
        {
            using (SqliteConnection db = new SqliteConnection("Filename=hackersVoca2006.db"))
            {
                db.Open();

                string tableCommand = "CREATE TABLE IF NOT EXISTS Vocabularies (" +
                    "ID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "Day INTEGER NOT NULL, " +
                    "Eng NVARCHAR(128) NOT NULL, " +
                    "Kor1 NVARCHAR(128) NOT NULL, " +
                    "Kor2 NVARCHAR(128) NULL, " +
                    "Kor3 NVARCHAR(128) NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();

                db.Close();

                // 단어 추가 (메인 데이터)
                AddVoca(1, "apt", "~하는 경향이 있는", "적당한", null);
                AddVoca(1, "astonish", "놀라게 하다", null, null);
                AddVoca(1, "chronically", "만성적으로", null, null);
                AddVoca(1, "daub", "흠뻑 칠하다", null, null);
                AddVoca(1, "domain", "지역, 영토", "분야, 영역", null);
                AddVoca(1, "enthusiastic", "열성적인", null, null);
                AddVoca(1, "extend", "(어떤 거리까지) 걸쳐 있다.", "확장하다, 늘리다", null);
                AddVoca(1, "feat", "업적", null, null);
                AddVoca(1, "fulfill", "성취하다", "만족시키다", null);
                AddVoca(1, "give over to", "헌신하다, 바치다", null, null);
                AddVoca(1, "heavy", "무거운; 고된", null, null);
                AddVoca(1, "hibernation", "동면", null, null);
                AddVoca(1, "illusion", "착각, 오해", null, null);
                AddVoca(1, "intrigue", "(주의•관심을) 끌다", "음모를 꾸미다", null);
                AddVoca(1, "luxuriant", "무성한, 풍부한", null, null);
                AddVoca(1, "magnitude", "정도, 크기", null, null);
                AddVoca(1, "maintain", "주장하다", "지속하다", null);
                AddVoca(1, "monitor", "조사하다", null, null);
                AddVoca(1, "outbreak", "(전염병 등의) 만연, 창궐", "폭발", null);
                AddVoca(1, "periodically", "주기적으로", null, null);
                AddVoca(1, "release", "해방시키다", "뿜다, 방출하다", "(묶인 것을) 풀다");
                AddVoca(1, "rendering", "연주, 공연", null, null);
                AddVoca(1, "renowned", "유명한", null, null);
                AddVoca(1, "reproduce", "복제하다", "번식하다", null);
                AddVoca(1, "rugged", "울퉁불퉁한", null, null);
                AddVoca(1, "self-sufficent", "자급자족하는, 제힘으로 살아가는", null, null);
                AddVoca(1, "speculative", "이론적인", "사색적인, 깊이 생각하는", null);
                AddVoca(1, "stimulate", "자극하다, 격려하다", null, null);
                AddVoca(1, "subordinate", "종속적인", null, null);
                AddVoca(1, "torrential", "격렬한", null, null);
            }
        }

        private static void AddVoca(int day, string eng, string kor1, string kor2, string kor3)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=hackersVoca2006.db"))
            {
                db.Open();

                string insertCommand = "INSERT INTO Vocabularies(Day, Eng, Kor1, Kor2, Kor3) SELECT @Day, @Eng, @Kor1, @Kor2, @Kor3 " +
                    "WHERE NOT EXISTS (SELECT Eng FROM Vocabularies WHERE Eng=@Eng);";

                SqliteCommand insertVoca = new SqliteCommand(insertCommand, db);

                insertVoca.Parameters.AddWithValue("@Day", day);
                insertVoca.Parameters.AddWithValue("@Eng", eng);
                insertVoca.Parameters.AddWithValue("@Kor1", kor1);
                if (kor2 == null) insertVoca.Parameters.AddWithValue("@Kor2", DBNull.Value);
                else insertVoca.Parameters.AddWithValue("@Kor2", kor2);
                if (kor3 == null) insertVoca.Parameters.AddWithValue("@Kor3", DBNull.Value);
                else insertVoca.Parameters.AddWithValue("@Kor3", kor3);

                insertVoca.ExecuteReader();

                db.Close();
            }
        }

        public static List<string> GetData()
        {
            List<string> entries = new List<string>();

            using (SqliteConnection db =
                new SqliteConnection("Filename=hackersVoca2006.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Vocabularies", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    entries.Add(query.GetString(3));
                }

                db.Close();
            }

            return entries;
        }

        public static List<List<string>> GetVoca(int day)
        {
            List<List<string>> entries = new List<List<string>>();
            List<string> record = null;

            using (SqliteConnection db =
                new SqliteConnection("Filename=hackersVoca2006.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * FROM Vocabularies WHERE Day = @Day", db);
                selectCommand.Parameters.AddWithValue("@Day", day);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    record = new List<string>();
                    record.Add(query.GetString(2));
                    record.Add(query.GetString(3));
                    if (query.IsDBNull(4)) record.Add(null);
                    else record.Add(query.GetString(4));
                    if (query.IsDBNull(5)) record.Add(null);
                    else record.Add(query.GetString(5));

                    entries.Add(record);
                }

                db.Close();
            }

            return entries;
        }
    }
}
