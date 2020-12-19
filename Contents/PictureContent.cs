using Console.framework;
using System.Drawing;

namespace Console.Contents
{
    class PictureContent : ContentBase
    {
        public PictureContent(Bitmap bitmap)
        {
            Bitmap = bitmap;
            TopSpacing = 0;
        }

        public Bitmap Bitmap { get; set; } = null;
        public string Caption { get; set; } = "";
        protected override void DoAddContent(ContentBoard board)
        {
            board.AddPicture(Bitmap, Caption);
        }
    }
}
