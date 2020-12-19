namespace Utilities.Forms
{
    partial class SlashForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.info_lab = new System.Windows.Forms.Label();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.circularProgress2 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.SuspendLayout();
            // 
            // info_lab
            // 
            this.info_lab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.info_lab.AutoSize = true;
            this.info_lab.BackColor = System.Drawing.Color.Transparent;
            this.info_lab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.info_lab.ForeColor = System.Drawing.Color.White;
            this.info_lab.Location = new System.Drawing.Point(12, 290);
            this.info_lab.Name = "info_lab";
            this.info_lab.Size = new System.Drawing.Size(145, 22);
            this.info_lab.TabIndex = 0;
            this.info_lab.Text = "正在检测UKey......";
            // 
            // circularProgress1
            // 
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(344, 227);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.Size = new System.Drawing.Size(37, 23);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 1;
            // 
            // circularProgress2
            // 
            this.circularProgress2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            // 
            // 
            // 
            this.circularProgress2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress2.Location = new System.Drawing.Point(300, 210);
            this.circularProgress2.Name = "circularProgress2";
            this.circularProgress2.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.circularProgress2.ProgressColor = System.Drawing.Color.YellowGreen;
            this.circularProgress2.Size = new System.Drawing.Size(96, 58);
            this.circularProgress2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress2.TabIndex = 2;
            // 
            // SlashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 348);
            this.Controls.Add(this.circularProgress2);
            this.Controls.Add(this.circularProgress1);
            this.Controls.Add(this.info_lab);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SlashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SlashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_lab;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress2;
    }
}

