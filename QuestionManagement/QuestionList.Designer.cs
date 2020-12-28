namespace Console.QuestionManagement
{
    partial class QuestionList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding12 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.titleNumber_btn = new DevComponents.DotNetBar.ButtonX();
            this.project_cbe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.project_lab = new DevComponents.DotNetBar.LabelX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.titlelist_sgc = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn7 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn8 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Location = new System.Drawing.Point(63, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 86);
            this.panel2.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(542, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(169, 53);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "试题列表";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.titleNumber_btn);
            this.panel3.Controls.Add(this.project_cbe);
            this.panel3.Controls.Add(this.project_lab);
            this.panel3.Location = new System.Drawing.Point(63, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1234, 53);
            this.panel3.TabIndex = 2;
            // 
            // titleNumber_btn
            // 
            this.titleNumber_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.titleNumber_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.titleNumber_btn.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleNumber_btn.Location = new System.Drawing.Point(862, 7);
            this.titleNumber_btn.Name = "titleNumber_btn";
            this.titleNumber_btn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.titleNumber_btn.Size = new System.Drawing.Size(198, 39);
            this.titleNumber_btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.titleNumber_btn.TabIndex = 5;
            this.titleNumber_btn.Text = "试题总数：";
            // 
            // project_cbe
            // 
            this.project_cbe.DisplayMember = "Text";
            this.project_cbe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.project_cbe.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.project_cbe.ForeColor = System.Drawing.Color.Black;
            this.project_cbe.FormattingEnabled = true;
            this.project_cbe.ItemHeight = 28;
            this.project_cbe.Location = new System.Drawing.Point(163, 10);
            this.project_cbe.Name = "project_cbe";
            this.project_cbe.Size = new System.Drawing.Size(548, 34);
            this.project_cbe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.project_cbe.TabIndex = 4;
            this.project_cbe.DropDown += new System.EventHandler(this.project_cbe_DropDown);
            this.project_cbe.TextChanged += new System.EventHandler(this.project_cbe_TextChanged);
            this.project_cbe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.project_cbe_KeyPress);
            // 
            // project_lab
            // 
            // 
            // 
            // 
            this.project_lab.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.project_lab.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.project_lab.Location = new System.Drawing.Point(10, 4);
            this.project_lab.Name = "project_lab";
            this.project_lab.Size = new System.Drawing.Size(147, 45);
            this.project_lab.TabIndex = 3;
            this.project_lab.Text = "选择教学项目：";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.titlelist_sgc);
            this.panel4.Location = new System.Drawing.Point(62, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1235, 445);
            this.panel4.TabIndex = 3;
            // 
            // titlelist_sgc
            // 
            this.titlelist_sgc.BackColor = System.Drawing.Color.White;
            this.titlelist_sgc.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.titlelist_sgc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titlelist_sgc.ForeColor = System.Drawing.Color.Black;
            this.titlelist_sgc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.titlelist_sgc.Location = new System.Drawing.Point(0, 3);
            this.titlelist_sgc.Name = "titlelist_sgc";
            // 
            // 
            // 
            this.titlelist_sgc.PrimaryGrid.Columns.Add(this.gridColumn5);
            this.titlelist_sgc.PrimaryGrid.Columns.Add(this.gridColumn6);
            this.titlelist_sgc.PrimaryGrid.Columns.Add(this.gridColumn7);
            this.titlelist_sgc.PrimaryGrid.Columns.Add(this.gridColumn8);
            this.titlelist_sgc.PrimaryGrid.DefaultRowHeight = 100;
            this.titlelist_sgc.Size = new System.Drawing.Size(1235, 439);
            this.titlelist_sgc.TabIndex = 0;
            this.titlelist_sgc.Text = "superGridControl1";
            // 
            // gridColumn5
            // 
            this.gridColumn5.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIpAddressInputEditControl);
            padding12.Bottom = 7;
            padding12.Top = -4;
            this.gridColumn5.HeaderStyles.Default.ImagePadding = padding12;
            this.gridColumn5.Name = "序号";
            this.gridColumn5.Width = 48;
            // 
            // gridColumn6
            // 
            this.gridColumn6.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn6.CellStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.gridColumn6.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridTextBoxDropDownEditControl);
            this.gridColumn6.Name = "项目";
            this.gridColumn6.Width = 250;
            // 
            // gridColumn7
            // 
            this.gridColumn7.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn7.CellStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.gridColumn7.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridTextBoxDropDownEditControl);
            this.gridColumn7.Name = "题目";
            this.gridColumn7.Width = 850;
            // 
            // gridColumn8
            // 
            this.gridColumn8.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn8.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridRadialMenuEditControl);
            this.gridColumn8.InfoImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopCenter;
            this.gridColumn8.Name = "菜单";
            this.gridColumn8.Width = 50;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(47, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 669);
            this.panel1.TabIndex = 5;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // QuestionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1448, 713);
            this.Controls.Add(this.panel1);
            this.Name = "QuestionList";
            this.Text = "QuestionList";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.ButtonX titleNumber_btn;
        private DevComponents.DotNetBar.Controls.ComboBoxEx project_cbe;
        private DevComponents.DotNetBar.LabelX project_lab;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl titlelist_sgc;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn7;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn8;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}