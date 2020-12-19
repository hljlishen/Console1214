namespace Console.framework
{
    public interface IContent
    {
        void ShowContent(ContentBoard board);
        int TopSpacing { get; set; }
        int BottomSpacing { get; set; }
    }

    public abstract class ContentBase : IContent
    {
        public int TopSpacing { get; set; } = 20;
        public int BottomSpacing { get; set; } = 0;

        public void ShowContent(ContentBoard board)
        {
            if (TopSpacing > 0)
                board.AddHorizontalSpacer(TopSpacing);

            DoAddContent(board);

            if (BottomSpacing > 0)
                board.AddHorizontalSpacer(BottomSpacing);
        }

        protected abstract void DoAddContent(ContentBoard board);
    }
}
