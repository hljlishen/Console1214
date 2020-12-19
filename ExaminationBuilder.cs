using Console.framework;
using System.Collections.Generic;

namespace Console
{
    public class ExaminationBuilder
    {
        private static List<Inscribe> GetInscribes()
        {
            return new List<Inscribe>()
            {
                new Inscribe() {Text = "aaaaaaaaaa", Candidates = new List<string>(){ "aa", "bb", "cc", "ddddddddddddddddddddddddddd"}, CorrectAnwsers = new List<string>(){"aa" } },
                new Inscribe() {Text = "bbbbbbbbbb", Candidates = new List<string>(){ "aa1", "bb1", "cc1", "dd1"}, CorrectAnwsers = new List<string>(){"aa1" } },
                new Inscribe() {Text = "cccccccccc", Candidates = new List<string>(){ "aa2", "bb2", "cc2", "dd2"}, CorrectAnwsers = new List<string>(){"aa2" } },
                new Inscribe() {Text = "ddddddddd", Candidates = new List<string>(){ "aa3", "bb3", "cc3", "dd3"}, CorrectAnwsers = new List<string>(){"aa3" } },
                new Inscribe() {Text = "bbbbbbbbbb", Candidates = new List<string>(){ "aa1", "bb1", "cc1", "dd1"}, CorrectAnwsers = new List<string>(){"aa1" } },
                new Inscribe() {Text = "cccccccccc", Candidates = new List<string>(){ "aa2", "bb2", "cc2", "dd2"}, CorrectAnwsers = new List<string>(){"aa2" } },
                new Inscribe() {Text = "ddddddddd", Candidates = new List<string>(){ "aa3", "bb3", "cc3", "dd3"}, CorrectAnwsers = new List<string>(){"aa3" } },
                new Inscribe() {Text = "bbbbbbbbbb", Candidates = new List<string>(){ "aa1", "bb1", "cc1", "dd1"}, CorrectAnwsers = new List<string>(){"aa1" } },
                new Inscribe() {Text = "cccccccccc", Candidates = new List<string>(){ "aa2", "bb2", "cc2", "dd2"}, CorrectAnwsers = new List<string>(){"aa2" } },
                new Inscribe() {Text = "ddddddddd", Candidates = new List<string>(){ "aa3", "bb3", "cc3", "dd3"}, CorrectAnwsers = new List<string>(){"aa3" } },
                new Inscribe() {Text = "bbbbbbbbbb", Candidates = new List<string>(){ "aa1", "bb1", "cc1", "dd1"}, CorrectAnwsers = new List<string>(){"aa1" } },
                new Inscribe() {Text = "cccccccccc", Candidates = new List<string>(){ "aa2", "bb2", "cc2", "dd2"}, CorrectAnwsers = new List<string>(){"aa2" } },
                new Inscribe() {Text = "ddddddddd", Candidates = new List<string>(){ "aa3", "bb3", "cc3", "dd3"}, CorrectAnwsers = new List<string>(){"aa3" } },
                new Inscribe() {Text = "bbbbbbbbbb", Candidates = new List<string>(){ "aa1", "bb1", "cc1", "dd1"}, CorrectAnwsers = new List<string>(){"aa1" } },
                new Inscribe() {Text = "cccccccccc", Candidates = new List<string>(){ "aa2", "bb2", "cc2", "dd2"}, CorrectAnwsers = new List<string>(){"aa2" } },
                new Inscribe() {Text = "ddddddddd", Candidates = new List<string>(){ "aa3", "bb3", "cc3", "dd3"}, CorrectAnwsers = new List<string>(){"aa3" } },
                new Inscribe() {Text = "bbbbbbbbbb", Candidates = new List<string>(){ "aa1", "bb1", "cc1", "dd1"}, CorrectAnwsers = new List<string>(){"aa1" } },
                new Inscribe() {Text = "cccccccccc", Candidates = new List<string>(){ "aa2", "bb2", "cc2", "dd2"}, CorrectAnwsers = new List<string>(){"aa2" } },
                new Inscribe() {Text = "ddddddddd", Candidates = new List<string>(){ "aa3", "bb3", "cc3", "dd3"}, CorrectAnwsers = new List<string>(){"aa3" } }
            };
        }

        public static Examination GetExamination()
        {
            Examination e = new Examination() { Name = "型号1大吊臂机械缸减速传动回路故障维修" };
            foreach (var i in GetInscribes())
            {
                e.AddInscribe(i);
            }
            return e;
        }
    }
}
