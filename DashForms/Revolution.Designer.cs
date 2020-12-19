namespace Console.DashForms
{
    partial class Revolution
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
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale2 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor5 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor6 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer2 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection2 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor7 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor8 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugeText gaugeText3 = new DevComponents.Instrumentation.GaugeText();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Revolution));
            DevComponents.Instrumentation.NumericIndicator numericIndicator2 = new DevComponents.Instrumentation.NumericIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText4 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeImage gaugeImage2 = new DevComponents.Instrumentation.GaugeImage();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.gauge_gc = new DevComponents.Instrumentation.GaugeControl();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gauge_gc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.gauge_gc);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(400, 400);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 12;
            this.groupPanel1.Text = "转速";
            // 
            // gauge_gc
            // 
            gaugeCircularScale2.BorderColor = System.Drawing.Color.Bisque;
            gaugeCircularScale2.MajorTickMarks.Interval = 1D;
            gradientFillColor5.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor5.Color1 = System.Drawing.Color.White;
            gradientFillColor5.Color2 = System.Drawing.Color.White;
            gaugeCircularScale2.MajorTickMarks.Layout.FillColor = gradientFillColor5;
            gaugeCircularScale2.MajorTickMarks.Layout.Length = 0.27F;
            gaugeCircularScale2.MaxPin.Name = "MaxPin";
            gaugeCircularScale2.MaxValue = 5D;
            gaugeCircularScale2.MinorTickMarks.Interval = 0.1D;
            gradientFillColor6.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor6.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor6.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugeCircularScale2.MinorTickMarks.Layout.FillColor = gradientFillColor6;
            gaugeCircularScale2.MinorTickMarks.Layout.Length = 0.17F;
            gaugeCircularScale2.MinorTickMarks.Layout.Width = 0.05F;
            gaugeCircularScale2.MinPin.Name = "MinPin";
            gaugeCircularScale2.Name = "Scale1";
            gaugePointer2.AllowUserChange = true;
            gaugePointer2.CapFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer2.CapFillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer2.CapFillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer2.CapWidth = 0.2F;
            gaugePointer2.FillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer2.FillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer2.FillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer2.Length = 0F;
            gaugePointer2.Name = "Pointer1";
            gaugePointer2.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style4;
            gaugePointer2.ScaleOffset = -0.1F;
            gaugePointer2.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer2.Value = 2.5D;
            gaugePointer2.Width = 0.05F;
            gaugeCircularScale2.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer2});
            gaugeSection2.EndValue = 5D;
            gaugeSection2.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection2.FillColor.Color2 = System.Drawing.Color.Transparent;
            gaugeSection2.LabelColor = System.Drawing.Color.White;
            gaugeSection2.MajorTickMarkFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            gaugeSection2.MajorTickMarkFillColor.Color1 = System.Drawing.Color.White;
            gaugeSection2.MajorTickMarkFillColor.Color2 = System.Drawing.Color.White;
            gaugeSection2.Name = "Section1";
            gaugeSection2.StartValue = 0D;
            gaugeCircularScale2.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection2});
            gaugeCircularScale2.StartAngle = 160F;
            gaugeCircularScale2.SweepAngle = 220F;
            this.gauge_gc.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale2});
            this.gauge_gc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gauge_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor7.Color1 = System.Drawing.Color.MidnightBlue;
            gradientFillColor7.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.gauge_gc.Frame.BackColor = gradientFillColor7;
            gradientFillColor8.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor8.BorderWidth = 1;
            gradientFillColor8.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor8.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.gauge_gc.Frame.FrameColor = gradientFillColor8;
            this.gauge_gc.Frame.InnerBevel = 0F;
            this.gauge_gc.Frame.OuterBevel = 0.025F;
            this.gauge_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            gaugeText3.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText3.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gaugeText3.ForeColor = System.Drawing.Color.White;
            gaugeText3.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText3.Location")));
            gaugeText3.Name = "电流C";
            gaugeText3.Size = new System.Drawing.SizeF(0.5F, 0.6F);
            gaugeText3.Text = "转速";
            numericIndicator2.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator2.BackColor.BorderWidth = 3;
            numericIndicator2.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator2.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator2.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator2.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator2.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator2.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator2.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator2.Location")));
            numericIndicator2.MaxValue = 5000D;
            numericIndicator2.Name = "CurrencyC_Indicator";
            numericIndicator2.NumberOfDecimals = 0;
            numericIndicator2.NumberOfDigits = 4;
            numericIndicator2.ShowDecimalPoint = true;
            numericIndicator2.Size = new System.Drawing.SizeF(0.3F, 0.15F);
            numericIndicator2.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator2.Value = 2345D;
            gaugeText4.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gaugeText4.ForeColor = System.Drawing.Color.White;
            gaugeText4.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText4.Location")));
            gaugeText4.Name = "Text1";
            gaugeText4.Size = new System.Drawing.SizeF(0.3F, 0.2F);
            gaugeText4.Text = "1000RPM";
            gaugeImage2.AutoFit = true;
            gaugeImage2.Image = ((System.Drawing.Image)(resources.GetObject("gaugeImage2.Image")));
            gaugeImage2.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeImage2.Location")));
            gaugeImage2.Name = "Image1";
            gaugeImage2.Size = new System.Drawing.SizeF(0.15F, 0.15F);
            this.gauge_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            gaugeText3,
            numericIndicator2,
            gaugeText4,
            gaugeImage2});
            this.gauge_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.gauge_gc.Location = new System.Drawing.Point(0, 0);
            this.gauge_gc.Name = "gauge_gc";
            this.gauge_gc.Size = new System.Drawing.Size(394, 367);
            this.gauge_gc.TabIndex = 4;
            this.gauge_gc.Tag = "1000";
            // 
            // Revolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Revolution";
            this.Text = "VoltageV";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gauge_gc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.Instrumentation.GaugeControl gauge_gc;
    }
}