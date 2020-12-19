using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject9.Intermediate
{
    class S9I_FailModeChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("故障实现方式");
            this.AddText(c, "将实训对象安装布置在液压+机械实训区，根据实训需求设置以下其中一种故障：");
            this.AddText(c, "1)将齿轮更换为断齿齿轮；");
            this.AddText(c, "2)调整齿轮副啮合间隙；");
            this.AddText(c, "3)调整主动齿轮与从动齿轮之间轮轴的位置使其不平行；");
            c.Contents.Add(new NavigationContent(this, new S9I_CircuitStructuresChapter(), new S9I_FaultAnalysisChapter()));
            return c;
        }
    }
}
