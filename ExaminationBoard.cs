using Console.framework;
using DevComponents.DotNetBar;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Console
{
    public partial class ExaminationBoard : Office2007Form
    {
        private Timer timer = new Timer();
        private TimeSpan timeSpan;
        private Inscribe currentInscribe = null;
        private readonly Font CurrentInscribeIndexFont = new Font("Bahnschrift Condensed", 20, FontStyle.Bold | FontStyle.Underline);
        private readonly Font NormalInscribeIndexFont = new Font("Bahnschrift Condensed", 13);
        public ExaminationBoard()
        {
            InitializeComponent();
            EnableGlass = false;
            TopLevel = false;
            Dock = DockStyle.Fill;
            FormBorderStyle = FormBorderStyle.None;
            next_btn.ColorTable = eButtonColor.BlueOrb;
            next_btn.ImageFixedSize = next_btn.Size;
            previous_btn.ColorTable = eButtonColor.BlueOrb;
            previous_btn.ImageFixedSize = previous_btn.Size;

            finish_btn.ColorTable = eButtonColor.BlueWithBackground;

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeSpan = timeSpan.Subtract(new TimeSpan(0, 0, 1));
            CountDown_lab.Text = timeSpan.ToString();
        }

        private Examination examination;

        public void ShowExamination(Examination e)
        {
            examination = e;
            timeSpan = new TimeSpan(0, e.Time, 0);
            examinationName_lab.Text = e.Name;

            foreach (var inscribe in e.Inscribes)
            {
                //添加按钮
                var b = new ButtonX() { Tag = inscribe, Text = inscribe.Index.ToString(), Size = new Size(40, 40), Font = NormalInscribeIndexFont };
                b.ColorTable = eButtonColor.Orange;
                b.Shape = new RoundRectangleShapeDescriptor(3, 3, 3, 3);
                b.BackColor = Color.Silver;
                b.Click += B_Click;
                navigation_flp.Controls.Add(b);
            }
            ShowCurrentInscribe(e.Inscribes.First());
        }

        private void B_Click(object sender, EventArgs e)
        {
            ShowCurrentInscribe((sender as ButtonX).Tag as Inscribe);
        }

        public void ShowCurrentInscribe(Inscribe inscribe)
        {
            inscribe_lab.Text = $"{inscribe.Index}.{inscribe.Text}";

            //添加答案
            foreach (var c in candidates_flp.Controls)
            {
                var b = c as RadioButton;
                if (b != null)
                    b.Click -= RadioButton_Click;
            }
            candidates_flp.Controls.Clear();
            foreach (var a in inscribe.Candidates)
            {
                RadioButton radioButton = new RadioButton() { Text = a, Tag = inscribe, Font = new Font("幼圆", 20), Height = 40 };
                candidates_flp.Controls.Add(radioButton);
                if (inscribe.HasAnwser() && inscribe.UserAnwsers.First() == a)
                {
                    radioButton.Checked = true;
                }
                radioButton.Click += RadioButton_Click;
            }

            currentInscribe = inscribe;

            #region 处理导航按钮
            next_btn.Enabled = true;
            previous_btn.Enabled = true;
            if (examination.Inscribes.IndexOf(currentInscribe) == examination.Inscribes.Count - 1)
                next_btn.Enabled = false;
            if (examination.Inscribes.IndexOf(currentInscribe) == 0)
                previous_btn.Enabled = false;
            #endregion

            #region 处理答题进度标签
            progress_lab.Text = $"{currentInscribe.Index}/{examination.InscribeCount}";
            #endregion

            #region 处理题号按钮
            foreach (var c in navigation_flp.Controls)
            {
                var b1 = c as ButtonX;
                b1.Font = NormalInscribeIndexFont;
                currentInscribIndicator_hl.SetHighlightColor(b1, DevComponents.DotNetBar.Validator.eHighlightColor.None);
            }
            var button = FindButton(inscribe);
            if (button != null)
            {
                button.Font = CurrentInscribeIndexFont;
                currentInscribIndicator_hl.SetHighlightColor(button, DevComponents.DotNetBar.Validator.eHighlightColor.Orange);
            }
            #endregion

        }

        private ButtonX FindButton(Inscribe i)
        {
            foreach (var c in navigation_flp.Controls)
            {
                var b = c as ButtonX;
                if (b.Tag == i)
                    return b;
            }
            return null;
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            var button = sender as RadioButton;
            var inscribe = button.Tag as Inscribe;
            inscribe.UserAnwsers.Clear();
            inscribe.AddUserAnwser(button.Text);

            foreach (var c in navigation_flp.Controls)
            {
                var b = c as ButtonX;
                if ((b.Tag as Inscribe).HasAnwser())
                    b.BackColor = Color.LightGreen;
                else
                    b.BackColor = Color.Silver;
            }
        }

        private void ExaminationBoard_SizeChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e) => CountDown_lab.Visible = true;

        private void PictureBox1_MouseLeave(object sender, EventArgs e) => CountDown_lab.Visible = false;

        private void next_btn_Click(object sender, EventArgs e)
        {
            var index = examination.Inscribes.IndexOf(currentInscribe);
            ShowCurrentInscribe(examination.Inscribes[index + 1]);
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            var index = examination.Inscribes.IndexOf(currentInscribe);
            ShowCurrentInscribe(examination.Inscribes[index - 1]);
        }

        private void finish_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("提交成绩之后无法修改答案，确定地提交？", "提交确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var score = examination.GetScore();
                inscribe_pl.Controls.Clear();
                progress_pl.Enabled = false;
                navi_pl.Enabled = false;
                finish_btn.Enabled = false;
                LabelX scoreLab = new LabelX() { Text = $"您的得分:{score}/{examination.MaxScore()}", Size = new Size(500, 200), Font = new Font("幼圆", 24, FontStyle.Bold), TextAlignment = StringAlignment.Center };
                inscribe_pl.Controls.Add(scoreLab);
                scoreLab.Location = new Point((inscribe_pl.Width - scoreLab.Width)/2, (inscribe_pl.Height - scoreLab.Height)/2);
            }
        }

        private void finish_btn_MouseEnter(object sender, EventArgs e)
        {
            if (examination.IsAllInscribeAnwsered())
                return;

            ToastNotification.ToastFont = new Font("微软雅黑", 14);
            ToastNotification.Show(content_pl, "有些题目没有给出答案，确定提交？", eToastPosition.BottomCenter);
        }
    }
}
