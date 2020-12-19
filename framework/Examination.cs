using System.Collections.Generic;
using System.Linq;

namespace Console.framework
{
    public class Examination
    {
        public string Name { get; set; }
        public List<Inscribe> Inscribes { get; private set; } = new List<Inscribe>();
        private int currentIndex = 1;
        public float GetScore()
        {
            float score = 0;
            foreach (var i in Inscribes)
            {
                score += i.GetScore();
            }
            return score;
        }

        public void AddInscribe(Inscribe inscribe)
        {
            inscribe.Index = currentIndex++;
            Inscribes.Add(inscribe);
        }

        public bool IsAllInscribeAnwsered()
        {
            foreach (var i in Inscribes)
            {
                if(!i.HasAnwser())
                {
                    return false;
                }
            }
            return true;
        }

        public int Time { get; set; } = 60; //考试时间（分钟）
        public int InscribeCount => Inscribes.Count;
        public float MaxScore() => Inscribes.Sum(i => i.Score);
    }
}
