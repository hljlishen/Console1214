using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject8.Intermediate
{
    class S7I_FailModeChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("故障实现方式");
            this.AddText(c, "将实训对象安装布置在强电+机械实训区，根据实训需求设置以下其中一种故障：");
            this.AddText(c, "1)将蜗轮蜗杆的主轴轴承更换为损坏的轴承；");
            this.AddText(c, "2)调整蜗轮蜗杆的啮合间隙；");
            this.AddText(c, "3)调整蜗轮蜗杆的装配角度，使其装配不垂直");
            c.Contents.Add(new NavigationContent(this, new S7I_CircuitStructeursChapter(), new S7I_FaultAnalysisChapter()));
            return c;
        }
    }
}
