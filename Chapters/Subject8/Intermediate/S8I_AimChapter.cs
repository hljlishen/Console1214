using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject8.Intermediate
{
    class S8I_AimChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("训练目标");
            this.AddText(c, "1)能够通过振动测量仪、噪声测量仪准确查找引起链轮传动系统的噪声、振动过大的原因；");
            this.AddText(c, "2)能够使用工具检测、调整链轮不共面的问题，排除系统故障；");
            this.AddText(c, "3)能够使用工具检测、调整链轮前后轴的平行度，排除系统故障；");
            c.Contents.Add(new NavigationContent(this, null, new S8I_InstrumentChapter()));
            return c;
        }
    }
}
