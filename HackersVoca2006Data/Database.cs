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
                AddVoca(7, "abolish", "폐지하다", null, null);
                AddVoca(7, "adage", "속담, 금언", null, null);
                AddVoca(7, "aesthetic", "미적인", null, null);
                AddVoca(7, "affect", "~에 영향을 미치다", "~인 체하다", null);
                AddVoca(7, "alteration", "변경", null, null);
                AddVoca(7, "amenity", "편의 시설", null, null);
                AddVoca(7, "approximately", "대략", null, null);
                AddVoca(7, "artisan", "숙련공", null, null);
                AddVoca(7, "bear", "운반하다", "산출하다, 생기게 하다", "(무게를) 지탱하다, 견디다");
                AddVoca(7, "bountiful", "풍부한", null, null);
                AddVoca(7, "constituent", "구성하는, 구성 요소의", null, null);
                AddVoca(7, "dispute", "논쟁하다", "논쟁", null);
                AddVoca(7, "faculty", "능력", null, null);
                AddVoca(7, "field", "분야", null, null);
                AddVoca(7, "guiltless", "결백한", null, null);
                AddVoca(7, "influx", "유입", null, null);
                AddVoca(7, "inundate", "물에 잠기게 하다", null, null);
                AddVoca(7, "lexicon", "어휘", null, null);
                AddVoca(7, "lure", "유혹하다", null, null);
                AddVoca(7, "mixture", "혼합(물)", null, null);
                AddVoca(7, "mount", "오르다", "증가하는", null);
                AddVoca(7, "mundane", "평범한", null, null);
                AddVoca(7, "nearly", "거의", null, null);
                AddVoca(7, "outstrip", "능가하다, 뛰어나다", null, null);
                AddVoca(7, "pertinent", "관련된, 적절한", null, null);
                AddVoca(7, "preclude", "그만두게 하다, 막다", null, null);
                AddVoca(7, "refrain", "삼가다, 중단하다", null, null);
                AddVoca(7, "roughly", "대략", null, null);
                AddVoca(7, "semblance", "외관", "유사한", null);
                AddVoca(7, "sophisticated", "복잡한; 정교한", null, null);
                AddVoca(7, "stage", "단계", null, null);
                AddVoca(7, "thick", "뻑뻑한", null, null);
                AddVoca(7, "thus", "따라서", null, null);
                AddVoca(7, "tiny", "작은", null, null);
                AddVoca(7, "verge", "경계, 찰나", null, null);
                AddVoca(8, "abort", "중단하다", null, null);
                AddVoca(8, "acquire", "얻다", null, null);
                AddVoca(8, "affection", "애정", null, null);
                AddVoca(8, "agree", "동의하다", null, null);
                AddVoca(8, "alert", "경계하는", "경고하는", null);
                AddVoca(8, "allure", "(마음을) 끌다, 유혹하다", null, null);
                AddVoca(8, "amplify", "늘리다", null, null);
                AddVoca(8, "arid", "매마른", null, null);
                AddVoca(8, "ascribe", "~의 탓으로 돌리다", null, null);
                AddVoca(8, "barge", "배", null, null);
                AddVoca(8, "compansate", "보상하다; 보충하다; 상쇄하다", null, null);
                AddVoca(8, "configure", "~의 형체로 만들다", null, null);
                AddVoca(8, "drastic", "과격한, 극단적인", null, null);
                AddVoca(8, "embarrass", "무안케 하다", null, null);
                AddVoca(8, "focus", "집중하다", null, null);
                AddVoca(8, "function", "기능, 역할", "기능하다", null);
                AddVoca(8, "gathering", "수집; 모임", null, null);
                AddVoca(8, "haul", "끌어당기다", null, null);
                AddVoca(8, "immediate", "인접한", null, null);
                AddVoca(8, "increase", "확대하다", null, null);
                AddVoca(8, "loom", "어렴풋이 나타나다", null, null);
                AddVoca(8, "overtax", "지나치게 과세하다", null, null);
                AddVoca(8, "paradox", "모순", null, null);
                AddVoca(8, "pervasive", "퍼지는", null, null);
                AddVoca(8, "pleasing", "마음에 드는, 기분 좋은", null, null);
                AddVoca(8, "primary", "근본적인", null, null);
                AddVoca(8, "proper", "적당한", null, null);
                AddVoca(8, "recur", "재발하다", null, null);
                AddVoca(8, "save for", "~을 제외하고", null, null);
                AddVoca(8, "serve", "소용이 되다, 도움이 되다", null, null);
                AddVoca(8, "simulate", "흉내 내다; 가장하다", null, null);
                AddVoca(8, "speck", "얼룩", "소량", null);
                AddVoca(8, "strive", "노력하다", null, null);
                AddVoca(8, "suppose", "가정하다", null, null);
                AddVoca(8, "surprise", "놀라게 하다", null, null);
                AddVoca(8, "treat", "다루다, 대하다", null, null);
                AddVoca(8, "undertake", "(책임•역할을) 맡다; 착수하다", null, null);
                AddVoca(8, "variant", "변형", null, null);
                AddVoca(9, "abandon", "그만두다, 버리다", null, null);
                AddVoca(9, "antidote", "치료법", null, null);
                AddVoca(9, "at hand", "사용 가능한", null, null);
                AddVoca(9, "bear in mind", "명심하다", null, null);
                AddVoca(9, "boost", "증대시키다", null, null);
                AddVoca(9, "conspicuous", "뚜렷한", null, null);
                AddVoca(9, "critical", "중요한", "위험한", null);
                AddVoca(9, "discriminate", "식별하다", null, null);
                AddVoca(9, "dorsal", "등(부분)의", null, null);
                AddVoca(9, "eliminate", "제거하다", null, null);
                AddVoca(9, "fuse", "녹다, 녹이다", null, null);
                AddVoca(9, "hinterland", "배후지, 오지", null, null);
                AddVoca(9, "in earnest", "진지한", "진지하게", null);
                AddVoca(9, "laden", "(짐을) 실은", null, null);
                AddVoca(9, "lumber", "판재, 재목", null, null);
                AddVoca(9, "mirror", "반영하다", null, null);
                AddVoca(9, "mutual", "상호 간의; 공동의", null, null);
                AddVoca(9, "obtainable", "손에 넣을 수 있는", null, null);
                AddVoca(9, "patch", "수선하다", "작은 부분, 지역", null);
                AddVoca(9, "protest", "항의하다", null, null);
                AddVoca(9, "recall", "회상하다", null, null);
                AddVoca(9, "reflection", "반영", null, null);
                AddVoca(9, "regain", "~을 되찾다", null, null);
                AddVoca(9, "reinforce", "강화하다", null, null);
                AddVoca(9, "relevant", "관련된, 적절한", null, null);
                AddVoca(9, "reminisce", "추억하다", null, null);
                AddVoca(9, "route", "길", null, null);
                AddVoca(9, "secrete", "분비하다", null, null);
                AddVoca(9, "semiarid", "반건조한", null, null);
                AddVoca(9, "soothe", "진정시키다, 완화하다", null, null);
                AddVoca(9, "stay", "머무르다", null, null);
                AddVoca(9, "surplus", "나머지, 잔여", null, null);
                AddVoca(9, "toothed", "들쑥날쑥한", null, null);
                AddVoca(9, "transform", "변형시키다", null, null);
                AddVoca(9, "unbalanced", "균형을 잃은", null, null);
                AddVoca(9, "uniformly", "균일하게", null, null);
                AddVoca(9, "utilitarian", "실용적인", null, null);
                AddVoca(9, "variety", "다양성", "종류", null);
                AddVoca(9, "wonderful", "놀라운", null, null);
                AddVoca(10, "advantage", "이익", null, null);
                AddVoca(10, "arise from", "~에서 기인하다", null, null);
                AddVoca(10, "barrier", "장애물, 장벽", null, null);
                AddVoca(10, "betray", "배신히다", null, null);
                AddVoca(10, "bind", "묶다", null, null);
                AddVoca(10, "blur", "흐리게 하다", null, null);
                AddVoca(10, "circumvent", "우회하다", null, null);
                AddVoca(10, "clumsy", "서투른", null, null);
                AddVoca(10, "commence", "시작하다", null, null);
                AddVoca(10, "conduct", "행동", "(빛•열 등을) 전도하다", null);
                AddVoca(10, "conserve", "보존하다", null, null);
                AddVoca(10, "contradiction", "모순", null, null);
                AddVoca(10, "culminate", "~로 끝나다", null, null);
                AddVoca(10, "delineate", "윤곽을 그리다", null, null);
                AddVoca(10, "donation", "기부(금), 기증(물)", null, null);
                AddVoca(10, "embark on", "시작하다", null, null);
                AddVoca(10, "foundation", "기초", null, null);
                AddVoca(10, "fundamental", "근본적인", null, null);
                AddVoca(10, "handful", "소량, 소수", null, null);
                AddVoca(10, "height", "정상, 절정", null, null);
                AddVoca(10, "identical", "동일한", null, null);
                AddVoca(10, "impediment", "장애", null, null);
                AddVoca(10, "justify", "(정당성을) 증명하다", null, null);
                AddVoca(10, "lament", "슬퍼하다, 애도하다", null, null);
                AddVoca(10, "microorganism", "미생물", null, null);
                AddVoca(10, "origin", "발생, 근원", null, null);
                AddVoca(10, "peculiarity", "특성", null, null);
                AddVoca(10, "physical", "물질의", "육체의", null);
                AddVoca(10, "predict", "예측하다", null, null);
                AddVoca(10, "progress", "발전", null, null);
                AddVoca(10, "scoop", "긁어모으다", null, null);
                AddVoca(10, "score", "얻다", "악보, 악곡", null);
                AddVoca(10, "scrap", "파편", null, null);
                AddVoca(10, "singularly", "각별히", null, null);
                AddVoca(10, "skilled", "숙련된", null, null);
                AddVoca(10, "stem from", "~에서 유래하다", null, null);
                AddVoca(10, "subsidize", "후원하다", null, null);
                AddVoca(10, "unanimity", "(만장)일치", null, null);
                AddVoca(11, "account", "기술(記述)", null, null);
                AddVoca(11, "alloy", "혼합하다", null, null);
                AddVoca(11, "barely", "거의 ~않다", null, null);
                AddVoca(11, "carry on", "~을 계속하다", null, null);
                AddVoca(11, "cohesion", "결속", null, null);
                AddVoca(11, "coincide", "동시에 일어나다", "의견이 일치하다", null);
                AddVoca(11, "colossal", "거대한", null, null);
                AddVoca(11, "considerable", "중요한", "상당한", null);
                AddVoca(11, "converge", "한데 모이다", null, null);
                AddVoca(11, "conviction", "신념", null, null);
                AddVoca(11, "covet", "갈망하다", null, null);
                AddVoca(11, "defect", "결점", null, null);
                AddVoca(11, "defection", "변절, 탈당", null, null);
                AddVoca(11, "dull", "지루한", null, null);
                AddVoca(11, "endeavor", "노력하다, 애쓰다", null, null);
                AddVoca(11, "flock", "무리, 떼", null, null);
                AddVoca(11, "grant", "주다", null, null);
                AddVoca(11, "hustle", "서두르다", "밀다", null);
                AddVoca(11, "intermediate", "중간의", null, null);
                AddVoca(11, "intolerant", "옹졸한, 편협한", null, null);
                AddVoca(11, "kind", "친절한, 인정 많은", "유형, 종류", null);
                AddVoca(11, "limit", "경계, 한계", "제한하다", null);
                AddVoca(11, "margin", "가장자리", null, null);
                AddVoca(11, "militia", "시민군", null, null);
                AddVoca(11, "moreover", "게다가", null, null);
                AddVoca(11, "mecessary", "필수적인", null, null);
                AddVoca(11, "obstruct", "막다, 방해하다", null, null);
                AddVoca(11, "on the spot", "즉시", null, null);
                AddVoca(11, "partial", "편파적인", "불완전한; 부분적인", null);
                AddVoca(11, "placid", "평온한", null, null);
                AddVoca(11, "porsity", "구멍; 다공성", null, null);
                AddVoca(11, "reform", "개정하다, 개선하다", null, null);
                AddVoca(11, "rigid", "단단한, 뻣뻣한", "엄격한", null);
                AddVoca(11, "scarcity", "부족, 결핍", null, null);
                AddVoca(12, "adaptable", "융통성 있는, 적응성 있는", null, null);
                AddVoca(12, "adhesion", "달라붙음, 부착", null, null);
                AddVoca(12, "blame", "비난하다", null, null);
                AddVoca(12, "chaotic", "무질서한", null, null);
                AddVoca(12, "comprehand", "이해하다", null, null);
                AddVoca(12, "decided", "분명한; 단호한", null, null);
                AddVoca(12, "displace", "대체하다", null, null);
                AddVoca(12, "enclose", "에워싸다", null, null);
                AddVoca(12, "entail", "~을 수반하다", null, null);
                AddVoca(12, "excel", "능가하다, 빼어나다", null, null);
                AddVoca(12, "expand", "(시간•노력 등을) 쓰다, 들이다", null, null);
                AddVoca(12, "facility", "재능, 소질", null, null);
                AddVoca(12, "genre", "유형", null, null);
                AddVoca(12, "illustrate", "묘사하다", null, null);
                AddVoca(12, "infrastructure", "기반, 하부 구조", null, null);
                AddVoca(12, "inhibit", "억제하다; 금지하다", null, null);
                AddVoca(12, "involve", "~을 수반하다", null, null);
                AddVoca(12, "lease", "임차하다", null, null);
                AddVoca(12, "likewise", "또한; 마찬가지로", null, null);
                AddVoca(12, "limited", "제한된", null, null);
                AddVoca(12, "lodge in", "박다, 꽂아 넣다", null, null);
                AddVoca(12, "mingle", "섞이다, 혼합되다", null, null);
                AddVoca(12, "obligation", "의무", null, null);
                AddVoca(12, "oblige", "강요하다", null, null);
                AddVoca(12, "offer", "제공하다, 제안하다", null, null);
                AddVoca(12, "on occasion", "가끔", null, null);
                AddVoca(12, "pare", "껍질을 벗기다,	 삭감하다", null, null);
                AddVoca(12, "predominately", "주로", null, null);
                AddVoca(12, "preordained", "예정된", null, null);
                AddVoca(12, "render", "~가 되게 하다", "주다", "~을 표현하다");
                AddVoca(12, "renown", "명성", null, null);
                AddVoca(12, "repel", "물리치다", null, null);
                AddVoca(12, "sanitation", "공중위생", null, null);
                AddVoca(12, "scorching", "몹시 뜨거운(더운)", null, null);
                AddVoca(12, "secluded", "외딴", null, null);
                AddVoca(12, "spare", "절약하다", "주다, (시간을) 할애하다", null);
                AddVoca(12, "stimulating", "활기(자극)을 주는", null, null);
                AddVoca(12, "typify", "대표하다, 특징을 나타내다", null, null);
                AddVoca(12, "wholesale", "대규모의", null, null);
                AddVoca(13, "admire", "존경하다", null, null);
                AddVoca(13, "adroit", "능숙한", null, null);
                AddVoca(13, "ambivalent", "불확실한, 상반된 감정이 교차하는", null, null);
                AddVoca(13, "camouflag", "감추다, 위장하다", null, null);
                AddVoca(13, "composed", "차분한", "작성된", null);
                AddVoca(13, "conceal", "숨기다", null, null);
                AddVoca(13, "deliberate", "신중한", "의도적인", null);
                AddVoca(13, "exhilarate", "들뜨게 하다", null, null);
                AddVoca(13, "exposure", "폭로, 발각", null, null);
                AddVoca(13, "glow", "빛나다", null, null);
                AddVoca(13, "hiatus", "중단, 단절", null, null);
                AddVoca(13, "incinerate", "태우다", null, null);
                AddVoca(13, "ineffectively", "비효과적으로", null, null);
                AddVoca(13, "inert", "자동력이 없는, 움직일 수 없는", null, null);
                AddVoca(13, "luster", "광채", null, null);
                AddVoca(13, "massive", "거대한, 막대한", null, null);
                AddVoca(13, "occupy", "(주의•마음을) 끌다, 사로잡다", null, null);
                AddVoca(13, "precede", "앞서다, 우선하다", null, null);
                AddVoca(13, "prove", "입증하다", null, null);
                AddVoca(13, "purchase", "얻다, 획득하다", null, null);
                AddVoca(13, "restrict", "제한하다", null, null);
                AddVoca(13, "repture", "불화; 파열", "찢다, 파열시키다", null);
                AddVoca(13, "scrutiny", "정밀 조사", null, null);
                AddVoca(13, "seductive", "유혹적인", null, null);
                AddVoca(13, "seep", "스며들다", null, null);
                AddVoca(13, "segment", "부분", null, null);
                AddVoca(13, "shatter", "박살 내다", null, null);
                AddVoca(13, "shock", "충격을 주다, 놀라게 하다", null, null);
                AddVoca(13, "significant", "중요한", null, null);
                AddVoca(13, "slab", "조각", null, null);
                AddVoca(13, "slaughter", "학살하다", null, null);
                AddVoca(13, "strife", "싸움", null, null);
                AddVoca(13, "style", "방식", null, null);
                AddVoca(13, "sustained", "지속적인", null, null);
                AddVoca(13, "temperance", "자제, 절제", null, null);
                AddVoca(13, "tremendous", "엄청난", null, null);
                AddVoca(13, "vivid", "선명한; 생생한", null, null);
                AddVoca(13, "wedge", "억지로 밀어 넣다", null, null);
                AddVoca(14, "actually", "실제로", null, null);
                AddVoca(14, "adorn", "장식하다", null, null);
                AddVoca(14, "calculate", "추정하다, 어림잡다", null, null);
                AddVoca(14, "claim", "요구하다", null, null);
                AddVoca(14, "commemorate", "기념하다", null, null);
                AddVoca(14, "conformity", "일치", null, null);
                AddVoca(14, "copious", "풍부한", null, null);
                AddVoca(14, "desire", "열망하다; 요구하다", null, null);
                AddVoca(14, "diligently", "열심히", null, null);
                AddVoca(14, "enthrall", "매혹하다", null, null);
                AddVoca(14, "feast", "축제", "배불리 먹다", null);
                AddVoca(14, "gather", "모으다", null, null);
                AddVoca(14, "gauge", "평가하다, 판단하다", null, null);
                AddVoca(14, "glue", "접착시키다", null, null);
                AddVoca(14, "grand", "웅장한", null, null);
                AddVoca(14, "hearten", "격려하다", null, null);
                AddVoca(14, "hub", "중심", null, null);
                AddVoca(14, "hybrid", "잡종, 혼합물", null, null);
                AddVoca(14, "impetus", "자극", null, null);
                AddVoca(14, "impovise", "(연주•연설 등을) 즉흥적으로 하다", null, null);
                AddVoca(14, "irresistible", "매혹적인; 저항할 수 없는", null, null);
                AddVoca(14, "incised", "새겨진", null, null);
                AddVoca(14, "inherent in", "내재된", null, null);
                AddVoca(14, "juvenile", "어린", null, null);
                AddVoca(14, "main", "주요한", null, null);
                AddVoca(14, "negligence", "부주의, 태만", null, null);
                AddVoca(14, "outweigh", "~보다 뛰어나다", null, null);
                AddVoca(14, "pigment", "색소", null, null);
                AddVoca(14, "plausible", "그럴듯한", null, null);
                AddVoca(14, "prudent", "조심성 있는, 신중한", null, null);
                AddVoca(14, "revise", "수정하다", null, null);
                AddVoca(14, "spirit", "정신", null, null);
                AddVoca(14, "skillful", "숙련된", null, null);
                AddVoca(14, "tenet", "원칙", null, null);
                AddVoca(14, "transformation", "변화", null, null);
                AddVoca(14, "traverse", "가로지르다", null, null);
                AddVoca(14, "unbearbly", "극도로", null, null);
                AddVoca(14, "variable", "변하기 쉬운", null, null);
                AddVoca(14, "while", "~동안에; ~하는 한", "~할 지라도; ~와는 반대로", null);
                AddVoca(15, "affluent", "부유한, 풍족한", null, null);
                AddVoca(15, "aggravate", "악화시키다", null, null);
                AddVoca(15, "cling to", "달라붙다, 고수하다", null, null);
                AddVoca(15, "craft", "솜씨 있게 만들다", null, null);
                AddVoca(15, "crest", "정상", null, null);
                AddVoca(15, "critic", "비평가", null, null);
                AddVoca(15, "cross-hatching", "음영", null, null);
                AddVoca(15, "decimate", "많은 사람을 죽이다", null, null);
                AddVoca(15, "disciple", "제자", null, null);
                AddVoca(15, "disclose", "(사실 등을) 밝히다", null, null);
                AddVoca(15, "disposition", "성질, 기질", null, null);
                AddVoca(15, "dissimilar", "다른", null, null);
                AddVoca(15, "dominant", "우세하", null, null);
                AddVoca(15, "effect", "영향; 결과", null, null);
                AddVoca(15, "enhance", "향상시키다, 개선하다", null, null);
                AddVoca(15, "enunciate", "분명하게 발음하다", null, null);
                AddVoca(15, "eradicate", "근절하다", null, null);
                AddVoca(15, "harsh", "가혹한", null, null);
                AddVoca(15, "heritage", "전통, 유산", null, null);
                AddVoca(15, "inappropriate", "부적당한", null, null);
                AddVoca(15, "insolent", "무례한", null, null);
                AddVoca(15, "jeopardy", "위험", null, null);
                AddVoca(15, "luxury", "사치", null, null);
                AddVoca(15, "manipulate", "조종하다, 다루다", null, null);
                AddVoca(15, "mock", "조롱하다", null, null);
                AddVoca(15, "precious", "귀중한", null, null);
                AddVoca(15, "regard", "관심; 호감; 존경", null, null);
                AddVoca(15, "return", "되돌아가다", null, null);
                AddVoca(15, "set", "~을 놓다", null, null);
                AddVoca(15, "spacious", "넓은", null, null);
                AddVoca(15, "spectator", "구경꾼", null, null);
                AddVoca(15, "strict", "엄격한", null, null);
                AddVoca(15, "swift", "빠른", null, null);
                AddVoca(15, "synchronize", "동시에 일어나다", null, null);
                AddVoca(15, "throughout", "~의 도처에", null, null);
                AddVoca(15, "undermine", "약화시키다", null, null);
                AddVoca(15, "upset", "뒤엎다, 전복시키다", "당황하게 하다", null);
                AddVoca(15, "virtuous", "덕 있는", null, null);
                AddVoca(15, "wrangle", "논쟁하다; 말다툼하다", null, null);
                AddVoca(15, "withdraw", "물러나다", null, null);
                AddVoca(15, "worship", "숭배하다", null, null);
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

                SqliteCommand selectCommand = new SqliteCommand("SELECT * from Vocabularies", db);

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

            using (SqliteConnection db = new SqliteConnection("Filename=hackersVoca2006.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand("SELECT * FROM Vocabularies WHERE Day = @Day", db);
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
