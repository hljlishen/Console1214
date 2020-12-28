namespace Console.QuestionManagement
{
    partial class QuestionImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionImport));
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.project_cbe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.project_lab = new DevComponents.DotNetBar.LabelX();
            this.title_pl = new System.Windows.Forms.Panel();
            this.correctAnswer_cbe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.correctAnswer_lab = new DevComponents.DotNetBar.LabelX();
            this.choose_stc = new DevComponents.DotNetBar.SuperTabControl();
            this.title_rtbe = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.import_btn = new DevComponents.DotNetBar.ButtonX();
            this.validation_lab = new DevComponents.DotNetBar.LabelX();
            this.content_pl = new System.Windows.Forms.Panel();
            this.title_lab = new DevComponents.DotNetBar.LabelX();
            this.panel1.SuspendLayout();
            this.title_pl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choose_stc)).BeginInit();
            this.content_pl.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboItem1
            // 
            this.comboItem1.FontSize = 10F;
            this.comboItem1.Text = "2";
            // 
            // comboItem2
            // 
            this.comboItem2.FontSize = 10F;
            this.comboItem2.Text = "4";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.project_cbe);
            this.panel1.Controls.Add(this.project_lab);
            this.panel1.Location = new System.Drawing.Point(13, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 95);
            this.panel1.TabIndex = 0;
            // 
            // project_cbe
            // 
            this.project_cbe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.project_cbe.DisplayMember = "Text";
            this.project_cbe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.project_cbe.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.project_cbe.ForeColor = System.Drawing.Color.Black;
            this.project_cbe.FormattingEnabled = true;
            this.project_cbe.ItemHeight = 28;
            this.project_cbe.Location = new System.Drawing.Point(208, 36);
            this.project_cbe.Name = "project_cbe";
            this.project_cbe.Size = new System.Drawing.Size(646, 34);
            this.project_cbe.Sorted = true;
            this.project_cbe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.project_cbe.TabIndex = 1;
            this.project_cbe.DropDown += new System.EventHandler(this.project_cbe_DropDown);
            this.project_cbe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.project_cbe_KeyPress);
            // 
            // project_lab
            // 
            // 
            // 
            // 
            this.project_lab.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.project_lab.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.project_lab.Location = new System.Drawing.Point(38, 30);
            this.project_lab.Name = "project_lab";
            this.project_lab.Size = new System.Drawing.Size(168, 45);
            this.project_lab.TabIndex = 0;
            this.project_lab.Text = "选择教学项目：";
            // 
            // title_pl
            // 
            this.title_pl.Controls.Add(this.validation_lab);
            this.title_pl.Controls.Add(this.correctAnswer_cbe);
            this.title_pl.Controls.Add(this.import_btn);
            this.title_pl.Controls.Add(this.correctAnswer_lab);
            this.title_pl.Controls.Add(this.choose_stc);
            this.title_pl.Controls.Add(this.title_rtbe);
            this.title_pl.Controls.Add(this.title_lab);
            this.title_pl.Location = new System.Drawing.Point(13, 135);
            this.title_pl.Name = "title_pl";
            this.title_pl.Size = new System.Drawing.Size(881, 541);
            this.title_pl.TabIndex = 1;
            // 
            // correctAnswer_cbe
            // 
            this.correctAnswer_cbe.DisplayMember = "Text";
            this.correctAnswer_cbe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.correctAnswer_cbe.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.correctAnswer_cbe.ForeColor = System.Drawing.Color.Black;
            this.correctAnswer_cbe.FormattingEnabled = true;
            this.correctAnswer_cbe.ItemHeight = 28;
            this.correctAnswer_cbe.Location = new System.Drawing.Point(243, 470);
            this.correctAnswer_cbe.Name = "correctAnswer_cbe";
            this.correctAnswer_cbe.Size = new System.Drawing.Size(121, 34);
            this.correctAnswer_cbe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.correctAnswer_cbe.TabIndex = 8;
            this.correctAnswer_cbe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.correctAnswer_cbe_KeyPress);
            // 
            // correctAnswer_lab
            // 
            // 
            // 
            // 
            this.correctAnswer_lab.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.correctAnswer_lab.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.correctAnswer_lab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.correctAnswer_lab.Location = new System.Drawing.Point(140, 474);
            this.correctAnswer_lab.Name = "correctAnswer_lab";
            this.correctAnswer_lab.Size = new System.Drawing.Size(107, 23);
            this.correctAnswer_lab.TabIndex = 6;
            this.correctAnswer_lab.Text = "正确答案：";
            // 
            // choose_stc
            // 
            this.choose_stc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.choose_stc.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.choose_stc.ControlBox.MenuBox.Name = "";
            this.choose_stc.ControlBox.Name = "";
            this.choose_stc.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.choose_stc.ControlBox.MenuBox,
            this.choose_stc.ControlBox.CloseBox});
            this.choose_stc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choose_stc.ForeColor = System.Drawing.Color.Black;
            this.choose_stc.Location = new System.Drawing.Point(38, 207);
            this.choose_stc.Name = "choose_stc";
            this.choose_stc.ReorderTabsEnabled = true;
            this.choose_stc.SelectedTabFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choose_stc.SelectedTabIndex = -1;
            this.choose_stc.Size = new System.Drawing.Size(816, 230);
            this.choose_stc.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choose_stc.TabIndex = 5;
            this.choose_stc.Text = "superTabControl1";
            // 
            // title_rtbe
            // 
            // 
            // 
            // 
            this.title_rtbe.BackgroundStyle.Class = "RichTextBoxBorder";
            this.title_rtbe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.title_rtbe.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title_rtbe.Location = new System.Drawing.Point(38, 41);
            this.title_rtbe.Name = "title_rtbe";
            this.title_rtbe.Rtf = resources.GetString("title_rtbe.Rtf");
            this.title_rtbe.Size = new System.Drawing.Size(816, 151);
            this.title_rtbe.TabIndex = 1;
            // 
            // import_btn
            // 
            this.import_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.import_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.import_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.import_btn.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.import_btn.Location = new System.Drawing.Point(550, 470);
            this.import_btn.Name = "import_btn";
            this.import_btn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.import_btn.Size = new System.Drawing.Size(165, 46);
            this.import_btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.import_btn.TabIndex = 2;
            this.import_btn.Text = "导      入";
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // validation_lab
            // 
            this.validation_lab.AutoSize = true;
            // 
            // 
            // 
            this.validation_lab.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.validation_lab.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validation_lab.ForeColor = System.Drawing.Color.Red;
            this.validation_lab.Location = new System.Drawing.Point(550, 444);
            this.validation_lab.Name = "validation_lab";
            this.validation_lab.Size = new System.Drawing.Size(53, 20);
            this.validation_lab.TabIndex = 3;
            this.validation_lab.Text = "labelX1";
            this.validation_lab.Visible = false;
            // 
            // content_pl
            // 
            this.content_pl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.content_pl.Controls.Add(this.title_pl);
            this.content_pl.Controls.Add(this.panel1);
            this.content_pl.Location = new System.Drawing.Point(304, 58);
            this.content_pl.Name = "content_pl";
            this.content_pl.Size = new System.Drawing.Size(907, 693);
            this.content_pl.TabIndex = 4;
            // 
            // title_lab
            // 
            // 
            // 
            // 
            this.title_lab.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.title_lab.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title_lab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.title_lab.Location = new System.Drawing.Point(38, 3);
            this.title_lab.Name = "title_lab";
            this.title_lab.Size = new System.Drawing.Size(75, 23);
            this.title_lab.TabIndex = 0;
            this.title_lab.Text = "题目：";
            // 
            // QuestionImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1463, 808);
            this.Controls.Add(this.content_pl);
            this.DoubleBuffered = true;
            this.Name = "QuestionImport";
            this.Text = "QuestionImport";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.panel1.ResumeLayout(false);
            this.title_pl.ResumeLayout(false);
            this.title_pl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choose_stc)).EndInit();
            this.content_pl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx project_cbe;
        private DevComponents.DotNetBar.LabelX project_lab;
        private System.Windows.Forms.Panel title_pl;
        private DevComponents.DotNetBar.Controls.ComboBoxEx correctAnswer_cbe;
        private DevComponents.DotNetBar.LabelX correctAnswer_lab;
        private DevComponents.DotNetBar.SuperTabControl choose_stc;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx title_rtbe;
        private DevComponents.DotNetBar.ButtonX import_btn;
        private DevComponents.DotNetBar.LabelX validation_lab;
        private System.Windows.Forms.Panel content_pl;
        private DevComponents.DotNetBar.LabelX title_lab;
    }
}