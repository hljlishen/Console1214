using Console.Contents;
using Console.framework;

namespace Console.Chapters.Subject8.Senoir
{
    class S7S_AimChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("训练目标");
            this.AddText(c, "1)能够使用振动传感器、噪声传感器、温度传感器对蜗轮/蜗杆传动系统噪声、振动、温度数据进行采集；");
            this.AddText(c, "2)能够操作测量分析软件对蜗轮/蜗杆传动系统的振动、噪声水平以及温度进行测量分析，并准确查找引起振动、噪声过大的准确位置；");
            this.AddText(c, "3)能够针对确认的故障位置，使用工具以及观察诊断判断具体的故障器件及原因； ");
            this.AddText(c, "4)能够使用工具对蜗轮蜗杆传动系统中轴承座进行紧固、更换损坏轴承、更换磨损的蜗轮蜗杆、调整蜗轮蜗杆的啮合间隙、调整蜗轮蜗杆的垂直度；");
            c.Contents.Add(new NavigationContent(this, null, new S7S_InstrumentChapter()));

            return c;
        }
    }
}
