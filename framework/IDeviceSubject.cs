using System;

namespace Console.framework
{
    public interface IDeviceSubject
    {
        double Temperature { get; }
        double Viberation { get; }
        double[] ViberationTime { get; }
        FFTDataInfo ViberationFFT { get; }
        double Noise { get; }
        double[] NoiseRaw { get; }
        FFTDataInfo NoiseFFT { get; }
        double Revolution { get; }
        double Shift { get; }
        double Pressure1 { get; }
        double Pressure2 { get; }
        double Pressure3 { get; }
        double Pressure4 { get; }
        double Flow { get; }
        double Currency_C { get; }
        double Voltage_C { get; }
        double Currency_V { get; }
        double Voltage_V { get; }
        void Start();
        void Stop();

        event Action<IDeviceSubject> DataUpdated;
    }

    public struct FFTDataInfo
    {
        public double[] FFTData;
        public double XIncrement;

        public FFTDataInfo(double[] fFTData, double xIncrement)
        {
            FFTData = fFTData;
            XIncrement = xIncrement;
        }
    }
}
