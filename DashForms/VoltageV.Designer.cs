namespace Console.DashForms
{
    partial class VoltageV
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
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale1 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor1 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor2 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer1 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection1 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection2 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection3 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection4 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor3 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor4 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.NumericIndicator numericIndicator1 = new DevComponents.Instrumentation.NumericIndicator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoltageV));
            DevComponents.Instrumentation.GaugeText gaugeText1 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeText gaugeText2 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.StateIndicator stateIndicator1 = new DevComponents.Instrumentation.StateIndicator();
            DevComponents.Instrumentation.GaugeImage gaugeImage1 = new DevComponents.Instrumentation.GaugeImage();
            this.gauge_gc = new DevComponents.Instrumentation.GaugeControl();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gauge_gc)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gauge_gc
            // 
            gaugeCircularScale1.BorderColor = System.Drawing.Color.Bisque;
            gaugeCircularScale1.MajorTickMarks.Interval = 100D;
            gradientFillColor1.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor1.Color1 = System.Drawing.Color.White;
            gradientFillColor1.Color2 = System.Drawing.Color.White;
            gaugeCircularScale1.MajorTickMarks.Layout.FillColor = gradientFillColor1;
            gaugeCircularScale1.MajorTickMarks.Layout.Length = 0.27F;
            gaugeCircularScale1.MaxPin.Name = "MaxPin";
            gaugeCircularScale1.MaxValue = 450D;
            gaugeCircularScale1.MinorTickMarks.Interval = 10D;
            gradientFillColor2.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugeCircularScale1.MinorTickMarks.Layout.FillColor = gradientFillColor2;
            gaugeCircularScale1.MinorTickMarks.Layout.Length = 0.17F;
            gaugeCircularScale1.MinorTickMarks.Layout.Width = 0.05F;
            gaugeCircularScale1.MinPin.Name = "MinPin";
            gaugeCircularScale1.Name = "Scale1";
            gaugePointer1.AllowUserChange = true;
            gaugePointer1.CapFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer1.CapFillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer1.CapFillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer1.CapWidth = 0.2F;
            gaugePointer1.FillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer1.FillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer1.FillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer1.Length = -0.1F;
            gaugePointer1.Name = "Pointer1";
            gaugePointer1.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style4;
            gaugePointer1.ScaleOffset = -0.1F;
            gaugePointer1.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer1.Value = 2.5D;
            gaugePointer1.Width = 0.05F;
            gaugeCircularScale1.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer1});
            gaugeSection1.EndValue = 5D;
            gaugeSection1.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection1.FillColor.Color2 = System.Drawing.Color.Transparent;
            gaugeSection1.LabelColor = System.Drawing.Color.White;
            gaugeSection1.MajorTickMarkFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            gaugeSection1.MajorTickMarkFillColor.Color1 = System.Drawing.Color.White;
            gaugeSection1.MajorTickMarkFillColor.Color2 = System.Drawing.Color.White;
            gaugeSection1.Name = "Section1";
            gaugeSection1.StartValue = 0D;
            gaugeSection2.EndValue = 360D;
            gaugeSection2.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection2.LabelColor = System.Drawing.Color.Lime;
            gaugeSection2.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection2.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection2.Name = "Normal";
            gaugeSection2.StartValue = 0D;
            gaugeSection3.EndValue = 420D;
            gaugeSection3.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection3.LabelColor = System.Drawing.Color.Gold;
            gaugeSection3.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection3.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection3.Name = "Warning";
            gaugeSection3.StartValue = 360D;
            gaugeSection4.EndValue = 450D;
            gaugeSection4.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection4.LabelColor = System.Drawing.Color.Red;
            gaugeSection4.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection4.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection4.Name = "Alarm";
            gaugeSection4.StartValue = 420D;
            gaugeCircularScale1.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection1,
            gaugeSection2,
            gaugeSection3,
            gaugeSection4});
            gaugeCircularScale1.StartAngle = 160F;
            gaugeCircularScale1.SweepAngle = 220F;
            this.gauge_gc.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale1});
            this.gauge_gc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gauge_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor3.Color1 = System.Drawing.Color.DarkBlue;
            gradientFillColor3.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.gauge_gc.Frame.BackColor = gradientFillColor3;
            gradientFillColor4.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor4.BorderWidth = 1;
            gradientFillColor4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor4.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.gauge_gc.Frame.FrameColor = gradientFillColor4;
            this.gauge_gc.Frame.InnerBevel = 0F;
            this.gauge_gc.Frame.OuterBevel = 0.025F;
            this.gauge_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            numericIndicator1.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator1.BackColor.BorderWidth = 3;
            numericIndicator1.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator1.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator1.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator1.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator1.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator1.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator1.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator1.Location")));
            numericIndicator1.MaxValue = 500D;
            numericIndicator1.Name = "CurrencyC_Indicator";
            numericIndicator1.NumberOfDecimals = 1;
            numericIndicator1.NumberOfDigits = 4;
            numericIndicator1.ShowDecimalPoint = true;
            numericIndicator1.Size = new System.Drawing.SizeF(0.5F, 0.22F);
            numericIndicator1.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator1.Value = 300D;
            gaugeText1.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F);
            gaugeText1.ForeColor = System.Drawing.Color.White;
            gaugeText1.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText1.Location")));
            gaugeText1.Name = "Text1";
            gaugeText1.Size = new System.Drawing.SizeF(0.3F, 0.2F);
            gaugeText1.Text = "~";
            gaugeText2.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            gaugeText2.ForeColor = System.Drawing.Color.White;
            gaugeText2.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText2.Location")));
            gaugeText2.Name = "Text2";
            gaugeText2.Text = "V";
            stateIndicator1.BackColor.BorderColor = System.Drawing.Color.Black;
            stateIndicator1.BackColor.Color1 = System.Drawing.Color.Lime;
            stateIndicator1.BackColor.Color2 = System.Drawing.Color.Lime;
            stateIndicator1.EmptyString = "";
            stateIndicator1.Location = ((System.Drawing.PointF)(resources.GetObject("stateIndicator1.Location")));
            stateIndicator1.Name = "StateIndicator1";
            stateIndicator1.Size = new System.Drawing.SizeF(0.06F, 0.06F);
            gaugeImage1.AutoFit = true;
            gaugeImage1.Image = ((System.Drawing.Image)(resources.GetObject("gaugeImage1.Image")));
            gaugeImage1.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeImage1.Location")));
            gaugeImage1.Name = "Image1";
            gaugeImage1.Size = new System.Drawing.SizeF(0.15F, 0.15F);
            this.gauge_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            numericIndicator1,
            gaugeText1,
            gaugeText2,
            stateIndicator1,
            gaugeImage1});
            this.gauge_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.gauge_gc.Location = new System.Drawing.Point(0, 0);
            this.gauge_gc.Name = "gauge_gc";
            this.gauge_gc.Size = new System.Drawing.Size(394, 372);
            this.gauge_gc.TabIndex = 11;
            this.gauge_gc.Tag = "";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.gauge_gc);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.groupPanel1.Text = "交流电压";
            // 
            // VoltageV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VoltageV";
            this.Text = "VoltageV";
            ((System.ComponentModel.ISupportInitialize)(this.gauge_gc)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Instrumentation.GaugeControl gauge_gc;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
    }
}