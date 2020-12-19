using Console.framework;
using DevComponents.DotNetBar.Layout;

namespace Console.Contents
{
    class SpacerContent : IContent
    {
        public SpacerContent(eLayoutSizeType sizeType, int heigth)
        {
            SizeType = sizeType;
            Heigth = heigth;
        }

        public int Heigth { get; private set; }

        public int TopSpacing { get; set; } = 0;
        public int BottomSpacing { get; set; } = 0;

        public eLayoutSizeType SizeType { get; private set; }

        public void ShowContent(ContentBoard board)
        {
            board.AddHorizontalSpacer(Heigth, SizeType);
        }
    }
}
