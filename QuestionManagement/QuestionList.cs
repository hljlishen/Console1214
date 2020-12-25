using Console.framework;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console.QuestionManagement
{
    public partial class QuestionList : Form
    {
        XmlProcess xmlProcess = new XmlInscribe();
        string workDir = Directory.GetCurrentDirectory();
        public QuestionList()
        {
            InitializeComponent();
            GridPanel panel = titlelist_sgc.PrimaryGrid;
            GridColumn column = panel.Columns["菜单"];
            column.EditorType = typeof(MyGridRadialMenuEditControl);
            List<Inscribe> inscribes_ = new List<Inscribe>();
            foreach (var s in xmlProcess.Project_name())
            {
                string fileName = workDir + "\\" + s + ".xml";
                List<Inscribe> inscribes = xmlProcess.AllData(fileName);
                inscribes_ = inscribes_.Concat(inscribes).ToList();
                SuperGridControl(inscribes,s);
            }
            titleNumber_btn.Text = $"试题总数：{inscribes_.Count}";
        }

        private void project_cbe_DropDown(object sender, EventArgs e)
        {
            project_cbe.Items.Clear();
            project_cbe.Items.AddRange(xmlProcess.Project_name());
        }

        private void ComboBoxEXNotEdit(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 || e.KeyChar == 8)  // 控制键
            {
                e.Handled = true;
                return;
            }
            return;
        }

        private void project_cbe_KeyPress(object sender, KeyPressEventArgs e) => ComboBoxEXNotEdit(e);

        private void SuperGridControl(List<Inscribe> inscribes,object s)
        {
            foreach (var i in inscribes)
            {
                GridRow dfr = titlelist_sgc.PrimaryGrid.NewRow();
                dfr[1].Value = s;
                dfr[2].Value = i.Text;
                dfr[3].Value = new RadialMenuItem();
                titlelist_sgc.PrimaryGrid.Rows.Add(dfr);
            }
        }

        private void project_cbe_TextChanged(object sender, EventArgs e)
        {
            titlelist_sgc.PrimaryGrid.Rows.Clear();
            string fileName = workDir + "\\" + project_cbe.Text + ".xml";
            List<Inscribe> inscribes = xmlProcess.AllData(fileName);
            SuperGridControl(inscribes, project_cbe.Text);
            titleNumber_btn.Text = $"试题总数：{inscribes.Count}";
        }
    }
}
