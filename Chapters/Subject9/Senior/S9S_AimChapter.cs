using Console.Chapters.Subject9.Intermediate;
using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject9.Senior
{
    class S9S_AimChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("训练目标");
            this.AddText(c, "1)能够使用振动传感器、噪声传感器、位移传感器对齿轮传动系统噪声、振动、位移数据进行采集；");
            this.AddText(c, "2)能够操作测量分析软件对齿轮传动系统的振动、噪声水平以及位移数据进行测量分析，并准确查找引起异响、颤动的准确位置；");
            this.AddText(c, "3)能够针对确认的故障位置，使用工具对齿轮啮合间隙、齿轮轴平行度等数据进行测量；");
            this.AddText(c, "4)能够使用工具对齿轮进行润滑、对断齿齿轮或齿轮存在点蚀剥落的齿轮进行更换、对齿轮啮合间隙、齿轮轴平行度进行精确调整，排除异响、颤动的故障。");
            c.Contents.Add(new NavigationContent(this, null, new S9S_InstrumentChapter()));

            return c;
        }
    }
}
