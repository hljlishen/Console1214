using Console.Contents;
using System.Drawing;

namespace Console.framework
{
    public interface IChapterBuilder
    {
        Chapter GetChapter();
    }

    public static class ChapterBuilderExt
    {
        public static void AddTextTitle(this IChapterBuilder builder, Chapter c, string text)
        {
            c.Contents.Add(new TextContent(text, 1) { Font = new System.Drawing.Font("宋体", 20, FontStyle.Bold) });
        }

        public static void AddText(this IChapterBuilder b, Chapter c, string txt)
        {
            c.Contents.Add(new TextContent(txt, 1) { TopSpacing = 0 });
        }

        public static void AddPicture(this IChapterBuilder b, Chapter c, Bitmap bmp, string caption = "")
        {
            c.Contents.Add(new PictureContent(bmp) { Caption = caption });
        }
    }
}
