namespace Console.Contents
{
    partial class NavigationContent
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
            this.navi_rm = new DevComponents.DotNetBar.RadialMenu();
            this.Top_btn = new DevComponents.DotNetBar.RadialMenuItem();
            this.next_btn = new DevComponents.DotNetBar.RadialMenuItem();
            this.FindReason_btn = new DevComponents.DotNetBar.RadialMenuItem();
            this.previous_btn = new DevComponents.DotNetBar.RadialMenuItem();
            this.SuspendLayout();
            // 
            // navi_rm
            // 
            this.navi_rm.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.navi_rm.Colors.RadialMenuItemDisabledForeground = System.Drawing.Color.Empty;
            this.navi_rm.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Top_btn,
            this.next_btn,
            this.FindReason_btn,
            this.previous_btn});
            this.navi_rm.Location = new System.Drawing.Point(191, 33);
            this.navi_rm.Name = "navi_rm";
            this.navi_rm.Size = new System.Drawing.Size(60, 60);
            this.navi_rm.Symbol = "57412";
            this.navi_rm.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.navi_rm.SymbolSize = 20F;
            this.navi_rm.TabIndex = 0;
            this.navi_rm.Text = "radialMenu1";
            this.navi_rm.ItemClick += new System.EventHandler(this.navi_rm_ItemClick);
            // 
            // Top_btn
            // 
            this.Top_btn.Name = "Top_btn";
            this.Top_btn.Symbol = "";
            this.Top_btn.SymbolSize = 18F;
            this.Top_btn.Text = "顶端";
            this.Top_btn.Tooltip = "滚动至顶端";
            // 
            // next_btn
            // 
            this.next_btn.Name = "next_btn";
            this.next_btn.Symbol = "";
            this.next_btn.SymbolSize = 18F;
            this.next_btn.Text = "下节";
            this.next_btn.Tooltip = "下一节";
            // 
            // FindReason_btn
            // 
            this.FindReason_btn.Name = "FindReason_btn";
            this.FindReason_btn.Symbol = "";
            this.FindReason_btn.SymbolSize = 18F;
            this.FindReason_btn.Text = "故障解除";
            this.FindReason_btn.Tooltip = "滚动至底端";
            // 
            // previous_btn
            // 
            this.previous_btn.Name = "previous_btn";
            this.previous_btn.Symbol = "";
            this.previous_btn.SymbolSize = 18F;
            this.previous_btn.Text = "上节";
            this.previous_btn.Tooltip = "上一节";
            // 
            // NavigationContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 133);
            this.Controls.Add(this.navi_rm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NavigationContent";
            this.Text = "NavigationContent";
            this.SizeChanged += new System.EventHandler(this.NavigationContent_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RadialMenu navi_rm;
        private DevComponents.DotNetBar.RadialMenuItem previous_btn;
        private DevComponents.DotNetBar.RadialMenuItem next_btn;
        private DevComponents.DotNetBar.RadialMenuItem Top_btn;
        private DevComponents.DotNetBar.RadialMenuItem FindReason_btn;
    }
}