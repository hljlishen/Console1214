using System.Collections.Generic;

namespace Console.framework
{
    public class Anwser
    {
        public Anwser(string text)
        {
            Text = text;
        }
        public string Text { get; set; }
        public bool IsSame(Anwser other) => Text == other.Text;
    }

    public class AnswerComparer : IEqualityComparer<Anwser>
    {
        public bool Equals(Anwser x, Anwser y)
        {
            return x.Text == y.Text;
        }

        public int GetHashCode(Anwser obj) => obj.GetHashCode();
    }
}
