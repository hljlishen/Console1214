using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Layout;
using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Console
{
    public partial class ContentBoard : Form
    {
        public static ContentBoard Instance { get; private set; } = new ContentBoard();
        public ContentBoard()
        {
            InitializeComponent();
            TopLevel = false;
            Dock = DockStyle.Fill;
            FormBorderStyle = FormBorderStyle.None;

            layoutControlItem1.Height = 10;
            layoutControlItem1.HeightType = eLayoutSizeType.Percent;
        }

        public void ToTop() => layoutControl1.ScrollControlIntoView(Title_lab);

        private LayoutControlItem AddControl<T>(T c, Action<T> controlInitializer, Action<LayoutControlItem> ItemInitializer) where T : Control
        {
            LayoutControlItem item = new LayoutControlItem();
            layoutControl1.Controls.Add(c);
            layoutControl1.RootGroup.Items.Add(item);

            controlInitializer?.Invoke(c);
            item.Control = c;
            ItemInitializer?.Invoke(item);
            item.Width = 80;
            item.WidthType = eLayoutSizeType.Percent;
            item.TextLineAlignment = eTextLineAlignment.Middle;
            return item;
        }

        public void AddParagraph(string text, Font font = null, StringAlignment alignment = StringAlignment.Near) => AddText("   " + text, font, alignment);

        public LayoutControlItem AddText(string txt, Font font = null, StringAlignment textAlignment = StringAlignment.Near, StringAlignment textLineAlignment = StringAlignment.Center)
        {
            font = font ?? defaultTextFont;
            var size = CreateGraphics().MeasureString(txt, font);
            LabelX c = new LabelX();
            LayoutControlItem item = AddControl(c, lab => { lab.Text = txt; lab.Font = font; lab.TextAlignment = textAlignment; lab.TextLineAlignment = textLineAlignment; lab.WordWrap = true; }, i => { i.TextVisible = false;  i.Height = (int)size.Height + 15; });
            c.SizeChanged += C_SizeChanged;
            return item;

            void C_SizeChanged(object sender, EventArgs e)
            {
                using (var g = CreateGraphics())
                {
                    var s = g.MeasureString(c.Text, c.Font, c.Width);
                    var s1 = g.MeasureString(c.Text, c.Font);

                    item.Height = (int)s.Height + 40;
                }
            }
        }

        public LayoutControlItem AddPicture(Bitmap bmp, string caption)
        {
            if(!string.IsNullOrEmpty(caption))
                AddText(caption, new Font("宋体", 8), StringAlignment.Center);
            return AddControl(new PictureBox(), pb => { pb.Image = bmp; pb.SizeMode = PictureBoxSizeMode.CenterImage; }, i => { i.TextVisible = false; i.Height = bmp.Height + 101; });
        }

        public LayoutControlItem AddTable(SuperGridControl c, string title)
        {
            var item = AddControl(c, c1 => c1.PrimaryGrid.Caption = new GridCaption(title) { RowHeight = 30}, null) ;
            item.Height = c.Height + 30;
            c.SizeChanged += C_SizeChanged;
            this.SizeChanged += ContentBoard_SizeChanged;

            return item;

            void C_SizeChanged(object sender, EventArgs e)
            {
                var width = 0;
                foreach (var col in c.PrimaryGrid.Columns)
                {
                    width += (col as GridColumn).GetMaximumCellSize(RowScope.AllRows, true).Width;
                }
                item.ControlSize = new Size(width + 37, item.ControlSize.Height);
            }

            void ContentBoard_SizeChanged(object sender, EventArgs e)
            {
                var x = (Width * 0.8 - item.ControlSize.Width) / 2;
                var p = item.Padding;
                p.Left = (int)x;
                item.Padding = p;
            }
        }

        public LayoutControlItem AddForm(Form form)
        {
            return AddControl(form, f => { f.TopLevel = false; f.FormBorderStyle = FormBorderStyle.None; f.Dock = DockStyle.Fill; f.BackColor = layoutControl1.BackColor; f.Show(); }, item => { item.Width = form.Width; item.Height = form.Height; });
        }

        public LayoutControlItem AddTitle(string txt, Font font = null)
        {
            font = font ?? defaultTitleTextFont;
            return AddText(txt, font, StringAlignment.Near, StringAlignment.Far);
        }

        public void AddHorizontalSpacer(int height, eLayoutSizeType sizeType = eLayoutSizeType.Absolute)
        {
            var spacer = new LayoutSpacerItem();
            layoutControl1.RootGroup.Items.Add(spacer);
            spacer.Height = height;
            spacer.HeightType = sizeType;
            spacer.Width = 100;
            spacer.WidthType = eLayoutSizeType.Percent;
        }

        public void Wrapup()
        {
            var spacer = new LayoutSpacerItem();
            layoutControl1.RootGroup.Items.Add(spacer);
            spacer.Height = 150;
            spacer.HeightType = eLayoutSizeType.Absolute;
            spacer.Width = 80;
            spacer.WidthType = eLayoutSizeType.Percent;

            spacer = new LayoutSpacerItem();
            layoutControl1.RootGroup.Items.Add(spacer);
            spacer.Height = 101;
            spacer.HeightType = eLayoutSizeType.Percent;
            spacer.Width = 10;
            spacer.WidthType = eLayoutSizeType.Percent;
        }

        private Font defaultTextFont = new Font("宋体", 16);
        private Font defaultTitleTextFont = new Font("宋体", 16, FontStyle.Bold);

        public string Title { get => Title_lab.Text; set => Title_lab.Text = value; }
    }
}
