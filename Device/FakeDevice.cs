using Console.framework;
using System;
using System.Windows.Forms;

namespace Console.Device
{
    public class FakeDevice : IDeviceSubject
    {
        public double Temperature => Random.NextDouble() * 300;

        public double Viberation => Random.NextDouble() * 200;

        public double[] ViberationTime => null;

        public FFTDataInfo ViberationFFT => new FFTDataInfo();

        public double Noise => Random.NextDouble() * 90 + 30;

        public double[] NoiseRaw => null;

        public FFTDataInfo NoiseFFT => new FFTDataInfo();

        public double Revolution => Random.NextDouble()*5000;

        public double Shift => Random.NextDouble();

        public double Pressure1 => Random.NextDouble() * 20;

        public double Pressure2 => Random.NextDouble() * 20;

        public double Pressure3 => Random.NextDouble() * 20;

        public double Pressure4 => Random.NextDouble() * 20;

        public double Flow => Random.NextDouble() * 5.4 + 0.6;

        public double Currency_C => Random.NextDouble() * 5;

        public double Voltage_C => Random.NextDouble() * 40;

        public double Currency_V => Random.NextDouble() * 5;

        public double Voltage_V => Random.NextDouble() * 450;

        public event Action<IDeviceSubject> DataUpdated;

        public void Start() => UpdateTimer.Start();

        public void Stop() => UpdateTimer.Stop();

        private readonly Timer UpdateTimer = new Timer() { Interval = 100 };
        private Random Random;

        public FakeDevice()
        {
            Random = new Random(DateTime.Now.Millisecond * DateTime.Now.Second);
            UpdateTimer.Tick += UpdateTimer_Tick;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e) => DataUpdated?.Invoke(this);
    }
}
