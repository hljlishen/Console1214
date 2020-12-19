using System.Collections.Generic;

namespace Console.framework
{
    public class Chapter : IContent
    {
        public Chapter(string name)
        {
            Name = name;
        }
        public List<IContent> Contents { get; private set; } = new List<IContent>();
        public int TopSpacing { get; set; } = 20;
        public int BottomSpacing { get; set; } = 0;
        public string Name { get; set; } = "";
        public object Tag { get; set; } = null;
        public void ShowContent(ContentBoard board)
        {
            board.Title = Name;
            foreach (var c in Contents)
            {
                c.ShowContent(board);
            }
            board.Wrapup();
        }

        public Chapter Previous { get; set; } = null;
        public Chapter Next { get; set; } = null;
    }
}
