using System.Windows.Forms;
using Console.framework;
using DevComponents.Instrumentation;

namespace Console.DashForms
{
    public partial class Pressure2 : Form, ISensorView
    {
        public Pressure2()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;

            gauge_gc.InitializeGauge();
        }

        public void UpdateView(IDeviceSubject subject)
        {
            gauge_gc.SetGaugeValue(subject.Pressure2);
        }
    }
}
