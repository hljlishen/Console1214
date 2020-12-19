namespace Console.DashForms
{
    partial class Temperature
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
            DevComponents.Instrumentation.GradientFillColor gradientFillColor1 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor2 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugeText gaugeText1 = new DevComponents.Instrumentation.GaugeText();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temperature));
            DevComponents.Instrumentation.NumericIndicator numericIndicator1 = new DevComponents.Instrumentation.NumericIndicator();
            DevComponents.Instrumentation.StateIndicator stateIndicator1 = new DevComponents.Instrumentation.StateIndicator();
            DevComponents.Instrumentation.GaugeLinearScale gaugeLinearScale1 = new DevComponents.Instrumentation.GaugeLinearScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor3 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor4 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer1 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection1 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection2 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection3 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection4 = new DevComponents.Instrumentation.GaugeSection();
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
            this.groupPanel1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(337, 482);
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
            this.groupPanel1.Text = "温度";
            // 
            // gauge_gc
            // 
            this.gauge_gc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gauge_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor1.Color1 = System.Drawing.Color.MidnightBlue;
            gradientFillColor1.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.gauge_gc.Frame.BackColor = gradientFillColor1;
            gradientFillColor2.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.gauge_gc.Frame.FrameColor = gradientFillColor2;
            this.gauge_gc.Frame.InnerBevel = 0F;
            this.gauge_gc.Frame.OuterBevel = 0.025F;
            this.gauge_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.RoundedRectangular;
            gaugeText1.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText1.Font = new System.Drawing.Font("等线", 24F, System.Drawing.FontStyle.Bold);
            gaugeText1.ForeColor = System.Drawing.Color.White;
            gaugeText1.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText1.Location")));
            gaugeText1.Name = "电流C";
            gaugeText1.Size = new System.Drawing.SizeF(0.5F, 0.6F);
            gaugeText1.Text = "温度(℃)";
            numericIndicator1.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator1.BackColor.BorderWidth = 3;
            numericIndicator1.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator1.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator1.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator1.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator1.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator1.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator1.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator1.Location")));
            numericIndicator1.MaxValue = 300D;
            numericIndicator1.Name = "CurrencyC_Indicator";
            numericIndicator1.NumberOfDecimals = 0;
            numericIndicator1.NumberOfDigits = 3;
            numericIndicator1.ShowDecimalPoint = true;
            numericIndicator1.Size = new System.Drawing.SizeF(0.3F, 0.15F);
            numericIndicator1.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator1.Value = 200D;
            stateIndicator1.AutoSize = false;
            stateIndicator1.BackColor.BorderColor = System.Drawing.Color.Black;
            stateIndicator1.BackColor.Color1 = System.Drawing.Color.Lime;
            stateIndicator1.BackColor.Color2 = System.Drawing.Color.Lime;
            stateIndicator1.EmptyString = "";
            stateIndicator1.Location = ((System.Drawing.PointF)(resources.GetObject("stateIndicator1.Location")));
            stateIndicator1.Name = "StateIndicator1";
            stateIndicator1.Size = new System.Drawing.SizeF(0.07F, 0.05F);
            stateIndicator1.Style = DevComponents.Instrumentation.StateIndicatorStyle.RoundedRectangular;
            this.gauge_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            gaugeText1,
            numericIndicator1,
            stateIndicator1});
            this.gauge_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            gaugeLinearScale1.Labels.Layout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gaugeLinearScale1.Labels.Layout.ForeColor = System.Drawing.Color.Transparent;
            gaugeLinearScale1.Labels.Layout.ScaleOffset = 0.05F;
            gaugeLinearScale1.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeLinearScale1.Location")));
            gaugeLinearScale1.MajorTickMarks.Interval = 100D;
            gradientFillColor3.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor3.Color1 = System.Drawing.Color.White;
            gaugeLinearScale1.MajorTickMarks.Layout.FillColor = gradientFillColor3;
            gaugeLinearScale1.MajorTickMarks.Layout.Width = 0.03F;
            gaugeLinearScale1.MaxPin.Name = "MaxPin";
            gaugeLinearScale1.MaxValue = 300D;
            gaugeLinearScale1.MinorTickMarks.Interval = 20D;
            gradientFillColor4.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugeLinearScale1.MinorTickMarks.Layout.FillColor = gradientFillColor4;
            gaugeLinearScale1.MinorTickMarks.Layout.Width = 0.03F;
            gaugeLinearScale1.MinPin.Name = "MinPin";
            gaugeLinearScale1.Name = "Scale1";
            gaugeLinearScale1.Orientation = System.Windows.Forms.Orientation.Vertical;
            gaugePointer1.CapFillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer1.CapFillColor.BorderWidth = 1;
            gaugePointer1.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer1.CapFillColor.Color2 = System.Drawing.Color.DimGray;
            gaugePointer1.FillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer1.FillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer1.Name = "Pointer1";
            gaugePointer1.Placement = DevComponents.Instrumentation.DisplayPlacement.Far;
            gaugePointer1.ThermoBackColor.BorderColor = System.Drawing.Color.Black;
            gaugePointer1.ThermoBackColor.BorderWidth = 1;
            gaugePointer1.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            gaugePointer1.Value = 100D;
            gaugePointer1.Width = 0.1F;
            gaugeLinearScale1.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer1});
            gaugeSection1.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection1.Name = "Section1";
            gaugeSection2.EndValue = 200D;
            gaugeSection2.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection2.LabelColor = System.Drawing.Color.Lime;
            gaugeSection2.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection2.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection2.Name = "Normal";
            gaugeSection2.StartValue = 0D;
            gaugeSection3.EndValue = 260D;
            gaugeSection3.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection3.LabelColor = System.Drawing.Color.Gold;
            gaugeSection3.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection3.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection3.Name = "Warning";
            gaugeSection3.StartValue = 200D;
            gaugeSection4.EndValue = 300D;
            gaugeSection4.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection4.LabelColor = System.Drawing.Color.Red;
            gaugeSection4.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection4.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection4.Name = "Alarm";
            gaugeSection4.StartValue = 260D;
            gaugeLinearScale1.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection1,
            gaugeSection2,
            gaugeSection3,
            gaugeSection4});
            this.gauge_gc.LinearScales.AddRange(new DevComponents.Instrumentation.GaugeLinearScale[] {
            gaugeLinearScale1});
            this.gauge_gc.Location = new System.Drawing.Point(0, 0);
            this.gauge_gc.Name = "gauge_gc";
            this.gauge_gc.Size = new System.Drawing.Size(331, 454);
            this.gauge_gc.TabIndex = 10;
            this.gauge_gc.Tag = "";
            // 
            // Temperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 482);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Temperature";
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