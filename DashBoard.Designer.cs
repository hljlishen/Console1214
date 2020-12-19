namespace Console
{
    partial class DashBoard
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
                subject.DataUpdated -= UpdateView;
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
            DevComponents.Instrumentation.GradientFillColor gradientFillColor3 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor4 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugeText gaugeText1 = new DevComponents.Instrumentation.GaugeText();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            DevComponents.Instrumentation.NumericIndicator numericIndicator1 = new DevComponents.Instrumentation.NumericIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText2 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeImage gaugeImage1 = new DevComponents.Instrumentation.GaugeImage();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale2 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor5 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor6 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer2 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection2 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection3 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection4 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection5 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor7 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor8 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.NumericIndicator numericIndicator2 = new DevComponents.Instrumentation.NumericIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText3 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.StateIndicator stateIndicator1 = new DevComponents.Instrumentation.StateIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText4 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeImage gaugeImage2 = new DevComponents.Instrumentation.GaugeImage();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale3 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor9 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor10 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer3 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection6 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection7 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection8 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection9 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor11 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor12 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.NumericIndicator numericIndicator3 = new DevComponents.Instrumentation.NumericIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText5 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.StateIndicator stateIndicator2 = new DevComponents.Instrumentation.StateIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText6 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeImage gaugeImage3 = new DevComponents.Instrumentation.GaugeImage();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale4 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor13 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor14 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer4 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection10 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection11 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection12 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection13 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor15 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor16 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.NumericIndicator numericIndicator4 = new DevComponents.Instrumentation.NumericIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText7 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.StateIndicator stateIndicator3 = new DevComponents.Instrumentation.StateIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText8 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeImage gaugeImage4 = new DevComponents.Instrumentation.GaugeImage();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor17 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor18 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugeText gaugeText9 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.NumericIndicator numericIndicator5 = new DevComponents.Instrumentation.NumericIndicator();
            DevComponents.Instrumentation.StateIndicator stateIndicator4 = new DevComponents.Instrumentation.StateIndicator();
            DevComponents.Instrumentation.GaugeLinearScale gaugeLinearScale1 = new DevComponents.Instrumentation.GaugeLinearScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor19 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor20 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer5 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection14 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection15 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection16 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection17 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale5 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor21 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor22 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer6 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection18 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection19 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection20 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection21 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor23 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor24 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.NumericIndicator numericIndicator6 = new DevComponents.Instrumentation.NumericIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText10 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeText gaugeText11 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.StateIndicator stateIndicator5 = new DevComponents.Instrumentation.StateIndicator();
            DevComponents.Instrumentation.GaugeImage gaugeImage5 = new DevComponents.Instrumentation.GaugeImage();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale6 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor25 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor26 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer7 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection22 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection23 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection24 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection25 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor27 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor28 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.NumericIndicator numericIndicator7 = new DevComponents.Instrumentation.NumericIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText12 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeText gaugeText13 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.StateIndicator stateIndicator6 = new DevComponents.Instrumentation.StateIndicator();
            DevComponents.Instrumentation.GaugeImage gaugeImage6 = new DevComponents.Instrumentation.GaugeImage();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale7 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor29 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor30 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer8 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection26 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection27 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection28 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection29 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor31 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor32 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.NumericIndicator numericIndicator8 = new DevComponents.Instrumentation.NumericIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText14 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.StateIndicator stateIndicator7 = new DevComponents.Instrumentation.StateIndicator();
            DevComponents.Instrumentation.GaugeImage gaugeImage7 = new DevComponents.Instrumentation.GaugeImage();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale8 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor33 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor34 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer9 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection30 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor35 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor36 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugeText gaugeText15 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.NumericIndicator numericIndicator9 = new DevComponents.Instrumentation.NumericIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText16 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeImage gaugeImage8 = new DevComponents.Instrumentation.GaugeImage();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale9 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor37 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor38 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer10 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection31 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection32 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection33 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection34 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor39 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor40 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.NumericIndicator numericIndicator10 = new DevComponents.Instrumentation.NumericIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText17 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeText gaugeText18 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.StateIndicator stateIndicator8 = new DevComponents.Instrumentation.StateIndicator();
            DevComponents.Instrumentation.GaugeImage gaugeImage9 = new DevComponents.Instrumentation.GaugeImage();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale10 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor41 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor42 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer11 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection35 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection36 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection37 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection38 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor43 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor44 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.NumericIndicator numericIndicator11 = new DevComponents.Instrumentation.NumericIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText19 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeText gaugeText20 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.StateIndicator stateIndicator9 = new DevComponents.Instrumentation.StateIndicator();
            DevComponents.Instrumentation.GaugeImage gaugeImage10 = new DevComponents.Instrumentation.GaugeImage();
            DevComponents.Instrumentation.GaugeCircularScale gaugeCircularScale11 = new DevComponents.Instrumentation.GaugeCircularScale();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor45 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor46 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GaugePointer gaugePointer12 = new DevComponents.Instrumentation.GaugePointer();
            DevComponents.Instrumentation.GaugeSection gaugeSection39 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection40 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection41 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GaugeSection gaugeSection42 = new DevComponents.Instrumentation.GaugeSection();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor47 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.GradientFillColor gradientFillColor48 = new DevComponents.Instrumentation.GradientFillColor();
            DevComponents.Instrumentation.NumericIndicator numericIndicator12 = new DevComponents.Instrumentation.NumericIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText21 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.StateIndicator stateIndicator10 = new DevComponents.Instrumentation.StateIndicator();
            DevComponents.Instrumentation.GaugeText gaugeText22 = new DevComponents.Instrumentation.GaugeText();
            DevComponents.Instrumentation.GaugeImage gaugeImage11 = new DevComponents.Instrumentation.GaugeImage();
            this.revolution_gc = new DevComponents.Instrumentation.GaugeControl();
            this.pressure1_gc = new DevComponents.Instrumentation.GaugeControl();
            this.pressure2_gc = new DevComponents.Instrumentation.GaugeControl();
            this.pressure3_gc = new DevComponents.Instrumentation.GaugeControl();
            this.temperature_gc = new DevComponents.Instrumentation.GaugeControl();
            this.VoltageV_gc = new DevComponents.Instrumentation.GaugeControl();
            this.CurrentC_gc = new DevComponents.Instrumentation.GaugeControl();
            this.flow_gc = new DevComponents.Instrumentation.GaugeControl();
            this.shift_gc = new DevComponents.Instrumentation.GaugeControl();
            this.VoltageC_gc = new DevComponents.Instrumentation.GaugeControl();
            this.CurrentV_gc = new DevComponents.Instrumentation.GaugeControl();
            this.pressure4_gc = new DevComponents.Instrumentation.GaugeControl();
            ((System.ComponentModel.ISupportInitialize)(this.revolution_gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressure1_gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressure2_gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressure3_gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperature_gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageV_gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentC_gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flow_gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shift_gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageC_gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentV_gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressure4_gc)).BeginInit();
            this.SuspendLayout();
            // 
            // revolution_gc
            // 
            gaugeCircularScale1.BorderColor = System.Drawing.Color.Bisque;
            gaugeCircularScale1.MajorTickMarks.Interval = 1D;
            gradientFillColor1.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor1.Color1 = System.Drawing.Color.White;
            gradientFillColor1.Color2 = System.Drawing.Color.White;
            gaugeCircularScale1.MajorTickMarks.Layout.FillColor = gradientFillColor1;
            gaugeCircularScale1.MajorTickMarks.Layout.Length = 0.27F;
            gaugeCircularScale1.MaxPin.Name = "MaxPin";
            gaugeCircularScale1.MaxValue = 5D;
            gaugeCircularScale1.MinorTickMarks.Interval = 0.1D;
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
            gaugePointer1.Length = 0F;
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
            gaugeCircularScale1.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection1});
            gaugeCircularScale1.StartAngle = 160F;
            gaugeCircularScale1.SweepAngle = 220F;
            this.revolution_gc.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale1});
            this.revolution_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor3.Color1 = System.Drawing.Color.DimGray;
            gradientFillColor3.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.revolution_gc.Frame.BackColor = gradientFillColor3;
            gradientFillColor4.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor4.BorderWidth = 1;
            gradientFillColor4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor4.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.revolution_gc.Frame.FrameColor = gradientFillColor4;
            this.revolution_gc.Frame.InnerBevel = 0F;
            this.revolution_gc.Frame.OuterBevel = 0.025F;
            this.revolution_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            gaugeText1.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText1.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gaugeText1.ForeColor = System.Drawing.Color.White;
            gaugeText1.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText1.Location")));
            gaugeText1.Name = "电流C";
            gaugeText1.Size = new System.Drawing.SizeF(0.5F, 0.6F);
            gaugeText1.Text = "转速";
            numericIndicator1.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator1.BackColor.BorderWidth = 3;
            numericIndicator1.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator1.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator1.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator1.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator1.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator1.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator1.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator1.Location")));
            numericIndicator1.MaxValue = 5000D;
            numericIndicator1.Name = "CurrencyC_Indicator";
            numericIndicator1.NumberOfDecimals = 0;
            numericIndicator1.NumberOfDigits = 4;
            numericIndicator1.ShowDecimalPoint = true;
            numericIndicator1.Size = new System.Drawing.SizeF(0.3F, 0.15F);
            numericIndicator1.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator1.Value = 2345D;
            gaugeText2.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gaugeText2.ForeColor = System.Drawing.Color.White;
            gaugeText2.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText2.Location")));
            gaugeText2.Name = "Text1";
            gaugeText2.Size = new System.Drawing.SizeF(0.3F, 0.2F);
            gaugeText2.Text = "1000RPM";
            gaugeImage1.AutoFit = true;
            gaugeImage1.Image = ((System.Drawing.Image)(resources.GetObject("gaugeImage1.Image")));
            gaugeImage1.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeImage1.Location")));
            gaugeImage1.Name = "Image1";
            gaugeImage1.Size = new System.Drawing.SizeF(0.15F, 0.15F);
            this.revolution_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            gaugeText1,
            numericIndicator1,
            gaugeText2,
            gaugeImage1});
            this.revolution_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.revolution_gc.Location = new System.Drawing.Point(366, 799);
            this.revolution_gc.Name = "revolution_gc";
            this.revolution_gc.Size = new System.Drawing.Size(340, 358);
            this.revolution_gc.TabIndex = 3;
            this.revolution_gc.Tag = "1000";
            // 
            // pressure1_gc
            // 
            gaugeCircularScale2.BorderColor = System.Drawing.Color.Bisque;
            gaugeCircularScale2.MajorTickMarks.Interval = 5D;
            gradientFillColor5.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor5.Color1 = System.Drawing.Color.White;
            gradientFillColor5.Color2 = System.Drawing.Color.White;
            gaugeCircularScale2.MajorTickMarks.Layout.FillColor = gradientFillColor5;
            gaugeCircularScale2.MajorTickMarks.Layout.Length = 0.27F;
            gaugeCircularScale2.MaxPin.Name = "MaxPin";
            gaugeCircularScale2.MaxValue = 20D;
            gaugeCircularScale2.MinorTickMarks.Interval = 1D;
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
            gaugeSection2.EndValue = 20D;
            gaugeSection2.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection2.LabelColor = System.Drawing.Color.White;
            gaugeSection2.MajorTickMarkFillColor.Color1 = System.Drawing.Color.White;
            gaugeSection2.Name = "Section1";
            gaugeSection2.StartValue = 0D;
            gaugeSection3.EndValue = 15D;
            gaugeSection3.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection3.LabelColor = System.Drawing.Color.Lime;
            gaugeSection3.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection3.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection3.Name = "Normal";
            gaugeSection3.StartValue = 0D;
            gaugeSection4.EndValue = 18D;
            gaugeSection4.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection4.LabelColor = System.Drawing.Color.Gold;
            gaugeSection4.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection4.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection4.Name = "Warning";
            gaugeSection4.StartValue = 15D;
            gaugeSection5.EndValue = 20D;
            gaugeSection5.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection5.LabelColor = System.Drawing.Color.Red;
            gaugeSection5.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection5.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection5.Name = "Alarm";
            gaugeSection5.StartValue = 18D;
            gaugeCircularScale2.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection2,
            gaugeSection3,
            gaugeSection4,
            gaugeSection5});
            gaugeCircularScale2.StartAngle = 180F;
            gaugeCircularScale2.SweepAngle = 220F;
            this.pressure1_gc.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale2});
            this.pressure1_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor7.Color1 = System.Drawing.Color.DimGray;
            gradientFillColor7.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.pressure1_gc.Frame.BackColor = gradientFillColor7;
            gradientFillColor8.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor8.BorderWidth = 1;
            gradientFillColor8.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor8.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.pressure1_gc.Frame.FrameColor = gradientFillColor8;
            this.pressure1_gc.Frame.InnerBevel = 0F;
            this.pressure1_gc.Frame.OuterBevel = 0.025F;
            this.pressure1_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            numericIndicator2.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator2.BackColor.BorderWidth = 3;
            numericIndicator2.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator2.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator2.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator2.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator2.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator2.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator2.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator2.Location")));
            numericIndicator2.MaxValue = 20D;
            numericIndicator2.Name = "CurrencyC_Indicator";
            numericIndicator2.NumberOfDigits = 4;
            numericIndicator2.ShowDecimalPoint = true;
            numericIndicator2.Size = new System.Drawing.SizeF(0.35F, 0.15F);
            numericIndicator2.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator2.Value = 15.5D;
            gaugeText3.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            gaugeText3.ForeColor = System.Drawing.Color.White;
            gaugeText3.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText3.Location")));
            gaugeText3.Name = "Text1";
            gaugeText3.Size = new System.Drawing.SizeF(0.3F, 0.2F);
            gaugeText3.Text = "MPA";
            stateIndicator1.BackColor.BorderColor = System.Drawing.Color.Black;
            stateIndicator1.BackColor.Color1 = System.Drawing.Color.Lime;
            stateIndicator1.BackColor.Color2 = System.Drawing.Color.Lime;
            stateIndicator1.EmptyString = "";
            stateIndicator1.Location = ((System.Drawing.PointF)(resources.GetObject("stateIndicator1.Location")));
            stateIndicator1.Name = "StateIndicator1";
            gaugeText4.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText4.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gaugeText4.ForeColor = System.Drawing.Color.White;
            gaugeText4.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText4.Location")));
            gaugeText4.Name = "Text2";
            gaugeText4.Text = "压力1";
            gaugeImage2.AutoFit = true;
            gaugeImage2.Image = global::Console.Resource1.circle;
            gaugeImage2.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeImage2.Location")));
            gaugeImage2.Name = "Image1";
            gaugeImage2.Size = new System.Drawing.SizeF(0.15F, 0.15F);
            this.pressure1_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            numericIndicator2,
            gaugeText3,
            stateIndicator1,
            gaugeText4,
            gaugeImage2});
            this.pressure1_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.pressure1_gc.Location = new System.Drawing.Point(1175, 12);
            this.pressure1_gc.Name = "pressure1_gc";
            this.pressure1_gc.Size = new System.Drawing.Size(340, 358);
            this.pressure1_gc.TabIndex = 5;
            // 
            // pressure2_gc
            // 
            gaugeCircularScale3.BorderColor = System.Drawing.Color.Bisque;
            gaugeCircularScale3.MajorTickMarks.Interval = 5D;
            gradientFillColor9.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor9.Color1 = System.Drawing.Color.White;
            gradientFillColor9.Color2 = System.Drawing.Color.White;
            gaugeCircularScale3.MajorTickMarks.Layout.FillColor = gradientFillColor9;
            gaugeCircularScale3.MajorTickMarks.Layout.Length = 0.27F;
            gaugeCircularScale3.MaxPin.Name = "MaxPin";
            gaugeCircularScale3.MaxValue = 20D;
            gaugeCircularScale3.MinorTickMarks.Interval = 1D;
            gradientFillColor10.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor10.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor10.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugeCircularScale3.MinorTickMarks.Layout.FillColor = gradientFillColor10;
            gaugeCircularScale3.MinorTickMarks.Layout.Length = 0.17F;
            gaugeCircularScale3.MinorTickMarks.Layout.Width = 0.05F;
            gaugeCircularScale3.MinPin.Name = "MinPin";
            gaugeCircularScale3.Name = "Scale1";
            gaugePointer3.AllowUserChange = true;
            gaugePointer3.CapFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer3.CapFillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer3.CapFillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer3.CapWidth = 0.2F;
            gaugePointer3.FillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer3.FillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer3.FillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer3.Length = 0F;
            gaugePointer3.Name = "Pointer1";
            gaugePointer3.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style4;
            gaugePointer3.ScaleOffset = -0.1F;
            gaugePointer3.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer3.Value = 2.5D;
            gaugePointer3.Width = 0.05F;
            gaugeCircularScale3.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer3});
            gaugeSection6.EndValue = 20D;
            gaugeSection6.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection6.LabelColor = System.Drawing.Color.White;
            gaugeSection6.MajorTickMarkFillColor.Color1 = System.Drawing.Color.White;
            gaugeSection6.Name = "Section1";
            gaugeSection6.StartValue = 0D;
            gaugeSection7.EndValue = 15D;
            gaugeSection7.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection7.LabelColor = System.Drawing.Color.Lime;
            gaugeSection7.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection7.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection7.Name = "Normal";
            gaugeSection7.StartValue = 0D;
            gaugeSection8.EndValue = 18D;
            gaugeSection8.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection8.LabelColor = System.Drawing.Color.Gold;
            gaugeSection8.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection8.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection8.Name = "Warning";
            gaugeSection8.StartValue = 15D;
            gaugeSection9.EndValue = 20D;
            gaugeSection9.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection9.LabelColor = System.Drawing.Color.Red;
            gaugeSection9.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection9.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection9.Name = "Alarm";
            gaugeSection9.StartValue = 18D;
            gaugeCircularScale3.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection6,
            gaugeSection7,
            gaugeSection8,
            gaugeSection9});
            gaugeCircularScale3.StartAngle = 180F;
            gaugeCircularScale3.SweepAngle = 220F;
            this.pressure2_gc.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale3});
            this.pressure2_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor11.Color1 = System.Drawing.Color.DimGray;
            gradientFillColor11.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.pressure2_gc.Frame.BackColor = gradientFillColor11;
            gradientFillColor12.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor12.BorderWidth = 1;
            gradientFillColor12.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor12.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.pressure2_gc.Frame.FrameColor = gradientFillColor12;
            this.pressure2_gc.Frame.InnerBevel = 0F;
            this.pressure2_gc.Frame.OuterBevel = 0.025F;
            this.pressure2_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            numericIndicator3.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator3.BackColor.BorderWidth = 3;
            numericIndicator3.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator3.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator3.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator3.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator3.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator3.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator3.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator3.Location")));
            numericIndicator3.MaxValue = 20D;
            numericIndicator3.Name = "CurrencyC_Indicator";
            numericIndicator3.NumberOfDigits = 4;
            numericIndicator3.ShowDecimalPoint = true;
            numericIndicator3.Size = new System.Drawing.SizeF(0.35F, 0.15F);
            numericIndicator3.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator3.Value = 15.5D;
            gaugeText5.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            gaugeText5.ForeColor = System.Drawing.Color.White;
            gaugeText5.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText5.Location")));
            gaugeText5.Name = "Text1";
            gaugeText5.Size = new System.Drawing.SizeF(0.3F, 0.2F);
            gaugeText5.Text = "MPA";
            stateIndicator2.BackColor.BorderColor = System.Drawing.Color.Black;
            stateIndicator2.BackColor.Color1 = System.Drawing.Color.Lime;
            stateIndicator2.BackColor.Color2 = System.Drawing.Color.Lime;
            stateIndicator2.EmptyString = "";
            stateIndicator2.Location = ((System.Drawing.PointF)(resources.GetObject("stateIndicator2.Location")));
            stateIndicator2.Name = "StateIndicator1";
            gaugeText6.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText6.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold);
            gaugeText6.ForeColor = System.Drawing.Color.White;
            gaugeText6.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText6.Location")));
            gaugeText6.Name = "Text2";
            gaugeText6.Text = "压力2";
            gaugeImage3.AutoFit = true;
            gaugeImage3.Image = global::Console.Resource1.circle;
            gaugeImage3.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeImage3.Location")));
            gaugeImage3.Name = "Image1";
            gaugeImage3.Size = new System.Drawing.SizeF(0.15F, 0.15F);
            this.pressure2_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            numericIndicator3,
            gaugeText5,
            stateIndicator2,
            gaugeText6,
            gaugeImage3});
            this.pressure2_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.pressure2_gc.Location = new System.Drawing.Point(1572, 12);
            this.pressure2_gc.Name = "pressure2_gc";
            this.pressure2_gc.Size = new System.Drawing.Size(340, 358);
            this.pressure2_gc.TabIndex = 6;
            // 
            // pressure3_gc
            // 
            gaugeCircularScale4.BorderColor = System.Drawing.Color.Bisque;
            gaugeCircularScale4.MajorTickMarks.Interval = 5D;
            gradientFillColor13.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor13.Color1 = System.Drawing.Color.White;
            gradientFillColor13.Color2 = System.Drawing.Color.White;
            gaugeCircularScale4.MajorTickMarks.Layout.FillColor = gradientFillColor13;
            gaugeCircularScale4.MajorTickMarks.Layout.Length = 0.27F;
            gaugeCircularScale4.MaxPin.Name = "MaxPin";
            gaugeCircularScale4.MaxValue = 20D;
            gaugeCircularScale4.MinorTickMarks.Interval = 1D;
            gradientFillColor14.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor14.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor14.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugeCircularScale4.MinorTickMarks.Layout.FillColor = gradientFillColor14;
            gaugeCircularScale4.MinorTickMarks.Layout.Length = 0.17F;
            gaugeCircularScale4.MinorTickMarks.Layout.Width = 0.05F;
            gaugeCircularScale4.MinPin.Name = "MinPin";
            gaugeCircularScale4.Name = "Scale1";
            gaugePointer4.AllowUserChange = true;
            gaugePointer4.CapFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer4.CapFillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer4.CapFillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer4.CapWidth = 0.2F;
            gaugePointer4.FillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer4.FillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer4.FillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer4.Length = 0F;
            gaugePointer4.Name = "Pointer1";
            gaugePointer4.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style4;
            gaugePointer4.ScaleOffset = -0.1F;
            gaugePointer4.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer4.Value = 2.5D;
            gaugePointer4.Width = 0.05F;
            gaugeCircularScale4.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer4});
            gaugeSection10.EndValue = 20D;
            gaugeSection10.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection10.LabelColor = System.Drawing.Color.White;
            gaugeSection10.MajorTickMarkFillColor.Color1 = System.Drawing.Color.White;
            gaugeSection10.Name = "Section1";
            gaugeSection10.StartValue = 0D;
            gaugeSection11.EndValue = 15D;
            gaugeSection11.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection11.LabelColor = System.Drawing.Color.Lime;
            gaugeSection11.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection11.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection11.Name = "Normal";
            gaugeSection11.StartValue = 0D;
            gaugeSection12.EndValue = 18D;
            gaugeSection12.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection12.LabelColor = System.Drawing.Color.Gold;
            gaugeSection12.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection12.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection12.Name = "Warning";
            gaugeSection12.StartValue = 15D;
            gaugeSection13.EndValue = 20D;
            gaugeSection13.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection13.LabelColor = System.Drawing.Color.Red;
            gaugeSection13.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection13.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection13.Name = "Alarm";
            gaugeSection13.StartValue = 18D;
            gaugeCircularScale4.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection10,
            gaugeSection11,
            gaugeSection12,
            gaugeSection13});
            gaugeCircularScale4.StartAngle = 180F;
            gaugeCircularScale4.SweepAngle = 220F;
            this.pressure3_gc.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale4});
            this.pressure3_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor15.Color1 = System.Drawing.Color.DimGray;
            gradientFillColor15.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.pressure3_gc.Frame.BackColor = gradientFillColor15;
            gradientFillColor16.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor16.BorderWidth = 1;
            gradientFillColor16.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor16.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.pressure3_gc.Frame.FrameColor = gradientFillColor16;
            this.pressure3_gc.Frame.InnerBevel = 0F;
            this.pressure3_gc.Frame.OuterBevel = 0.025F;
            this.pressure3_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            numericIndicator4.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator4.BackColor.BorderWidth = 3;
            numericIndicator4.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator4.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator4.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator4.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator4.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator4.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator4.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator4.Location")));
            numericIndicator4.MaxValue = 20D;
            numericIndicator4.Name = "CurrencyC_Indicator";
            numericIndicator4.NumberOfDigits = 4;
            numericIndicator4.ShowDecimalPoint = true;
            numericIndicator4.Size = new System.Drawing.SizeF(0.35F, 0.15F);
            numericIndicator4.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator4.Value = 15.5D;
            gaugeText7.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            gaugeText7.ForeColor = System.Drawing.Color.White;
            gaugeText7.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText7.Location")));
            gaugeText7.Name = "Text1";
            gaugeText7.Size = new System.Drawing.SizeF(0.3F, 0.2F);
            gaugeText7.Text = "MPA";
            stateIndicator3.BackColor.BorderColor = System.Drawing.Color.Black;
            stateIndicator3.BackColor.Color1 = System.Drawing.Color.Lime;
            stateIndicator3.BackColor.Color2 = System.Drawing.Color.Lime;
            stateIndicator3.EmptyString = "";
            stateIndicator3.Location = ((System.Drawing.PointF)(resources.GetObject("stateIndicator3.Location")));
            stateIndicator3.Name = "StateIndicator1";
            gaugeText8.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText8.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold);
            gaugeText8.ForeColor = System.Drawing.Color.White;
            gaugeText8.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText8.Location")));
            gaugeText8.Name = "Text2";
            gaugeText8.Text = "压力3";
            gaugeImage4.AutoFit = true;
            gaugeImage4.Image = global::Console.Resource1.circle;
            gaugeImage4.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeImage4.Location")));
            gaugeImage4.Name = "Image1";
            gaugeImage4.Size = new System.Drawing.SizeF(0.15F, 0.15F);
            this.pressure3_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            numericIndicator4,
            gaugeText7,
            stateIndicator3,
            gaugeText8,
            gaugeImage4});
            this.pressure3_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.pressure3_gc.Location = new System.Drawing.Point(1175, 418);
            this.pressure3_gc.Name = "pressure3_gc";
            this.pressure3_gc.Size = new System.Drawing.Size(340, 358);
            this.pressure3_gc.TabIndex = 8;
            // 
            // temperature_gc
            // 
            this.temperature_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor17.Color1 = System.Drawing.Color.DimGray;
            gradientFillColor17.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.temperature_gc.Frame.BackColor = gradientFillColor17;
            gradientFillColor18.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor18.BorderWidth = 1;
            gradientFillColor18.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor18.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.temperature_gc.Frame.FrameColor = gradientFillColor18;
            this.temperature_gc.Frame.InnerBevel = 0F;
            this.temperature_gc.Frame.OuterBevel = 0.025F;
            this.temperature_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.RoundedRectangular;
            gaugeText9.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText9.Font = new System.Drawing.Font("等线", 24F, System.Drawing.FontStyle.Bold);
            gaugeText9.ForeColor = System.Drawing.Color.White;
            gaugeText9.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText9.Location")));
            gaugeText9.Name = "电流C";
            gaugeText9.Size = new System.Drawing.SizeF(0.5F, 0.6F);
            gaugeText9.Text = "温度(℃)";
            numericIndicator5.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator5.BackColor.BorderWidth = 3;
            numericIndicator5.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator5.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator5.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator5.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator5.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator5.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator5.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator5.Location")));
            numericIndicator5.MaxValue = 300D;
            numericIndicator5.Name = "CurrencyC_Indicator";
            numericIndicator5.NumberOfDecimals = 0;
            numericIndicator5.NumberOfDigits = 4;
            numericIndicator5.ShowDecimalPoint = true;
            numericIndicator5.Size = new System.Drawing.SizeF(0.3F, 0.15F);
            numericIndicator5.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator5.Value = 200D;
            stateIndicator4.AutoSize = false;
            stateIndicator4.BackColor.BorderColor = System.Drawing.Color.Black;
            stateIndicator4.BackColor.Color1 = System.Drawing.Color.Lime;
            stateIndicator4.BackColor.Color2 = System.Drawing.Color.Lime;
            stateIndicator4.EmptyString = "";
            stateIndicator4.Location = ((System.Drawing.PointF)(resources.GetObject("stateIndicator4.Location")));
            stateIndicator4.Name = "StateIndicator1";
            stateIndicator4.Size = new System.Drawing.SizeF(0.07F, 0.05F);
            stateIndicator4.Style = DevComponents.Instrumentation.StateIndicatorStyle.RoundedRectangular;
            this.temperature_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            gaugeText9,
            numericIndicator5,
            stateIndicator4});
            this.temperature_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            gaugeLinearScale1.Labels.Layout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gaugeLinearScale1.Labels.Layout.ForeColor = System.Drawing.Color.Transparent;
            gaugeLinearScale1.Labels.Layout.ScaleOffset = 0.05F;
            gaugeLinearScale1.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeLinearScale1.Location")));
            gaugeLinearScale1.MajorTickMarks.Interval = 100D;
            gradientFillColor19.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor19.Color1 = System.Drawing.Color.White;
            gaugeLinearScale1.MajorTickMarks.Layout.FillColor = gradientFillColor19;
            gaugeLinearScale1.MajorTickMarks.Layout.Width = 0.03F;
            gaugeLinearScale1.MaxPin.Name = "MaxPin";
            gaugeLinearScale1.MaxValue = 300D;
            gaugeLinearScale1.MinorTickMarks.Interval = 20D;
            gradientFillColor20.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor20.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugeLinearScale1.MinorTickMarks.Layout.FillColor = gradientFillColor20;
            gaugeLinearScale1.MinorTickMarks.Layout.Width = 0.03F;
            gaugeLinearScale1.MinPin.Name = "MinPin";
            gaugeLinearScale1.Name = "Scale1";
            gaugeLinearScale1.Orientation = System.Windows.Forms.Orientation.Vertical;
            gaugePointer5.CapFillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer5.CapFillColor.BorderWidth = 1;
            gaugePointer5.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke;
            gaugePointer5.CapFillColor.Color2 = System.Drawing.Color.DimGray;
            gaugePointer5.FillColor.BorderColor = System.Drawing.Color.DimGray;
            gaugePointer5.FillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer5.Name = "Pointer1";
            gaugePointer5.Placement = DevComponents.Instrumentation.DisplayPlacement.Far;
            gaugePointer5.ThermoBackColor.BorderColor = System.Drawing.Color.Black;
            gaugePointer5.ThermoBackColor.BorderWidth = 1;
            gaugePointer5.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            gaugePointer5.Value = 100D;
            gaugePointer5.Width = 0.1F;
            gaugeLinearScale1.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer5});
            gaugeSection14.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection14.Name = "Section1";
            gaugeSection15.EndValue = 200D;
            gaugeSection15.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection15.LabelColor = System.Drawing.Color.Lime;
            gaugeSection15.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection15.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection15.Name = "Normal";
            gaugeSection15.StartValue = 0D;
            gaugeSection16.EndValue = 260D;
            gaugeSection16.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection16.LabelColor = System.Drawing.Color.Gold;
            gaugeSection16.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection16.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection16.Name = "Warning";
            gaugeSection16.StartValue = 200D;
            gaugeSection17.EndValue = 300D;
            gaugeSection17.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection17.LabelColor = System.Drawing.Color.Red;
            gaugeSection17.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection17.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection17.Name = "Alarm";
            gaugeSection17.StartValue = 260D;
            gaugeLinearScale1.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection14,
            gaugeSection15,
            gaugeSection16,
            gaugeSection17});
            this.temperature_gc.LinearScales.AddRange(new DevComponents.Instrumentation.GaugeLinearScale[] {
            gaugeLinearScale1});
            this.temperature_gc.Location = new System.Drawing.Point(784, 385);
            this.temperature_gc.Name = "temperature_gc";
            this.temperature_gc.Size = new System.Drawing.Size(319, 485);
            this.temperature_gc.TabIndex = 9;
            this.temperature_gc.Tag = "";
            // 
            // VoltageV_gc
            // 
            gaugeCircularScale5.BorderColor = System.Drawing.Color.Bisque;
            gaugeCircularScale5.MajorTickMarks.Interval = 100D;
            gradientFillColor21.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor21.Color1 = System.Drawing.Color.White;
            gradientFillColor21.Color2 = System.Drawing.Color.White;
            gaugeCircularScale5.MajorTickMarks.Layout.FillColor = gradientFillColor21;
            gaugeCircularScale5.MajorTickMarks.Layout.Length = 0.27F;
            gaugeCircularScale5.MaxPin.Name = "MaxPin";
            gaugeCircularScale5.MaxValue = 450D;
            gaugeCircularScale5.MinorTickMarks.Interval = 10D;
            gradientFillColor22.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor22.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor22.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugeCircularScale5.MinorTickMarks.Layout.FillColor = gradientFillColor22;
            gaugeCircularScale5.MinorTickMarks.Layout.Length = 0.17F;
            gaugeCircularScale5.MinorTickMarks.Layout.Width = 0.05F;
            gaugeCircularScale5.MinPin.Name = "MinPin";
            gaugeCircularScale5.Name = "Scale1";
            gaugePointer6.AllowUserChange = true;
            gaugePointer6.CapFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer6.CapFillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer6.CapFillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer6.CapWidth = 0.2F;
            gaugePointer6.FillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer6.FillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer6.FillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer6.Length = -0.1F;
            gaugePointer6.Name = "Pointer1";
            gaugePointer6.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style4;
            gaugePointer6.ScaleOffset = -0.1F;
            gaugePointer6.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer6.Value = 2.5D;
            gaugePointer6.Width = 0.05F;
            gaugeCircularScale5.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer6});
            gaugeSection18.EndValue = 5D;
            gaugeSection18.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection18.FillColor.Color2 = System.Drawing.Color.Transparent;
            gaugeSection18.LabelColor = System.Drawing.Color.White;
            gaugeSection18.MajorTickMarkFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            gaugeSection18.MajorTickMarkFillColor.Color1 = System.Drawing.Color.White;
            gaugeSection18.MajorTickMarkFillColor.Color2 = System.Drawing.Color.White;
            gaugeSection18.Name = "Section1";
            gaugeSection18.StartValue = 0D;
            gaugeSection19.EndValue = 360D;
            gaugeSection19.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection19.LabelColor = System.Drawing.Color.Lime;
            gaugeSection19.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection19.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection19.Name = "Normal";
            gaugeSection19.StartValue = 0D;
            gaugeSection20.EndValue = 420D;
            gaugeSection20.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection20.LabelColor = System.Drawing.Color.Gold;
            gaugeSection20.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection20.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection20.Name = "Warning";
            gaugeSection20.StartValue = 360D;
            gaugeSection21.EndValue = 450D;
            gaugeSection21.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection21.LabelColor = System.Drawing.Color.Red;
            gaugeSection21.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection21.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection21.Name = "Alarm";
            gaugeSection21.StartValue = 420D;
            gaugeCircularScale5.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection18,
            gaugeSection19,
            gaugeSection20,
            gaugeSection21});
            gaugeCircularScale5.StartAngle = 160F;
            gaugeCircularScale5.SweepAngle = 220F;
            this.VoltageV_gc.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale5});
            this.VoltageV_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor23.Color1 = System.Drawing.Color.DarkBlue;
            gradientFillColor23.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.VoltageV_gc.Frame.BackColor = gradientFillColor23;
            gradientFillColor24.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor24.BorderWidth = 1;
            gradientFillColor24.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor24.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.VoltageV_gc.Frame.FrameColor = gradientFillColor24;
            this.VoltageV_gc.Frame.InnerBevel = 0F;
            this.VoltageV_gc.Frame.OuterBevel = 0.025F;
            this.VoltageV_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            numericIndicator6.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator6.BackColor.BorderWidth = 3;
            numericIndicator6.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator6.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator6.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator6.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator6.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator6.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator6.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator6.Location")));
            numericIndicator6.MaxValue = 500D;
            numericIndicator6.Name = "CurrencyC_Indicator";
            numericIndicator6.NumberOfDecimals = 1;
            numericIndicator6.NumberOfDigits = 4;
            numericIndicator6.ShowDecimalPoint = true;
            numericIndicator6.Size = new System.Drawing.SizeF(0.3F, 0.15F);
            numericIndicator6.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator6.Value = 300D;
            gaugeText10.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText10.Font = new System.Drawing.Font("Perpetua Titling MT", 24F);
            gaugeText10.ForeColor = System.Drawing.Color.White;
            gaugeText10.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText10.Location")));
            gaugeText10.Name = "Text1";
            gaugeText10.Size = new System.Drawing.SizeF(0.3F, 0.2F);
            gaugeText10.Text = "~";
            gaugeText11.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            gaugeText11.ForeColor = System.Drawing.Color.White;
            gaugeText11.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText11.Location")));
            gaugeText11.Name = "Text2";
            gaugeText11.Text = "V";
            stateIndicator5.BackColor.BorderColor = System.Drawing.Color.Black;
            stateIndicator5.BackColor.Color1 = System.Drawing.Color.Lime;
            stateIndicator5.BackColor.Color2 = System.Drawing.Color.Lime;
            stateIndicator5.EmptyString = "";
            stateIndicator5.Location = ((System.Drawing.PointF)(resources.GetObject("stateIndicator5.Location")));
            stateIndicator5.Name = "StateIndicator1";
            stateIndicator5.Size = new System.Drawing.SizeF(0.06F, 0.06F);
            gaugeImage5.AutoFit = true;
            gaugeImage5.Image = ((System.Drawing.Image)(resources.GetObject("gaugeImage5.Image")));
            gaugeImage5.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeImage5.Location")));
            gaugeImage5.Name = "Image1";
            gaugeImage5.Size = new System.Drawing.SizeF(0.15F, 0.15F);
            this.VoltageV_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            numericIndicator6,
            gaugeText10,
            gaugeText11,
            stateIndicator5,
            gaugeImage5});
            this.VoltageV_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.VoltageV_gc.Location = new System.Drawing.Point(12, 21);
            this.VoltageV_gc.Name = "VoltageV_gc";
            this.VoltageV_gc.Size = new System.Drawing.Size(340, 358);
            this.VoltageV_gc.TabIndex = 10;
            this.VoltageV_gc.Tag = "";
            // 
            // CurrentC_gc
            // 
            gaugeCircularScale6.BorderColor = System.Drawing.Color.Bisque;
            gaugeCircularScale6.MajorTickMarks.Interval = 1D;
            gradientFillColor25.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor25.Color1 = System.Drawing.Color.White;
            gradientFillColor25.Color2 = System.Drawing.Color.White;
            gaugeCircularScale6.MajorTickMarks.Layout.FillColor = gradientFillColor25;
            gaugeCircularScale6.MajorTickMarks.Layout.Length = 0.27F;
            gaugeCircularScale6.MaxPin.Name = "MaxPin";
            gaugeCircularScale6.MaxValue = 5D;
            gaugeCircularScale6.MinorTickMarks.Interval = 0.1D;
            gradientFillColor26.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor26.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor26.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugeCircularScale6.MinorTickMarks.Layout.FillColor = gradientFillColor26;
            gaugeCircularScale6.MinorTickMarks.Layout.Length = 0.17F;
            gaugeCircularScale6.MinorTickMarks.Layout.Width = 0.05F;
            gaugeCircularScale6.MinPin.Name = "MinPin";
            gaugeCircularScale6.Name = "Scale1";
            gaugePointer7.AllowUserChange = true;
            gaugePointer7.CapFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer7.CapFillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer7.CapFillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer7.CapWidth = 0.2F;
            gaugePointer7.FillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer7.FillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer7.FillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer7.Length = -0.1F;
            gaugePointer7.Name = "Pointer1";
            gaugePointer7.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style4;
            gaugePointer7.ScaleOffset = -0.1F;
            gaugePointer7.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer7.Value = 2.5D;
            gaugePointer7.Width = 0.05F;
            gaugeCircularScale6.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer7});
            gaugeSection22.EndValue = 5D;
            gaugeSection22.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection22.FillColor.Color2 = System.Drawing.Color.Transparent;
            gaugeSection22.LabelColor = System.Drawing.Color.White;
            gaugeSection22.MajorTickMarkFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            gaugeSection22.MajorTickMarkFillColor.Color1 = System.Drawing.Color.White;
            gaugeSection22.MajorTickMarkFillColor.Color2 = System.Drawing.Color.White;
            gaugeSection22.Name = "Section1";
            gaugeSection22.StartValue = 0D;
            gaugeSection23.EndValue = 4D;
            gaugeSection23.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection23.LabelColor = System.Drawing.Color.Lime;
            gaugeSection23.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection23.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection23.Name = "Normal";
            gaugeSection23.StartValue = 0D;
            gaugeSection24.EndValue = 4.5D;
            gaugeSection24.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection24.LabelColor = System.Drawing.Color.Gold;
            gaugeSection24.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection24.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection24.Name = "Warning";
            gaugeSection24.StartValue = 4D;
            gaugeSection25.EndValue = 5D;
            gaugeSection25.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection25.LabelColor = System.Drawing.Color.Red;
            gaugeSection25.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection25.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection25.Name = "Alarm";
            gaugeSection25.StartValue = 4.5D;
            gaugeCircularScale6.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection22,
            gaugeSection23,
            gaugeSection24,
            gaugeSection25});
            gaugeCircularScale6.StartAngle = 160F;
            gaugeCircularScale6.SweepAngle = 220F;
            this.CurrentC_gc.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale6});
            this.CurrentC_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor27.Color1 = System.Drawing.Color.DimGray;
            gradientFillColor27.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.CurrentC_gc.Frame.BackColor = gradientFillColor27;
            gradientFillColor28.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor28.BorderWidth = 1;
            gradientFillColor28.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor28.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.CurrentC_gc.Frame.FrameColor = gradientFillColor28;
            this.CurrentC_gc.Frame.InnerBevel = 0F;
            this.CurrentC_gc.Frame.OuterBevel = 0.025F;
            this.CurrentC_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            numericIndicator7.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator7.BackColor.BorderWidth = 3;
            numericIndicator7.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator7.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator7.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator7.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator7.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator7.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator7.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator7.Location")));
            numericIndicator7.MaxValue = 6D;
            numericIndicator7.Name = "CurrencyC_Indicator";
            numericIndicator7.NumberOfDigits = 3;
            numericIndicator7.ShowDecimalPoint = true;
            numericIndicator7.Size = new System.Drawing.SizeF(0.3F, 0.15F);
            numericIndicator7.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator7.Value = 3D;
            gaugeText12.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText12.Font = new System.Drawing.Font("Perpetua Titling MT", 24F);
            gaugeText12.ForeColor = System.Drawing.Color.White;
            gaugeText12.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText12.Location")));
            gaugeText12.Name = "Text1";
            gaugeText12.Size = new System.Drawing.SizeF(0.3F, 0.2F);
            gaugeText12.Text = "~";
            gaugeText13.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            gaugeText13.ForeColor = System.Drawing.Color.White;
            gaugeText13.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText13.Location")));
            gaugeText13.Name = "Text2";
            gaugeText13.Text = "A";
            stateIndicator6.BackColor.BorderColor = System.Drawing.Color.Black;
            stateIndicator6.BackColor.Color1 = System.Drawing.Color.Lime;
            stateIndicator6.BackColor.Color2 = System.Drawing.Color.Lime;
            stateIndicator6.EmptyString = "";
            stateIndicator6.Location = ((System.Drawing.PointF)(resources.GetObject("stateIndicator6.Location")));
            stateIndicator6.Name = "StateIndicator1";
            stateIndicator6.Size = new System.Drawing.SizeF(0.06F, 0.06F);
            gaugeImage6.AutoFit = true;
            gaugeImage6.Image = ((System.Drawing.Image)(resources.GetObject("gaugeImage6.Image")));
            gaugeImage6.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeImage6.Location")));
            gaugeImage6.Name = "Image1";
            gaugeImage6.Size = new System.Drawing.SizeF(0.15F, 0.15F);
            this.CurrentC_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            numericIndicator7,
            gaugeText12,
            gaugeText13,
            stateIndicator6,
            gaugeImage6});
            this.CurrentC_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.CurrentC_gc.Location = new System.Drawing.Point(366, 21);
            this.CurrentC_gc.Name = "CurrentC_gc";
            this.CurrentC_gc.Size = new System.Drawing.Size(340, 358);
            this.CurrentC_gc.TabIndex = 12;
            this.CurrentC_gc.Tag = "";
            // 
            // flow_gc
            // 
            gaugeCircularScale7.BorderColor = System.Drawing.Color.Bisque;
            gaugeCircularScale7.Labels.Layout.RotateLabel = false;
            gaugeCircularScale7.MajorTickMarks.Interval = 1D;
            gradientFillColor29.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor29.Color1 = System.Drawing.Color.White;
            gradientFillColor29.Color2 = System.Drawing.Color.White;
            gaugeCircularScale7.MajorTickMarks.Layout.FillColor = gradientFillColor29;
            gaugeCircularScale7.MajorTickMarks.Layout.Length = 0.27F;
            gaugeCircularScale7.MaxPin.Name = "MaxPin";
            gaugeCircularScale7.MaxValue = 6D;
            gaugeCircularScale7.MinorTickMarks.Interval = 0.1D;
            gradientFillColor30.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor30.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor30.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugeCircularScale7.MinorTickMarks.Layout.FillColor = gradientFillColor30;
            gaugeCircularScale7.MinorTickMarks.Layout.Length = 0.17F;
            gaugeCircularScale7.MinorTickMarks.Layout.Width = 0.05F;
            gaugeCircularScale7.MinPin.Name = "MinPin";
            gaugeCircularScale7.MinValue = 0.6D;
            gaugeCircularScale7.Name = "Scale1";
            gaugePointer8.AllowUserChange = true;
            gaugePointer8.CapFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer8.CapFillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer8.CapFillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer8.CapWidth = 0.2F;
            gaugePointer8.FillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer8.FillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer8.FillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer8.Length = -0.1F;
            gaugePointer8.Name = "Pointer1";
            gaugePointer8.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style4;
            gaugePointer8.ScaleOffset = -0.1F;
            gaugePointer8.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer8.Value = 2.5D;
            gaugePointer8.Width = 0.05F;
            gaugeCircularScale7.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer8});
            gaugeSection26.EndValue = 5D;
            gaugeSection26.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection26.FillColor.Color2 = System.Drawing.Color.Transparent;
            gaugeSection26.LabelColor = System.Drawing.Color.White;
            gaugeSection26.MajorTickMarkFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            gaugeSection26.MajorTickMarkFillColor.Color1 = System.Drawing.Color.White;
            gaugeSection26.MajorTickMarkFillColor.Color2 = System.Drawing.Color.White;
            gaugeSection26.Name = "Section1";
            gaugeSection26.StartValue = 0D;
            gaugeSection27.EndValue = 4.6D;
            gaugeSection27.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection27.LabelColor = System.Drawing.Color.Lime;
            gaugeSection27.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection27.MajorTickMarkFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.None;
            gaugeSection27.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection27.MinorTickMarkFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.None;
            gaugeSection27.Name = "Normal";
            gaugeSection27.StartValue = 0D;
            gaugeSection28.EndValue = 5.6D;
            gaugeSection28.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection28.LabelColor = System.Drawing.Color.Gold;
            gaugeSection28.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection28.MajorTickMarkFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.None;
            gaugeSection28.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection28.MinorTickMarkFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.None;
            gaugeSection28.Name = "Warning";
            gaugeSection28.StartValue = 4.6D;
            gaugeSection29.EndValue = 6D;
            gaugeSection29.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection29.LabelColor = System.Drawing.Color.Red;
            gaugeSection29.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection29.MajorTickMarkFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.None;
            gaugeSection29.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection29.MinorTickMarkFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.None;
            gaugeSection29.Name = "Alarm";
            gaugeSection29.StartValue = 5.6D;
            gaugeCircularScale7.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection26,
            gaugeSection27,
            gaugeSection28,
            gaugeSection29});
            gaugeCircularScale7.StartAngle = 160F;
            gaugeCircularScale7.SweepAngle = 220F;
            this.flow_gc.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale7});
            this.flow_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor31.Color1 = System.Drawing.Color.DimGray;
            gradientFillColor31.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.flow_gc.Frame.BackColor = gradientFillColor31;
            gradientFillColor32.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor32.BorderWidth = 1;
            gradientFillColor32.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.flow_gc.Frame.FrameColor = gradientFillColor32;
            this.flow_gc.Frame.InnerBevel = 0F;
            this.flow_gc.Frame.OuterBevel = 0.025F;
            this.flow_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            numericIndicator8.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator8.BackColor.BorderWidth = 3;
            numericIndicator8.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator8.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator8.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator8.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator8.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator8.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator8.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator8.Location")));
            numericIndicator8.MaxValue = 500D;
            numericIndicator8.Name = "CurrencyC_Indicator";
            numericIndicator8.NumberOfDigits = 3;
            numericIndicator8.ShowDecimalPoint = true;
            numericIndicator8.Size = new System.Drawing.SizeF(0.3F, 0.15F);
            numericIndicator8.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator8.Value = 4.25D;
            gaugeText14.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            gaugeText14.ForeColor = System.Drawing.Color.White;
            gaugeText14.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText14.Location")));
            gaugeText14.Name = "Text2";
            gaugeText14.Size = new System.Drawing.SizeF(0.4F, 0.4F);
            gaugeText14.Text = "流量m³/h";
            stateIndicator7.BackColor.BorderColor = System.Drawing.Color.Black;
            stateIndicator7.BackColor.Color1 = System.Drawing.Color.Lime;
            stateIndicator7.BackColor.Color2 = System.Drawing.Color.Lime;
            stateIndicator7.EmptyString = "";
            stateIndicator7.Location = ((System.Drawing.PointF)(resources.GetObject("stateIndicator7.Location")));
            stateIndicator7.Name = "StateIndicator1";
            stateIndicator7.Size = new System.Drawing.SizeF(0.06F, 0.06F);
            gaugeImage7.AutoFit = true;
            gaugeImage7.Image = ((System.Drawing.Image)(resources.GetObject("gaugeImage7.Image")));
            gaugeImage7.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeImage7.Location")));
            gaugeImage7.Name = "Image1";
            gaugeImage7.Size = new System.Drawing.SizeF(0.15F, 0.15F);
            this.flow_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            numericIndicator8,
            gaugeText14,
            stateIndicator7,
            gaugeImage7});
            this.flow_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.flow_gc.Location = new System.Drawing.Point(1175, 799);
            this.flow_gc.Name = "flow_gc";
            this.flow_gc.Size = new System.Drawing.Size(340, 358);
            this.flow_gc.TabIndex = 14;
            this.flow_gc.Tag = "";
            // 
            // shift_gc
            // 
            gaugeCircularScale8.BorderColor = System.Drawing.Color.Bisque;
            gaugeCircularScale8.MajorTickMarks.Interval = 0.1D;
            gradientFillColor33.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor33.Color1 = System.Drawing.Color.White;
            gradientFillColor33.Color2 = System.Drawing.Color.White;
            gaugeCircularScale8.MajorTickMarks.Layout.FillColor = gradientFillColor33;
            gaugeCircularScale8.MajorTickMarks.Layout.Length = 0.27F;
            gaugeCircularScale8.MaxPin.Name = "MaxPin";
            gaugeCircularScale8.MaxValue = 1D;
            gaugeCircularScale8.MinorTickMarks.Interval = 0.05D;
            gradientFillColor34.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor34.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor34.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugeCircularScale8.MinorTickMarks.Layout.FillColor = gradientFillColor34;
            gaugeCircularScale8.MinorTickMarks.Layout.Length = 0.17F;
            gaugeCircularScale8.MinorTickMarks.Layout.Width = 0.05F;
            gaugeCircularScale8.MinPin.Name = "MinPin";
            gaugeCircularScale8.Name = "Scale1";
            gaugePointer9.AllowUserChange = true;
            gaugePointer9.CapFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer9.CapFillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer9.CapFillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer9.CapWidth = 0.2F;
            gaugePointer9.FillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer9.FillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer9.FillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer9.Length = 0F;
            gaugePointer9.Name = "Pointer1";
            gaugePointer9.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style4;
            gaugePointer9.ScaleOffset = -0.1F;
            gaugePointer9.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer9.Value = 2.5D;
            gaugePointer9.Width = 0.05F;
            gaugeCircularScale8.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer9});
            gaugeSection30.EndValue = 5D;
            gaugeSection30.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection30.FillColor.Color2 = System.Drawing.Color.Transparent;
            gaugeSection30.LabelColor = System.Drawing.Color.White;
            gaugeSection30.MajorTickMarkFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            gaugeSection30.MajorTickMarkFillColor.Color1 = System.Drawing.Color.White;
            gaugeSection30.MajorTickMarkFillColor.Color2 = System.Drawing.Color.White;
            gaugeSection30.Name = "Section1";
            gaugeSection30.StartValue = 0D;
            gaugeCircularScale8.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection30});
            gaugeCircularScale8.StartAngle = 160F;
            gaugeCircularScale8.SweepAngle = 220F;
            this.shift_gc.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale8});
            this.shift_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor35.Color1 = System.Drawing.Color.DimGray;
            gradientFillColor35.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.shift_gc.Frame.BackColor = gradientFillColor35;
            gradientFillColor36.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor36.BorderWidth = 1;
            gradientFillColor36.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor36.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.shift_gc.Frame.FrameColor = gradientFillColor36;
            this.shift_gc.Frame.InnerBevel = 0F;
            this.shift_gc.Frame.OuterBevel = 0.025F;
            this.shift_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            gaugeText15.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText15.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gaugeText15.ForeColor = System.Drawing.Color.White;
            gaugeText15.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText15.Location")));
            gaugeText15.Name = "电流C";
            gaugeText15.Size = new System.Drawing.SizeF(0.5F, 0.6F);
            gaugeText15.Text = "位移";
            numericIndicator9.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator9.BackColor.BorderWidth = 3;
            numericIndicator9.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator9.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator9.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator9.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator9.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator9.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator9.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator9.Location")));
            numericIndicator9.MaxValue = 2D;
            numericIndicator9.Name = "CurrencyC_Indicator";
            numericIndicator9.NumberOfDecimals = 3;
            numericIndicator9.NumberOfDigits = 4;
            numericIndicator9.ShowDecimalPoint = true;
            numericIndicator9.Size = new System.Drawing.SizeF(0.3F, 0.15F);
            numericIndicator9.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator9.Value = 0.562D;
            gaugeText16.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gaugeText16.ForeColor = System.Drawing.Color.White;
            gaugeText16.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText16.Location")));
            gaugeText16.Name = "Text1";
            gaugeText16.Size = new System.Drawing.SizeF(0.3F, 0.2F);
            gaugeText16.Text = "MM";
            gaugeImage8.AutoFit = true;
            gaugeImage8.Image = ((System.Drawing.Image)(resources.GetObject("gaugeImage8.Image")));
            gaugeImage8.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeImage8.Location")));
            gaugeImage8.Name = "Image1";
            gaugeImage8.Size = new System.Drawing.SizeF(0.15F, 0.15F);
            this.shift_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            gaugeText15,
            numericIndicator9,
            gaugeText16,
            gaugeImage8});
            this.shift_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.shift_gc.Location = new System.Drawing.Point(772, 21);
            this.shift_gc.Name = "shift_gc";
            this.shift_gc.Size = new System.Drawing.Size(340, 358);
            this.shift_gc.TabIndex = 15;
            this.shift_gc.Tag = "";
            // 
            // VoltageC_gc
            // 
            gaugeCircularScale9.BorderColor = System.Drawing.Color.Bisque;
            gradientFillColor37.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor37.Color1 = System.Drawing.Color.White;
            gradientFillColor37.Color2 = System.Drawing.Color.White;
            gaugeCircularScale9.MajorTickMarks.Layout.FillColor = gradientFillColor37;
            gaugeCircularScale9.MajorTickMarks.Layout.Length = 0.27F;
            gaugeCircularScale9.MaxPin.Name = "MaxPin";
            gaugeCircularScale9.MaxValue = 40D;
            gaugeCircularScale9.MinorTickMarks.Interval = 1D;
            gradientFillColor38.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor38.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor38.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugeCircularScale9.MinorTickMarks.Layout.FillColor = gradientFillColor38;
            gaugeCircularScale9.MinorTickMarks.Layout.Length = 0.17F;
            gaugeCircularScale9.MinorTickMarks.Layout.Width = 0.05F;
            gaugeCircularScale9.MinPin.Name = "MinPin";
            gaugeCircularScale9.Name = "Scale1";
            gaugePointer10.AllowUserChange = true;
            gaugePointer10.CapFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer10.CapFillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer10.CapFillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer10.CapWidth = 0.2F;
            gaugePointer10.FillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer10.FillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer10.FillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer10.Length = -0.1F;
            gaugePointer10.Name = "Pointer1";
            gaugePointer10.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style4;
            gaugePointer10.ScaleOffset = -0.1F;
            gaugePointer10.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer10.Value = 2.5D;
            gaugePointer10.Width = 0.05F;
            gaugeCircularScale9.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer10});
            gaugeSection31.EndValue = 5D;
            gaugeSection31.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection31.FillColor.Color2 = System.Drawing.Color.Transparent;
            gaugeSection31.LabelColor = System.Drawing.Color.White;
            gaugeSection31.MajorTickMarkFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            gaugeSection31.MajorTickMarkFillColor.Color1 = System.Drawing.Color.White;
            gaugeSection31.MajorTickMarkFillColor.Color2 = System.Drawing.Color.White;
            gaugeSection31.Name = "Section1";
            gaugeSection31.StartValue = 0D;
            gaugeSection32.EndValue = 30D;
            gaugeSection32.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection32.LabelColor = System.Drawing.Color.Lime;
            gaugeSection32.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection32.MajorTickMarkFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.None;
            gaugeSection32.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection32.MinorTickMarkFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.None;
            gaugeSection32.Name = "Normal";
            gaugeSection32.StartValue = 0D;
            gaugeSection33.EndValue = 35D;
            gaugeSection33.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection33.LabelColor = System.Drawing.Color.Gold;
            gaugeSection33.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection33.MajorTickMarkFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.None;
            gaugeSection33.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection33.MinorTickMarkFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.None;
            gaugeSection33.Name = "Warning";
            gaugeSection33.StartValue = 30D;
            gaugeSection34.EndValue = 40D;
            gaugeSection34.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection34.LabelColor = System.Drawing.Color.Red;
            gaugeSection34.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection34.MajorTickMarkFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.None;
            gaugeSection34.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection34.MinorTickMarkFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.None;
            gaugeSection34.Name = "Alarm";
            gaugeSection34.StartValue = 35D;
            gaugeCircularScale9.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection31,
            gaugeSection32,
            gaugeSection33,
            gaugeSection34});
            gaugeCircularScale9.StartAngle = 160F;
            gaugeCircularScale9.SweepAngle = 220F;
            this.VoltageC_gc.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale9});
            this.VoltageC_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor39.Color1 = System.Drawing.Color.DimGray;
            gradientFillColor39.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.VoltageC_gc.Frame.BackColor = gradientFillColor39;
            gradientFillColor40.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor40.BorderWidth = 1;
            gradientFillColor40.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.VoltageC_gc.Frame.FrameColor = gradientFillColor40;
            this.VoltageC_gc.Frame.InnerBevel = 0F;
            this.VoltageC_gc.Frame.OuterBevel = 0.025F;
            this.VoltageC_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            numericIndicator10.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator10.BackColor.BorderWidth = 3;
            numericIndicator10.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator10.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator10.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator10.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator10.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator10.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator10.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator10.Location")));
            numericIndicator10.MaxValue = 500D;
            numericIndicator10.Name = "CurrencyC_Indicator";
            numericIndicator10.NumberOfDecimals = 1;
            numericIndicator10.NumberOfDigits = 4;
            numericIndicator10.ShowDecimalPoint = true;
            numericIndicator10.Size = new System.Drawing.SizeF(0.3F, 0.15F);
            numericIndicator10.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator10.Value = 300D;
            gaugeText17.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText17.Font = new System.Drawing.Font("Perpetua Titling MT", 18F);
            gaugeText17.ForeColor = System.Drawing.Color.White;
            gaugeText17.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText17.Location")));
            gaugeText17.Name = "Text1";
            gaugeText17.Size = new System.Drawing.SizeF(0.3F, 0.2F);
            gaugeText17.Text = "—";
            gaugeText18.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            gaugeText18.ForeColor = System.Drawing.Color.White;
            gaugeText18.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText18.Location")));
            gaugeText18.Name = "Text2";
            gaugeText18.Text = "V";
            stateIndicator8.BackColor.BorderColor = System.Drawing.Color.Black;
            stateIndicator8.BackColor.Color1 = System.Drawing.Color.Lime;
            stateIndicator8.BackColor.Color2 = System.Drawing.Color.Lime;
            stateIndicator8.EmptyString = "";
            stateIndicator8.Location = ((System.Drawing.PointF)(resources.GetObject("stateIndicator8.Location")));
            stateIndicator8.Name = "StateIndicator1";
            stateIndicator8.Size = new System.Drawing.SizeF(0.06F, 0.06F);
            gaugeImage9.AutoFit = true;
            gaugeImage9.Image = ((System.Drawing.Image)(resources.GetObject("gaugeImage9.Image")));
            gaugeImage9.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeImage9.Location")));
            gaugeImage9.Name = "Image1";
            gaugeImage9.Size = new System.Drawing.SizeF(0.15F, 0.15F);
            this.VoltageC_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            numericIndicator10,
            gaugeText17,
            gaugeText18,
            stateIndicator8,
            gaugeImage9});
            this.VoltageC_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.VoltageC_gc.Location = new System.Drawing.Point(12, 418);
            this.VoltageC_gc.Name = "VoltageC_gc";
            this.VoltageC_gc.Size = new System.Drawing.Size(340, 358);
            this.VoltageC_gc.TabIndex = 13;
            this.VoltageC_gc.Tag = "";
            // 
            // CurrentV_gc
            // 
            gaugeCircularScale10.BorderColor = System.Drawing.Color.Bisque;
            gaugeCircularScale10.MajorTickMarks.Interval = 1D;
            gradientFillColor41.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor41.Color1 = System.Drawing.Color.White;
            gradientFillColor41.Color2 = System.Drawing.Color.White;
            gaugeCircularScale10.MajorTickMarks.Layout.FillColor = gradientFillColor41;
            gaugeCircularScale10.MajorTickMarks.Layout.Length = 0.27F;
            gaugeCircularScale10.MaxPin.Name = "MaxPin";
            gaugeCircularScale10.MaxValue = 5D;
            gaugeCircularScale10.MinorTickMarks.Interval = 0.1D;
            gradientFillColor42.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor42.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor42.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugeCircularScale10.MinorTickMarks.Layout.FillColor = gradientFillColor42;
            gaugeCircularScale10.MinorTickMarks.Layout.Length = 0.17F;
            gaugeCircularScale10.MinorTickMarks.Layout.Width = 0.05F;
            gaugeCircularScale10.MinPin.Name = "MinPin";
            gaugeCircularScale10.Name = "Scale1";
            gaugePointer11.AllowUserChange = true;
            gaugePointer11.CapFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer11.CapFillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer11.CapFillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer11.CapWidth = 0.2F;
            gaugePointer11.FillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer11.FillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer11.FillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer11.Length = -0.1F;
            gaugePointer11.Name = "Pointer1";
            gaugePointer11.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style4;
            gaugePointer11.ScaleOffset = -0.1F;
            gaugePointer11.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer11.Value = 2.5D;
            gaugePointer11.Width = 0.05F;
            gaugeCircularScale10.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer11});
            gaugeSection35.EndValue = 5D;
            gaugeSection35.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection35.FillColor.Color2 = System.Drawing.Color.Transparent;
            gaugeSection35.LabelColor = System.Drawing.Color.White;
            gaugeSection35.MajorTickMarkFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            gaugeSection35.MajorTickMarkFillColor.Color1 = System.Drawing.Color.White;
            gaugeSection35.MajorTickMarkFillColor.Color2 = System.Drawing.Color.White;
            gaugeSection35.Name = "Section1";
            gaugeSection35.StartValue = 0D;
            gaugeSection36.EndValue = 4D;
            gaugeSection36.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection36.LabelColor = System.Drawing.Color.Lime;
            gaugeSection36.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection36.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection36.Name = "Normal";
            gaugeSection36.StartValue = 0D;
            gaugeSection37.EndValue = 4.5D;
            gaugeSection37.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection37.LabelColor = System.Drawing.Color.Gold;
            gaugeSection37.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection37.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection37.Name = "Warning";
            gaugeSection37.StartValue = 4D;
            gaugeSection38.EndValue = 5D;
            gaugeSection38.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection38.LabelColor = System.Drawing.Color.Red;
            gaugeSection38.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection38.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection38.Name = "Alarm";
            gaugeSection38.StartValue = 4.5D;
            gaugeCircularScale10.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection35,
            gaugeSection36,
            gaugeSection37,
            gaugeSection38});
            gaugeCircularScale10.StartAngle = 160F;
            gaugeCircularScale10.SweepAngle = 220F;
            this.CurrentV_gc.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale10});
            this.CurrentV_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor43.Color1 = System.Drawing.Color.DimGray;
            gradientFillColor43.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.CurrentV_gc.Frame.BackColor = gradientFillColor43;
            gradientFillColor44.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor44.BorderWidth = 1;
            gradientFillColor44.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor44.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.CurrentV_gc.Frame.FrameColor = gradientFillColor44;
            this.CurrentV_gc.Frame.InnerBevel = 0F;
            this.CurrentV_gc.Frame.OuterBevel = 0.025F;
            this.CurrentV_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            numericIndicator11.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator11.BackColor.BorderWidth = 3;
            numericIndicator11.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator11.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator11.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator11.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator11.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator11.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator11.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator11.Location")));
            numericIndicator11.MaxValue = 6D;
            numericIndicator11.Name = "CurrencyC_Indicator";
            numericIndicator11.NumberOfDigits = 3;
            numericIndicator11.ShowDecimalPoint = true;
            numericIndicator11.Size = new System.Drawing.SizeF(0.3F, 0.15F);
            numericIndicator11.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator11.Value = 3D;
            gaugeText19.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText19.Font = new System.Drawing.Font("Perpetua Titling MT", 18F);
            gaugeText19.ForeColor = System.Drawing.Color.White;
            gaugeText19.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText19.Location")));
            gaugeText19.Name = "Text1";
            gaugeText19.Size = new System.Drawing.SizeF(0.3F, 0.2F);
            gaugeText19.Text = "—";
            gaugeText20.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText20.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            gaugeText20.ForeColor = System.Drawing.Color.White;
            gaugeText20.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText20.Location")));
            gaugeText20.Name = "Text2";
            gaugeText20.Text = "A";
            stateIndicator9.BackColor.BorderColor = System.Drawing.Color.Black;
            stateIndicator9.BackColor.Color1 = System.Drawing.Color.Lime;
            stateIndicator9.BackColor.Color2 = System.Drawing.Color.Lime;
            stateIndicator9.EmptyString = "";
            stateIndicator9.Location = ((System.Drawing.PointF)(resources.GetObject("stateIndicator9.Location")));
            stateIndicator9.Name = "StateIndicator1";
            stateIndicator9.Size = new System.Drawing.SizeF(0.06F, 0.06F);
            gaugeImage10.AutoFit = true;
            gaugeImage10.Image = ((System.Drawing.Image)(resources.GetObject("gaugeImage10.Image")));
            gaugeImage10.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeImage10.Location")));
            gaugeImage10.Name = "Image1";
            gaugeImage10.Size = new System.Drawing.SizeF(0.15F, 0.15F);
            this.CurrentV_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            numericIndicator11,
            gaugeText19,
            gaugeText20,
            stateIndicator9,
            gaugeImage10});
            this.CurrentV_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.CurrentV_gc.Location = new System.Drawing.Point(366, 418);
            this.CurrentV_gc.Name = "CurrentV_gc";
            this.CurrentV_gc.Size = new System.Drawing.Size(340, 358);
            this.CurrentV_gc.TabIndex = 11;
            this.CurrentV_gc.Tag = "";
            // 
            // pressure4_gc
            // 
            gaugeCircularScale11.BorderColor = System.Drawing.Color.Bisque;
            gaugeCircularScale11.MajorTickMarks.Interval = 5D;
            gradientFillColor45.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor45.Color1 = System.Drawing.Color.White;
            gradientFillColor45.Color2 = System.Drawing.Color.White;
            gaugeCircularScale11.MajorTickMarks.Layout.FillColor = gradientFillColor45;
            gaugeCircularScale11.MajorTickMarks.Layout.Length = 0.27F;
            gaugeCircularScale11.MaxPin.Name = "MaxPin";
            gaugeCircularScale11.MaxValue = 20D;
            gaugeCircularScale11.MinorTickMarks.Interval = 1D;
            gradientFillColor46.BorderColor = System.Drawing.Color.DimGray;
            gradientFillColor46.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor46.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugeCircularScale11.MinorTickMarks.Layout.FillColor = gradientFillColor46;
            gaugeCircularScale11.MinorTickMarks.Layout.Length = 0.17F;
            gaugeCircularScale11.MinorTickMarks.Layout.Width = 0.05F;
            gaugeCircularScale11.MinPin.Name = "MinPin";
            gaugeCircularScale11.Name = "Scale1";
            gaugePointer12.AllowUserChange = true;
            gaugePointer12.CapFillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer12.CapFillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer12.CapFillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer12.CapWidth = 0.2F;
            gaugePointer12.FillColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer12.FillColor.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer12.FillColor.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gaugePointer12.Length = 0F;
            gaugePointer12.Name = "Pointer1";
            gaugePointer12.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style4;
            gaugePointer12.ScaleOffset = -0.1F;
            gaugePointer12.Style = DevComponents.Instrumentation.PointerStyle.Needle;
            gaugePointer12.Value = 2.5D;
            gaugePointer12.Width = 0.05F;
            gaugeCircularScale11.Pointers.AddRange(new DevComponents.Instrumentation.GaugePointer[] {
            gaugePointer12});
            gaugeSection39.EndValue = 20D;
            gaugeSection39.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection39.LabelColor = System.Drawing.Color.White;
            gaugeSection39.MajorTickMarkFillColor.Color1 = System.Drawing.Color.White;
            gaugeSection39.Name = "Section1";
            gaugeSection39.StartValue = 0D;
            gaugeSection40.EndValue = 15D;
            gaugeSection40.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection40.LabelColor = System.Drawing.Color.Lime;
            gaugeSection40.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection40.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Lime;
            gaugeSection40.Name = "Normal";
            gaugeSection40.StartValue = 0D;
            gaugeSection41.EndValue = 18D;
            gaugeSection41.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection41.LabelColor = System.Drawing.Color.Gold;
            gaugeSection41.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection41.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Gold;
            gaugeSection41.Name = "Warning";
            gaugeSection41.StartValue = 15D;
            gaugeSection42.EndValue = 20D;
            gaugeSection42.FillColor.Color1 = System.Drawing.Color.Transparent;
            gaugeSection42.LabelColor = System.Drawing.Color.Red;
            gaugeSection42.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection42.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Red;
            gaugeSection42.Name = "Alarm";
            gaugeSection42.StartValue = 18D;
            gaugeCircularScale11.Sections.AddRange(new DevComponents.Instrumentation.GaugeSection[] {
            gaugeSection39,
            gaugeSection40,
            gaugeSection41,
            gaugeSection42});
            gaugeCircularScale11.StartAngle = 180F;
            gaugeCircularScale11.SweepAngle = 220F;
            this.pressure4_gc.CircularScales.AddRange(new DevComponents.Instrumentation.GaugeCircularScale[] {
            gaugeCircularScale11});
            this.pressure4_gc.ForeColor = System.Drawing.Color.White;
            gradientFillColor47.Color1 = System.Drawing.Color.DimGray;
            gradientFillColor47.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle;
            this.pressure4_gc.Frame.BackColor = gradientFillColor47;
            gradientFillColor48.BorderColor = System.Drawing.Color.Gainsboro;
            gradientFillColor48.BorderWidth = 1;
            gradientFillColor48.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            gradientFillColor48.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            this.pressure4_gc.Frame.FrameColor = gradientFillColor48;
            this.pressure4_gc.Frame.InnerBevel = 0F;
            this.pressure4_gc.Frame.OuterBevel = 0.025F;
            this.pressure4_gc.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular;
            numericIndicator12.BackColor.BorderColor = System.Drawing.Color.Gray;
            numericIndicator12.BackColor.BorderWidth = 3;
            numericIndicator12.BackColor.Color1 = System.Drawing.Color.Black;
            numericIndicator12.DecimalColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator12.DecimalDimColor = System.Drawing.Color.Black;
            numericIndicator12.DigitColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(221)))));
            numericIndicator12.DigitDimColor = System.Drawing.Color.Black;
            numericIndicator12.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericIndicator12.Location = ((System.Drawing.PointF)(resources.GetObject("numericIndicator12.Location")));
            numericIndicator12.MaxValue = 20D;
            numericIndicator12.Name = "CurrencyC_Indicator";
            numericIndicator12.NumberOfDigits = 4;
            numericIndicator12.ShowDecimalPoint = true;
            numericIndicator12.Size = new System.Drawing.SizeF(0.35F, 0.15F);
            numericIndicator12.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment;
            numericIndicator12.Value = 15.5D;
            gaugeText21.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            gaugeText21.ForeColor = System.Drawing.Color.White;
            gaugeText21.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText21.Location")));
            gaugeText21.Name = "Text1";
            gaugeText21.Size = new System.Drawing.SizeF(0.3F, 0.2F);
            gaugeText21.Text = "MPA";
            stateIndicator10.BackColor.BorderColor = System.Drawing.Color.Black;
            stateIndicator10.BackColor.Color1 = System.Drawing.Color.Lime;
            stateIndicator10.BackColor.Color2 = System.Drawing.Color.Lime;
            stateIndicator10.EmptyString = "";
            stateIndicator10.Location = ((System.Drawing.PointF)(resources.GetObject("stateIndicator10.Location")));
            stateIndicator10.Name = "StateIndicator1";
            gaugeText22.BackColor.BorderColor = System.Drawing.Color.Black;
            gaugeText22.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold);
            gaugeText22.ForeColor = System.Drawing.Color.White;
            gaugeText22.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeText22.Location")));
            gaugeText22.Name = "Text2";
            gaugeText22.Text = "压力4";
            gaugeImage11.AutoFit = true;
            gaugeImage11.Image = global::Console.Resource1.circle;
            gaugeImage11.Location = ((System.Drawing.PointF)(resources.GetObject("gaugeImage11.Location")));
            gaugeImage11.Name = "Image1";
            gaugeImage11.Size = new System.Drawing.SizeF(0.15F, 0.15F);
            this.pressure4_gc.GaugeItems.AddRange(new DevComponents.Instrumentation.GaugeItem[] {
            numericIndicator12,
            gaugeText21,
            stateIndicator10,
            gaugeText22,
            gaugeImage11});
            this.pressure4_gc.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.pressure4_gc.Location = new System.Drawing.Point(1572, 418);
            this.pressure4_gc.Name = "pressure4_gc";
            this.pressure4_gc.Size = new System.Drawing.Size(340, 358);
            this.pressure4_gc.TabIndex = 16;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2089, 1193);
            this.Controls.Add(this.pressure4_gc);
            this.Controls.Add(this.shift_gc);
            this.Controls.Add(this.flow_gc);
            this.Controls.Add(this.VoltageC_gc);
            this.Controls.Add(this.CurrentV_gc);
            this.Controls.Add(this.CurrentC_gc);
            this.Controls.Add(this.VoltageV_gc);
            this.Controls.Add(this.temperature_gc);
            this.Controls.Add(this.pressure3_gc);
            this.Controls.Add(this.pressure2_gc);
            this.Controls.Add(this.pressure1_gc);
            this.Controls.Add(this.revolution_gc);
            this.DoubleBuffered = true;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.revolution_gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressure1_gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressure2_gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressure3_gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperature_gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageV_gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentC_gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flow_gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shift_gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageC_gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentV_gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressure4_gc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.Instrumentation.GaugeControl revolution_gc;
        private DevComponents.Instrumentation.GaugeControl pressure1_gc;
        private DevComponents.Instrumentation.GaugeControl pressure2_gc;
        private DevComponents.Instrumentation.GaugeControl pressure3_gc;
        private DevComponents.Instrumentation.GaugeControl temperature_gc;
        private DevComponents.Instrumentation.GaugeControl VoltageV_gc;
        private DevComponents.Instrumentation.GaugeControl CurrentC_gc;
        private DevComponents.Instrumentation.GaugeControl flow_gc;
        private DevComponents.Instrumentation.GaugeControl shift_gc;
        private DevComponents.Instrumentation.GaugeControl VoltageC_gc;
        private DevComponents.Instrumentation.GaugeControl CurrentV_gc;
        private DevComponents.Instrumentation.GaugeControl pressure4_gc;
    }
}