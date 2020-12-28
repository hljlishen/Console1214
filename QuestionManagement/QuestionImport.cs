using Console.framework;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Console.QuestionManagement
{
    public partial class QuestionImport : Form
    {
        private List<RichTextBox> richTextBoxes = new List<RichTextBox>();
        XmlProcess xmlProcess = new XmlInscribe();
        int optionsCount = 4;
        public QuestionImport()
        {
            InitializeComponent();
            import_btn.ColorTable = eButtonColor.BlueWithBackground;
            count_cbi_SelectedIndexChanged();
        }

        private void project_cbe_DropDown(object sender, EventArgs e)
        {
            project_cbe.Items.Clear();
            
            project_cbe.Items.AddRange(xmlProcess.Project_name());
        }

        private void count_cbi_SelectedIndexChanged()
        {
            int count = choose_stc.Tabs.Count;
            if (count > 2)
            {
                for (int i = 2; i <= count - 1; i++)
                {
                    richTextBoxes.Clear();
                    choose_stc.Tabs.Remove(2);
                    correctAnswer_cbe.Items.Clear();
                }
            }
            for (int i = 0; i < optionsCount;)
            {
                RichTextBox richTextBox = new RichTextBox();
                string s = "选项 " + ++i;
                SuperTabItem tab = choose_stc.CreateTab(s);
                correctAnswer_cbe.Items.Add(s);
                richTextBox.Font = new Font("微软雅黑", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                richTextBox.Dock = DockStyle.Fill;
                tab.AttachedControl.Controls.Add(richTextBox);
                richTextBoxes.Add(richTextBox);
            }
        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                string workDir = Directory.GetCurrentDirectory();
                string fileName = workDir + "\\" + project_cbe.Text+".xml";
                Inscribe inscribe = new Inscribe();
                inscribe.Text = title_rtbe.Text;
                inscribe.Candidates.AddRange(from rtb in richTextBoxes
                                             select rtb.Text);
                inscribe.CorrectAnwsers.Add(richTextBoxes[int.Parse(correctAnswer_cbe.Text.Substring(3, 1)) - 1].Text);
                if (xmlProcess.QuestionContains(fileName, inscribe.Text))
                {
                    validation_lab.Text = "试题已存在";
                    return;
                }
                validation_lab.Text = File.Exists($@"{fileName}")
                    ? xmlProcess.CreatNewElement(fileName, new List<Inscribe>() { inscribe }) ? "导入成功" : "导入失败"
                    : xmlProcess.CreatNewXml(fileName, new List<Inscribe>() { inscribe }) ? "导入成功" : "导入失败";
                validation_lab.Visible = true;
            }
        }

        private bool Validation()
        {
            validation_lab.Visible = false;
            if (project_cbe.Text.Equals(""))
            {
                validation_lab.Text = "请选择教学项目";
                validation_lab.Visible = true;
            }
            else if (correctAnswer_cbe.Text.Equals(""))
            {
                validation_lab.Text = "请选择正确答案";
                validation_lab.Visible = true;
            }
            return validation_lab.Visible;
        }

        private void project_cbe_KeyPress(object sender, KeyPressEventArgs e) => ComboBoxEXNotEdit(e);

        private void correctAnswer_cbe_KeyPress(object sender, KeyPressEventArgs e) => ComboBoxEXNotEdit(e);

        private void ComboBoxEXNotEdit(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 || e.KeyChar == 8)  // 控制键
            {
                e.Handled = true;
                return;
            }
            return;
        }
    }
}
