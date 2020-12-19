using Console.Contents;
using Console.framework;

namespace Console.Chapters
{
    class AnalyzeFinishChapter : IChapterBuilder
    {
        private string reason;

        public AnalyzeFinishChapter(string reason)
        {
            this.reason = reason;
        }

        public Chapter GetChapter()
        {
            Chapter c = new Chapter("故障排查结束");
            c.Contents.Add(new SpacerContent(DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent, 40));
            c.Contents.Add(new TextContent($"故障排查结束:{reason}") { Font = new System.Drawing.Font("宋体", 24, System.Drawing.FontStyle.Bold) });
            return c;
        }
    }
}
