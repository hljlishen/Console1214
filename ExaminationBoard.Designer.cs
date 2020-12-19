namespace Console
{
    partial class ExaminationBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExaminationBoard));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.navigation_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.content_pl = new System.Windows.Forms.Panel();
            this.examinationName_lab = new DevComponents.DotNetBar.LabelX();
            this.finish_btn = new DevComponents.DotNetBar.ButtonX();
            this.inscribe_pl = new System.Windows.Forms.Panel();
            this.inscribe_lab = new DevComponents.DotNetBar.LabelX();
            this.candidates_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.progress_pl = new System.Windows.Forms.Panel();
            this.progress_lab = new DevComponents.DotNetBar.LabelX();
            this.CountDown_lab = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navi_pl = new System.Windows.Forms.Panel();
            this.previous_btn = new DevComponents.DotNetBar.ButtonX();
            this.next_btn = new DevComponents.DotNetBar.ButtonX();
            this.currentInscribIndicator_hl = new DevComponents.DotNetBar.Validator.Highlighter();
            this.content_pl.SuspendLayout();
            this.inscribe_pl.SuspendLayout();
            this.progress_pl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navi_pl.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // navigation_flp
            // 
            this.navigation_flp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigation_flp.AutoScroll = true;
            this.navigation_flp.Location = new System.Drawing.Point(100, 7);
            this.navigation_flp.Name = "navigation_flp";
            this.navigation_flp.Size = new System.Drawing.Size(1187, 98);
            this.navigation_flp.TabIndex = 0;
            // 
            // content_pl
            // 
            this.content_pl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content_pl.Controls.Add(this.examinationName_lab);
            this.content_pl.Controls.Add(this.finish_btn);
            this.content_pl.Controls.Add(this.inscribe_pl);
            this.content_pl.Controls.Add(this.progress_pl);
            this.content_pl.Controls.Add(this.navi_pl);
            this.content_pl.Location = new System.Drawing.Point(40, 12);
            this.content_pl.Name = "content_pl";
            this.content_pl.Size = new System.Drawing.Size(1395, 1030);
            this.content_pl.TabIndex = 1;
            // 
            // examinationName_lab
            // 
            this.examinationName_lab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.examinationName_lab.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.examinationName_lab.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.examinationName_lab.Location = new System.Drawing.Point(3, 55);
            this.examinationName_lab.Name = "examinationName_lab";
            this.examinationName_lab.Size = new System.Drawing.Size(1387, 78);
            this.examinationName_lab.TabIndex = 2;
            this.examinationName_lab.Text = "考试名称";
            this.examinationName_lab.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // finish_btn
            // 
            this.finish_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.finish_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finish_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.finish_btn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.finish_btn.Location = new System.Drawing.Point(266, 906);
            this.finish_btn.Name = "finish_btn";
            this.finish_btn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.finish_btn.Size = new System.Drawing.Size(811, 60);
            this.finish_btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.finish_btn.TabIndex = 8;
            this.finish_btn.Text = "完成考试";
            this.finish_btn.Click += new System.EventHandler(this.finish_btn_Click);
            this.finish_btn.MouseEnter += new System.EventHandler(this.finish_btn_MouseEnter);
            // 
            // inscribe_pl
            // 
            this.inscribe_pl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inscribe_pl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inscribe_pl.Controls.Add(this.inscribe_lab);
            this.inscribe_pl.Controls.Add(this.candidates_flp);
            this.inscribe_pl.Location = new System.Drawing.Point(3, 331);
            this.inscribe_pl.Name = "inscribe_pl";
            this.inscribe_pl.Size = new System.Drawing.Size(1387, 364);
            this.inscribe_pl.TabIndex = 7;
            // 
            // inscribe_lab
            // 
            this.inscribe_lab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.inscribe_lab.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inscribe_lab.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inscribe_lab.FontBold = true;
            this.inscribe_lab.Location = new System.Drawing.Point(99, 13);
            this.inscribe_lab.Name = "inscribe_lab";
            this.inscribe_lab.Size = new System.Drawing.Size(1187, 93);
            this.inscribe_lab.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.inscribe_lab.TabIndex = 2;
            this.inscribe_lab.Text = "labelX1";
            this.inscribe_lab.WordWrap = true;
            // 
            // candidates_flp
            // 
            this.candidates_flp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.candidates_flp.Location = new System.Drawing.Point(99, 176);
            this.candidates_flp.Name = "candidates_flp";
            this.candidates_flp.Size = new System.Drawing.Size(1187, 172);
            this.candidates_flp.TabIndex = 1;
            // 
            // progress_pl
            // 
            this.progress_pl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress_pl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progress_pl.Controls.Add(this.progress_lab);
            this.progress_pl.Controls.Add(this.CountDown_lab);
            this.progress_pl.Controls.Add(this.pictureBox1);
            this.progress_pl.Location = new System.Drawing.Point(3, 220);
            this.progress_pl.Name = "progress_pl";
            this.progress_pl.Size = new System.Drawing.Size(1387, 100);
            this.progress_pl.TabIndex = 3;
            // 
            // progress_lab
            // 
            this.progress_lab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // 
            // 
            this.progress_lab.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progress_lab.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.progress_lab.Location = new System.Drawing.Point(1065, 27);
            this.progress_lab.Name = "progress_lab";
            this.progress_lab.Size = new System.Drawing.Size(221, 48);
            this.progress_lab.TabIndex = 7;
            this.progress_lab.Text = "labelX1";
            this.progress_lab.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // CountDown_lab
            // 
            this.CountDown_lab.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.CountDown_lab.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CountDown_lab.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDown_lab.FontBold = true;
            this.CountDown_lab.Location = new System.Drawing.Point(173, 27);
            this.CountDown_lab.Name = "CountDown_lab";
            this.CountDown_lab.Size = new System.Drawing.Size(195, 48);
            this.CountDown_lab.TabIndex = 6;
            this.CountDown_lab.Text = "countDown_lab";
            this.CountDown_lab.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // navi_pl
            // 
            this.navi_pl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navi_pl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navi_pl.Controls.Add(this.previous_btn);
            this.navi_pl.Controls.Add(this.navigation_flp);
            this.navi_pl.Controls.Add(this.next_btn);
            this.navi_pl.Location = new System.Drawing.Point(3, 705);
            this.navi_pl.Name = "navi_pl";
            this.navi_pl.Size = new System.Drawing.Size(1387, 111);
            this.navi_pl.TabIndex = 2;
            // 
            // previous_btn
            // 
            this.previous_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.previous_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.previous_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.previous_btn.Image = ((System.Drawing.Image)(resources.GetObject("previous_btn.Image")));
            this.previous_btn.Location = new System.Drawing.Point(24, 36);
            this.previous_btn.Name = "previous_btn";
            this.previous_btn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.previous_btn.Size = new System.Drawing.Size(50, 50);
            this.previous_btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.previous_btn.Symbol = "";
            this.previous_btn.SymbolColor = System.Drawing.Color.White;
            this.previous_btn.TabIndex = 3;
            this.previous_btn.Click += new System.EventHandler(this.previous_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.next_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.next_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.next_btn.Image = ((System.Drawing.Image)(resources.GetObject("next_btn.Image")));
            this.next_btn.ImageFixedSize = new System.Drawing.Size(100, 100);
            this.next_btn.Location = new System.Drawing.Point(1305, 35);
            this.next_btn.Name = "next_btn";
            this.next_btn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.next_btn.Size = new System.Drawing.Size(50, 50);
            this.next_btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.next_btn.Symbol = "";
            this.next_btn.SymbolColor = System.Drawing.Color.White;
            this.next_btn.TabIndex = 2;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // currentInscribIndicator_hl
            // 
            this.currentInscribIndicator_hl.ContainerControl = this;
            this.currentInscribIndicator_hl.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Orange;
            this.currentInscribIndicator_hl.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // ExaminationBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 1054);
            this.Controls.Add(this.content_pl);
            this.DoubleBuffered = true;
            this.Name = "ExaminationBoard";
            this.Text = "ExaminationBoard";
            this.content_pl.ResumeLayout(false);
            this.inscribe_pl.ResumeLayout(false);
            this.progress_pl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navi_pl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.FlowLayoutPanel navigation_flp;
        private System.Windows.Forms.Panel content_pl;
        private DevComponents.DotNetBar.LabelX inscribe_lab;
        private System.Windows.Forms.FlowLayoutPanel candidates_flp;
        private DevComponents.DotNetBar.ButtonX next_btn;
        private DevComponents.DotNetBar.ButtonX previous_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel progress_pl;
        private System.Windows.Forms.Panel navi_pl;
        private System.Windows.Forms.Panel inscribe_pl;
        private DevComponents.DotNetBar.LabelX CountDown_lab;
        private DevComponents.DotNetBar.LabelX examinationName_lab;
        private DevComponents.DotNetBar.ButtonX finish_btn;
        private DevComponents.DotNetBar.LabelX progress_lab;
        private DevComponents.DotNetBar.Validator.Highlighter currentInscribIndicator_hl;
    }
}