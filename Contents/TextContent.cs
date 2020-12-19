using Console.framework;
using System.Drawing;
using System.Text;

namespace Console.Contents
{
    class TextContent : ContentBase
    {
        public TextContent(string text,int tabNumber = 0)
        {
            Text = text;
            TabNumber = tabNumber;
        }

        public Font Font { get; set; } = new Font("宋体", 16);
        public string Text { get; set; }
        public int TabNumber { get; set; }

        protected override void DoAddContent(ContentBoard board)
        {
            StringBuilder builder = new StringBuilder();
            if (TabNumber > 0)
            {
                for (int i = 0; i < TabNumber; i++)
                    builder.Append("\t");
            }
            builder.Append(Text);
            board.AddText(builder.ToString(), Font);
        }
    }
}
