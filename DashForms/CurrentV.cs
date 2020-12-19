using System.Windows.Forms;
using Console.framework;
using DevComponents.Instrumentation;

namespace Console.DashForms
{
    public partial class CurrentV : Form, ISensorView
    {
        public CurrentV()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;

            gauge_gc.InitializeGauge();
        }

        public void UpdateView(IDeviceSubject subject)
        {
            gauge_gc.SetGaugeValue(subject.Currency_V);
        }
    }
}
