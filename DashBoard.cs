using Console.framework;
using DevComponents.Instrumentation;
using System.Windows.Forms;

namespace Console
{
    public partial class DashBoard : Form, ISensorView
    {
        private IDeviceSubject subject;
        public DashBoard(IDeviceSubject subject)
        {
            InitializeComponent();
            VoltageC_gc.InitializeGauge();
            VoltageV_gc.InitializeGauge();
            CurrentC_gc.InitializeGauge();
            CurrentV_gc.InitializeGauge();
            flow_gc.InitializeGauge();
            shift_gc.InitializeGauge();


            pressure1_gc.InitializeGauge();
            pressure2_gc.InitializeGauge();
            pressure3_gc.InitializeGauge();
            pressure4_gc.InitializeGauge();
            temperature_gc.InitializeGauge();
            revolution_gc.InitializeGauge();
            this.subject = subject;
            subject.Start();
            subject.DataUpdated += UpdateView;
        }

        public void UpdateView(IDeviceSubject subject)
        {
            VoltageC_gc.SetGaugeValue(subject.Voltage_C);
            VoltageV_gc.SetGaugeValue(subject.Voltage_V);
            CurrentC_gc.SetGaugeValue(subject.Currency_C);
            CurrentV_gc.SetGaugeValue(subject.Currency_V);
            shift_gc.SetGaugeValue(subject.Shift);
            flow_gc.SetGaugeValue(subject.Flow);
            revolution_gc.SetGaugeValue(subject.Revolution);
            pressure1_gc.SetGaugeValue(subject.Pressure1);
            pressure2_gc.SetGaugeValue(subject.Pressure2);
            pressure3_gc.SetGaugeValue(subject.Pressure3);
            pressure4_gc.SetGaugeValue(subject.Pressure4);
            temperature_gc.SetGaugeValue(subject.Temperature);
        }
    }
}
