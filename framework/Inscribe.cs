using System.Collections.Generic;

namespace Console.framework
{
    public class Inscribe
    {
        public int Index { get; set; }
        public string Text { get; set; }
        public List<string> Candidates { get; set; } = new List<string>();
        public List<string> CorrectAnwsers { get; set; } = new List<string>();
        public List<string> UserAnwsers { get; set; } = new List<string>();
        public float Score { get; set; } = 2;
        public bool HasAnwser() => UserAnwsers.Count > 0;
        public float GetScore() => IsCorrect() ? 2 : 0;
        public void AddUserAnwser(string a)
        {
            if (UserAnwsers.Contains(a))
                return;
            UserAnwsers.Add(a);
        }
        public void RemoveUserAnwser(string a)
        {
            if (!UserAnwsers.Contains(a))
                return;
            UserAnwsers.Remove(a);
        }
        public bool IsCorrect()
        {
            if (UserAnwsers.Count == 0)
                return false;
            if (UserAnwsers.Count != CorrectAnwsers.Count)
                return false;
            else
            {
                foreach (var a in UserAnwsers)
                {
                    if (!CorrectAnwsers.Contains(a))
                        return false;
                }
                return true;
            }
        }
    }
}
