using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject9.Intermediate
{
    class S9I_AimChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("训练目标");
            this.AddText(c, "1)能够通过振动测量仪、噪声测试仪准确查找引起齿轮传动系统异响、颤动的原因；");
            this.AddText(c, "2)能够使用工具对齿轮副啮合间隙进行精确测量，对齿轮同轴度进行测量，确定系统故障的具体原因；");
            this.AddText(c, "3)能够使用工具对齿轮副啮合间隙进行调整、对主动齿轮从动齿轮平行度进行调整，排除系统故障");
            c.Contents.Add(new NavigationContent(this, null, new S9I_InstrumentChapter()));

            return c;
        }
    }
}
