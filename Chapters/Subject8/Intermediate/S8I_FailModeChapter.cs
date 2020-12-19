using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject8.Intermediate
{
    class S8I_FailModeChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("故障实现方式");
            this.AddText(c, "将实训对象安装布置在强电+机械实训区，根据实训需求设置以下其中一种故障：");
            this.AddText(c, "1)将系统中的链条更换为损坏的链条");
            this.AddText(c, "2)调整主动、从动链轮之间的轴间距使其间距过大（过小）");
            this.AddText(c, "3)调整主动、从动链轮使链轮不在同一平面；");
            c.Contents.Add(new NavigationContent(this, new S8I_CircuitStructeursChapter(), new S8I_FaultAnalysisChapter()));
            return c;
        }
    }
}
