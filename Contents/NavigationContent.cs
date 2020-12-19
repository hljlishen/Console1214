using Console.Chapters;
using Console.framework;
using DevComponents.DotNetBar;
using System.Windows.Forms;

namespace Console.Contents
{
    public partial class NavigationContent : Form, IContent
    {
        private ContentBoard board;
        private IChapterBuilder PreviousChapter;
        private IChapterBuilder NextChapter;
        private bool isAnalyzeChaper = false;
        private IChapterBuilder CurrentChapter;
        public NavigationContent(IChapterBuilder current, IChapterBuilder previousChapter, IChapterBuilder nextChapter, bool isAnalyzeChaper = false)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;
            navi_rm.MaxItemPieAngle = 180;
            PreviousChapter = previousChapter;
            NextChapter = nextChapter;
            CurrentChapter = current;

            if (PreviousChapter == null)
                previous_btn.Enabled = false;
            if (NextChapter == null)
                next_btn.Enabled = false;

            this.isAnalyzeChaper = isAnalyzeChaper;
            if(!isAnalyzeChaper)
            {
                FindReason_btn.Text = "";
                FindReason_btn.Symbol = null;
                FindReason_btn.Enabled = false;
            }
            else
            {
                next_btn.Text = "继续排查";
            }
        }

        public int TopSpacing { get; set; } = 20;
        public int BottomSpacing { get; set; } = 20;

        public void ShowContent(ContentBoard board)
        {
            if (TopSpacing > 0)
                board.AddHorizontalSpacer(TopSpacing);

            this.board = board;
            board.AddForm(this);

            if (BottomSpacing > 0)
                board.AddHorizontalSpacer(BottomSpacing);
        }

        private void NavigationContent_SizeChanged(object sender, System.EventArgs e)
        {
            var x = (Size.Width - navi_rm.Width) / 2;
            var y = (Size.Height - navi_rm.Height) / 2;
            navi_rm.Location = new System.Drawing.Point(x, y);
        }

        private void navi_rm_ItemClick(object sender, System.EventArgs e)
        {
            RadialMenuItem item = sender as RadialMenuItem;
            if(item == Top_btn)
            {
                board.ToTop();
            }
            else if(item == FindReason_btn)
            {
                var form = (board.Parent.Parent as Form1);
                form.ShowChapter(new AnalyzeFinishChapter(CurrentChapter.GetChapter().Tag as string));
            }
            else if(item == previous_btn)
            {
                var form = (board.Parent.Parent as Form1);
                form.ShowChapter(PreviousChapter);
            }
            else
            {
                var form = (board.Parent.Parent as Form1);
                form.ShowChapter(NextChapter);
            }
        }
    }
}
