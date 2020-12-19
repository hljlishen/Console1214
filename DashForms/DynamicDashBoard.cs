using Console.framework;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Console.DashForms
{
    public partial class DynamicDashBoard : Office2007Form
    {
        private IDeviceSubject subject;
        private Size OriginalSize = new Size(200, 200);
        public DynamicDashBoard(IDeviceSubject subject)
        {
            InitializeComponent();
            EnableGlass = false;

            this.subject = subject;
            subject.DataUpdated += Subject_DataUpdated;
            subject.Start();

            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
        }

        private void Subject_DataUpdated(IDeviceSubject obj)
        {
            foreach (var control in gauges_lp.Controls)
            {
                if (control is ISensorView v)
                {
                    v.UpdateView(obj);
                }
            }
        }

        private void All_btn_Click(object sender, EventArgs e)
        {
            foreach (var control in SelectionPanel.Controls)
            {
                if (control is CheckBoxX c)
                {
                    c.Checked = true;
                }
            }
        }

        private void None_btn_Click(object sender, EventArgs e)
        {
            foreach (var control in SelectionPanel.Controls)
            {
                if (control is CheckBoxX c)
                {
                    c.Checked = false;
                }
            }
        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxX cb = sender as CheckBoxX;
            if (cb.Checked)
            {
                var name = cb.Name.Substring(0, cb.Name.Length - 3);
                Assembly asm = Assembly.GetExecutingAssembly();//获取当前代码所在程序集
                Form c = asm.CreateInstance($"Console.DashForms.{name}", true) as Form;

                LayoutControlItem item = AddDashForm(c);
                cb.Tag = item;
            }
            else
            {
                var item = cb.Tag as LayoutControlItem;
                RemoveDashForm(item);
            }
        }

        private LayoutControlItem AddDashForm(Form c)
        {
            LayoutControlItem item = new LayoutControlItem();
            gauges_lp.Controls.Add(c);
            gauges_lp.RootGroup.Items.Add(item);

            item.Control = c;
            item.Width = OriginalSize.Width;
            item.WidthType = eLayoutSizeType.Absolute;
            item.Height = OriginalSize.Height;
            item.HeightType = eLayoutSizeType.Absolute;

            c.BackColor = gauges_lp.BackColor;
            return item;
        }

        private void RemoveDashForm(LayoutControlItem item)
        {
            gauges_lp.Controls.Remove(item.Control);
            gauges_lp.RootGroup.Items.Remove(item);
        }

        private void ResizeItems()
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "ZoomOut_mi" && SelectedItem != null)
            {
                SelectedItem.Width = (int)(SelectedItem.Width * 1.5);
                SelectedItem.Height = (int)(SelectedItem.Height * 1.5);
            }
            if (e.ClickedItem.Name == "ZoomIn_mi" && SelectedItem != null)
            {
                SelectedItem.Width = (int)(SelectedItem.Width * 0.75);
                SelectedItem.Height = (int)(SelectedItem.Height * 0.75);
            }
            if (e.ClickedItem.Name == "reset_mi" && SelectedItem != null)
            {
                SelectedItem.Width = OriginalSize.Width;
                SelectedItem.Height = OriginalSize.Height;
            }
        }

        private void menu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var location = gauges_lp.PointToClient(MousePosition);
            SelectedItem = gauges_lp.FindControlItem(gauges_lp.GetChildAtPoint(location)) as LayoutControlItem;
        }

        private LayoutControlItem SelectedItem = null;
    }
}
