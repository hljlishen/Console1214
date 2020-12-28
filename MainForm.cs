using Console.DashForms;
using Console.Device;
using Console.framework;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class MainForm : Office2007Form
    {
        private IDeviceSubject subject = new FakeDevice();
        private DynamicDashBoard dynamicDashBoard;
        public MainForm()
        {
            InitializeComponent();
            dynamicDashBoard = new DynamicDashBoard(subject);
            collapsibleSplitContainer1.Panel2.Controls.Add(dynamicDashBoard);
            dynamicDashBoard.Show();

            
        }

        private void sideNavItem3_MouseEnter(object sender, EventArgs e)
        {
            sideNav1.SelectedItem = sender as SideNavItem;
        }

        private void sni_QuestionManagement_MouseEnter(object sender, EventArgs e)
        {
            sideNav1.SelectedItem = sender as SideNavItem;
        }
    }
}
