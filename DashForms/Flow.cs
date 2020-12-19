using System.Windows.Forms;
using Console.framework;
using DevComponents.Instrumentation;

namespace Console.DashForms
{
    public partial class Flow : Form, ISensorView
    {
        public Flow()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;

            gauge_gc.InitializeGauge();
        }

        public void UpdateView(IDeviceSubject subject)
        {
            gauge_gc.SetGaugeValue(subject.Flow);
        }
    }
}
