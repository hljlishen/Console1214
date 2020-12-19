using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject8.Senoir
{
    class S8S_AimChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("训练目标");
            this.AddText(c, "1)能够使用振动传感器、噪声传感器对链轮传动系统的振动、噪声数据进行采集；");
            this.AddText(c, "2)能够操作测量分析软件对链轮传动系统的振动、噪声水平进行测量分析，并准确查找引起振动、噪声过大的准确位置；");
            this.AddText(c, "3)能够针对确认的故障位置，使用工具对链轮轴中心距进行检测；对链轮齿磨损程度进行检测；链轮是否共面进行检测；对链轮与轮轴基准位置的距离进行检测；");
            this.AddText(c, "4)能够使用工具对链轮轴中心距进行调整，使用工具对磨损的链轮/链条进行更换；使用工具对链轮位置进行调整，使用工具对链轮轴进行调整使主副齿轮平行，排除振动、噪声过大的故障。");
            c.Contents.Add(new NavigationContent(this, null, new S8S_InstrumentChapter()));

            return c;
        }
    }
}
