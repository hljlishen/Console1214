using Console.framework;
using JYUSB61903;
using SeeSharpTools.JY.ArrayUtility;
using System;
using System.Linq;
using System.Windows.Forms;
using SeeSharpTools.JY.DSP.Fundamental;

namespace Console.Device
{
    public class Usb1903 : IDeviceSubject, IDisposable
    {
        public Usb1903()
        {
            card1Task = new JYUSB61903AITask(0);
            card2Task = new JYUSB61903AITask(1);

            card1Task.AddChannel(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 });
            card2Task.AddChannel(new int[] { 0, 1, 2, 3, 4, 5 });
            InitAiTask(card1Task);
            InitAiTask(card2Task);

            refreshTimer.Interval = 100;
            refreshTimer.Tick += RefreshTimer_Tick;
        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            ReadCard1();
            ReadCard2();

            DataUpdated?.Invoke(this);
        }

        private void ReadCard1()             //读取板卡1
        {
            if (card1Task.AvailableSamples >= SampleRate / 2)
            {
                double[,] readValue = new double[SampleRate / 2, 8];
                double[] chBuff = new double[SampleRate / 2];

                card1Task.ReadData(ref readValue, SampleRate / 2, -1);
                //温度
                ArrayManipulation.GetArraySubset(readValue, 0, ref chBuff, ArrayManipulation.IndexType.column);
                Temperature = chBuff.Average() * 18.75 - 75;

                //震动
                ArrayManipulation.GetArraySubset(readValue, 1, ref chBuff, ArrayManipulation.IndexType.column);
                ArrayCalculation.MultiplyScale(ref chBuff, 12.5);
                ArrayCalculation.SubtractOffset(ref chBuff, 50);
                Viberation = chBuff.Average();
                ViberationTime = chBuff.Clone() as double[];

                //震动FFT
                double[] FFT1 = new double[SampleRate / 4];
                Spectrum.PowerSpectrum(chBuff, SampleRate, ref FFT1, out var df1);
                ViberationFFT = new FFTDataInfo(FFT1, df1);

                //噪声
                ArrayManipulation.GetArraySubset(readValue, 2, ref chBuff, ArrayManipulation.IndexType.column);
                ArrayCalculation.MultiplyScale(ref chBuff, 5.625);
                ArrayCalculation.SubtractOffset(ref chBuff, 7.5);
                Noise = chBuff.Average();
                NoiseRaw = chBuff.Clone() as double[];

                //噪声FFT
                double[] FFT2 = new double[SampleRate / 4];
                Spectrum.PowerSpectrum(chBuff, SampleRate, ref FFT2, out var df2);
                NoiseFFT = new FFTDataInfo(FFT2, df2);

                //转速
                ArrayManipulation.GetArraySubset(readValue, 3, ref chBuff, ArrayManipulation.IndexType.column);
                Revolution = chBuff.Average() * 312.5 - 1250;

                //直流电压
                ArrayManipulation.GetArraySubset(readValue, 4, ref chBuff, ArrayManipulation.IndexType.column);
                Voltage_C = chBuff.Average() * 2.5 - 10;

                //直流电流
                ArrayManipulation.GetArraySubset(readValue, 5, ref chBuff, ArrayManipulation.IndexType.column);
                Currency_C = chBuff.Average() * 0.3125 - 1.25;

                //交流电压
                ArrayManipulation.GetArraySubset(readValue, 6, ref chBuff, ArrayManipulation.IndexType.column);
                Voltage_V = chBuff.Average() * 28.125 - 112.5;

                //转速
                ArrayManipulation.GetArraySubset(readValue, 7, ref chBuff, ArrayManipulation.IndexType.column);
                Currency_V = chBuff.Average() * 0.3125 - 1.25;
            }
        }
        private void ReadCard2()            //读取板卡2
        {
            if (card2Task.AvailableSamples >= SampleRate / 2)
            {
                double[,] readValue = new double[SampleRate / 2, 8];
                double[] chBuff = new double[SampleRate / 2];
                card2Task.ReadData(ref readValue, SampleRate / 2, -1);

                //压力1
                ArrayManipulation.GetArraySubset(readValue, 0, ref chBuff, ArrayManipulation.IndexType.column);
                Pressure1 = chBuff.Average() * 0.3375 - 0.75;

                //压力2
                ArrayManipulation.GetArraySubset(readValue, 1, ref chBuff, ArrayManipulation.IndexType.column);
                Pressure2 = chBuff.Average() * 0.3375 - 0.75;

                //压力3
                ArrayManipulation.GetArraySubset(readValue, 2, ref chBuff, ArrayManipulation.IndexType.column);
                Pressure3 = chBuff.Average() * 0.3375 - 0.75;

                //压力4
                ArrayManipulation.GetArraySubset(readValue, 3, ref chBuff, ArrayManipulation.IndexType.column);
                Pressure4 = chBuff.Average() * 0.3375 - 0.75;

                //流量
                ArrayManipulation.GetArraySubset(readValue, 4, ref chBuff, ArrayManipulation.IndexType.column);
                Flow = chBuff.Average() * 1.25 - 5;

                //位移
                ArrayManipulation.GetArraySubset(readValue, 5, ref chBuff, ArrayManipulation.IndexType.column);
                Shift = chBuff.Average() * 0.0625 - 0.25;
            }
        }

        private void InitAiTask(JYUSB61903AITask aitask)
        {
            aitask.Mode = AIMode.Continuous;
            aitask.SampleRate = SampleRate;
            aitask.Start();
        }

        #region IDeviceSubject
        public double Temperature { get; private set; }
        public double Viberation { get; private set; }
        public double[] ViberationTime { get; private set; }
        public FFTDataInfo ViberationFFT { get; private set; }
        public double Noise { get; private set; }
        public double[] NoiseRaw { get; private set; }
        public FFTDataInfo NoiseFFT { get; private set; }
        public double Revolution { get; private set; }
        public double Shift { get; private set; }
        public double Pressure1 { get; private set; }
        public double Pressure2 { get; private set; }
        public double Pressure3 { get; private set; }
        public double Pressure4 { get; private set; }
        public double Flow { get; private set; }
        public double Currency_C { get; private set; }
        public double Voltage_C { get; private set; }
        public double Currency_V { get; private set; }
        public double Voltage_V { get; private set; }

        public event Action<IDeviceSubject> DataUpdated;
        public void Start() => refreshTimer.Start();
        public void Stop() => refreshTimer.Stop();
        #endregion

        public void Dispose()
        {
            card1Task?.Stop();
            card1Task?.Channels.Clear();
            card2Task?.Stop();
            card2Task?.Channels.Clear();
            refreshTimer?.Dispose();
        }

        private readonly JYUSB61903AITask card1Task;
        private readonly JYUSB61903AITask card2Task;
        private readonly int SampleRate = 1000;
        private readonly Timer refreshTimer = new Timer();
    }
}
