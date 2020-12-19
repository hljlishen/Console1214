using System.Windows.Forms;
using Console.framework;
using DevComponents.Instrumentation;

namespace Console.DashForms
{
    public partial class VoltageV : Form, ISensorView
    {
        public VoltageV()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;

            gauge_gc.InitializeGauge();
        }

        public void UpdateView(IDeviceSubject subject)
        {
            gauge_gc.SetGaugeValue(subject.Voltage_V);
        }
    }
}
