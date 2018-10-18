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
                AddVoca(2, "address", "주소", "강연", null);
                AddVoca(2, "assume", "맡다", "~인 척하다", "~라고 생각하다, 추측히다");
                AddVoca(2, "attain", "도달하다", "성취하다, 이루다", null);
                AddVoca(2, "boast", "자랑하다", null, null);
                AddVoca(2, "capacity", "용적", "능력", null);
                AddVoca(2, "cede", "양도하다, 포기하다", null, null);
                AddVoca(2, "decline", "거절하다", "하락하다, 쇠퇴하다", null);
                AddVoca(2, "desert", "버리다", null, null);
                AddVoca(2, "disassemble", "분해하다", null, null);
                AddVoca(2, "dispose", "배치하다, 배열하다", null, null);
                AddVoca(2, "dispose of", "처리하다", null, null);
                AddVoca(2, "erode", "침식하다, 부식되다", null, null);
                AddVoca(2, "fairly", "꽤", "공정하게", null);
                AddVoca(2, "glossy", "빛나는, 광택이 나는", null, null);
                AddVoca(2, "grounds", "근거, 이유", null, null);
                AddVoca(2, "hallmark", "특징", null, null);
                AddVoca(2, "ideal", "이상적인, 전형의", "관념적인, 추상적인", null);
                AddVoca(2, "inhabit", "거주하다", null, null);
                AddVoca(2, "laborious", "근면한", null, null);
                AddVoca(2, "linger", "남다", "꾸물거리다, 질질 끌다", null);
                AddVoca(2, "loathe", "혐오하다", null, null);
                AddVoca(2, "mimic", "모방하다", null, null);
                AddVoca(2, "model", "견본", null, null);
                AddVoca(2, "observe", "관찰하다; 알아채다", "준수하다", null);
                AddVoca(2, "plentiful", "풍부한", null, null);
                AddVoca(2, "preoccupied", "몰두한", null, null);
                AddVoca(2, "property", "자산", "특성", null);
                AddVoca(2, "recurring", "되풀이되는", null, null);
                AddVoca(2, "rooted", "뿌리 깊은, 정착한", null, null);
                AddVoca(2, "thoroughly", "철저히, 완전히", null, null);
                AddVoca(3, "afford", "주다", null, null);
                AddVoca(3, "announce", "공포하다", null, null);
                AddVoca(3, "a wide range of", "다양한", null, null);
                AddVoca(3, "chance", "가능성; 기회", null, null);
                AddVoca(3, "chart", "(지도 등을) 작성하다", null, null);
                AddVoca(3, "engage", "약속하다", "예약하다", "고용하다");
                AddVoca(3, "esteem", "존경하다, 중하게 여기다", null, null);
                AddVoca(3, "evidence", "증거; 징후", null, null);
                AddVoca(3, "fertile", "비옥한", null, null);
                AddVoca(3, "generate", "발생시키다", null, null);
                AddVoca(3, "innate", "타고난", null, null);
                AddVoca(3, "invaluable", "매우 귀중한", null, null);
                AddVoca(3, "irreparable", "돌이킬 수 없는", null, null);
                AddVoca(3, "maxim", "격언; 행동 원칙", null, null);
                AddVoca(3, "object", "항의하다", "목적", null);
                AddVoca(3, "outstanding", "뛰어난", "미결제의", null);
                AddVoca(3, "patron", "후원자", "고객", null);
                AddVoca(3, "predominate", "우세하다, 지배력을 갖다", null, null);
                AddVoca(3, "previous", "이전의", null, null);
                AddVoca(3, "premise", "전제", null, null);
                AddVoca(3, "primitive", "원시적인", "기본적인", null);
                AddVoca(3, "proficiency", "능숙함", null, null);
                AddVoca(3, "proposition", "제안", null, null);
                AddVoca(3, "questionable", "의심스러운", null, null);
                AddVoca(3, "rife with", "가득 찬, 수없이 많은", null, null);
                AddVoca(3, "shield", "보호하다", null, null);
                AddVoca(3, "solitary", "외딴, 고독한", null, null);
                AddVoca(3, "stick", "달라붙다, 고수하다", null, null);
                AddVoca(3, "sitmulus", "자극, 격려", null, null);
                AddVoca(3, "stir", "자극하다", null, null);
                AddVoca(3, "taboo", "금기", null, null);
                AddVoca(3, "thrive", "번성하다", null, null);
                AddVoca(3, "vagary", "예측 불허의 변화, 변덕", null, null);
                AddVoca(3, "wane", "감소하다, 쇠퇴하다", null, null);
                AddVoca(3, "view", "견해, 의견", "간주하다", null);
                AddVoca(4, "achieve", "성취하다", null, null);
                AddVoca(4, "anchor", "고정시키다", "닻", null);
                AddVoca(4, "attribute", "~의 탓으로 돌리다", "특성", null);
                AddVoca(4, "brisk", "활기 있는", null, null);
                AddVoca(4, "codify", "(체계적으로) 정리하다", null, null);
                AddVoca(4, "consummate", "뛰어난; 완전한", null, null);
                AddVoca(4, "descent", "하강", "혈통, 기원", null);
                AddVoca(4, "disseminate", "퍼뜨리다", null, null);
                AddVoca(4, "earn", "획득하다", null, null);
                AddVoca(4, "emergence", "출현, 부상", null, null);
                AddVoca(4, "facilitate", "용이하게 하다", null, null);
                AddVoca(4, "fervent", "열정적인", null, null);
                AddVoca(4, "fine", "미세한, 섬세한; 가느다란", null, null);
                AddVoca(4, "frivolous", "사소한", null, null);
                AddVoca(4, "giant", "거인", null, null);
                AddVoca(4, "golden age", "황금 시대, 전성기", null, null);
                AddVoca(4, "grasp", "붙잡다", "이해하다, 파악하다", null);
                AddVoca(4, "hamstrung", "무력한; 불구의", null, null);
                AddVoca(4, "haphazard", "되는대로의, 우연의", null, null);
                AddVoca(4, "incidental", "중요하지 않은; 우연한", null, null);
                AddVoca(4, "initiate", "시작하다", null, null);
                AddVoca(4, "make up", "창작하다, 창안하다", null, null);
                AddVoca(4, "manifold", "가지각색의", null, null);
                AddVoca(4, "obliterate", "제거하다", null, null);
                AddVoca(4, "period", "시대", null, null);
                AddVoca(4, "proceed", "나아가다", null, null);
                AddVoca(4, "procure", "얻다", null, null);
                AddVoca(4, "professional", "전문적인", null, null);
                AddVoca(4, "redundancy", "여분; 장황", null, null);
                AddVoca(4, "responsible", "책임이 있는", null, null);
                AddVoca(4, "sharp", "날카로운, 예리한", "급격한", null);
                AddVoca(4, "supplement", "보충하다", "추가, 부가", null);
                AddVoca(4, "suspend", "연기하다", "중지하다", "매달다");
                AddVoca(4, "tailored", "맞추어진", null, null);
                AddVoca(5, "aimlessly", "목적 없이", null, null);
                AddVoca(5, "ally", "~와 동맹하다, 연합하다", null, null);
                AddVoca(5, "anonymous", "익명의", null, null);
                AddVoca(5, "anticipate", "예견하다", null, null);
                AddVoca(5, "archaic", "원시적인; 구식의", null, null);
                AddVoca(5, "asset", "자질, 자산", "이점, 장점", null);
                AddVoca(5, "behavior", "행동", null, null);
                AddVoca(5, "ceaseless", "끊임없는", null, null);
                AddVoca(5, "change", "변화시키다", null, null);
                AddVoca(5, "confederacy", "연합, 동맹", null, null);
                AddVoca(5, "cut", "절단하다", null, null);
                AddVoca(5, "disturbance", "동요, 혼란", null, null);
                AddVoca(5, "elucidate", "명료하게 하다", null, null);
                AddVoca(5, "encroachment", "침범", null, null);
                AddVoca(5, "entice", "유혹하다", null, null);
                AddVoca(5, "equivocally", "애매하게", null, null);
                AddVoca(5, "exterminate", "근절하다", null, null);
                AddVoca(5, "fortify", "강화하다", null, null);
                AddVoca(5, "formerly", "이전에", null, null);
                AddVoca(5, "immunity", "면제", null, null);
                AddVoca(5, "improve", "개선하다", null, null);
                AddVoca(5, "in retrospect", "되돌아보면, 회상하면", null, null);
                AddVoca(5, "lose sight of", "잊다", null, null);
                AddVoca(5, "nuts and bolts", "기본", null, null);
                AddVoca(5, "permit", "허락하다", null, null);
                AddVoca(5, "radical", "근본적인", "급진적인", null);
                AddVoca(5, "rarely", "드물게, 좀처럼 ~않는", null, null);
                AddVoca(5, "sparse", "빈약한, 부족한", null, null);
                AddVoca(5, "sting", "얼얼하다, 쓰리다", null, null);
                AddVoca(5, "support", "지지하다", "부양하다", null);
                AddVoca(5, "tangible", "실질적인", null, null);
                AddVoca(5, "tolerate", "견디다", null, null);
                AddVoca(5, "train", "~로 향하게 하다", null, null);
                AddVoca(5, "unambiguous", "명확한", null, null);
                AddVoca(5, "virtually", "사실상", "거의", null);
                AddVoca(5, "wary", "조심(경계)하는", null, null);
                AddVoca(5, "wealth", "풍부함", null, null);
                AddVoca(5, "wiggle", "이리저리 흔들다", null, null);
                AddVoca(6, "agile", "민첩한", null, null);
                AddVoca(6, "ample", "넓은", "충분한", null);
                AddVoca(6, "arbitrarily", "임의로", null, null);
                AddVoca(6, "attest", "입증하다", null, null);
                AddVoca(6, "break with", "관계를 끊다", null, null);
                AddVoca(6, "brightness", "빛", null, null);
                AddVoca(6, "conjure", "불러내다, 상기시키다", "간청하다", null);
                AddVoca(6, "contrive", "고안해내다", null, null);
                AddVoca(6, "correspondence", "일치", "(편지로 하는) 통신", null);
                AddVoca(6, "durable", "지속적인", null, null);
                AddVoca(6, "dwarf", "난쟁이", null, null);
                AddVoca(6, "enigmatic", "알기 어려운", null, null);
                AddVoca(6, "extinct", "멸종된", null, null);
                AddVoca(6, "fabricate", "만들어내다", null, null);
                AddVoca(6, "flake", "파편", null, null);
                AddVoca(6, "harm", "손해", null, null);
                AddVoca(6, "innocent", "결백한", null, null);
                AddVoca(6, "in the course of", "~동안에", null, null);
                AddVoca(6, "in vain", "헛되이", null, null);
                AddVoca(6, "inconsequential", "하찮은, 사소한", null, null);
                AddVoca(6, "leave", "떠나다", null, null);
                AddVoca(6, "liken", "비유하다", null, null);
                AddVoca(6, "literally", "실제로", null, null);
                AddVoca(6, "moderate", "온건한", null, null);
                AddVoca(6, "prolong", "연장하다", null, null);
                AddVoca(6, "purify", "정화하다, 깨끗이 하다", null, null);
                AddVoca(6, "resonable", "이치에 맞는", null, null);
                AddVoca(6, "refined", "정제된", null, null);
                AddVoca(6, "retain", "유지(보유)하다", null, null);
                AddVoca(6, "scarce", "드문; 부족한", null, null);
                AddVoca(6, "scope", "범위", null, null);
                AddVoca(6, "shabby", "초라한", null, null);
                AddVoca(6, "short-lived", "단기간의", null, null);
                AddVoca(6, "solidify", "결속시키다", null, null);
                AddVoca(6, "substantial", "튼튼한", "상당한", null);
                AddVoca(6, "vacant", "텅 빈", null, null);
                AddVoca(6, "wizened", "시든, 주름진", null, null);
                AddVoca(6, "zone", "지역", null, null);
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
