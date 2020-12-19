using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject9.Senior
{
    class S9S_FailModeChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("故障实现方式");
            this.AddText(c, "将实训对象安装布置在液压+机械实训区，根据实训需求设置以下两种或两种以上故障：");
            this.AddText(c, "1）将系统中的齿轮更换为新齿轮或清除润滑介质使齿轮缺乏润滑；");
            this.AddText(c, "2）将齿轮更换为断齿齿轮；");
            this.AddText(c, "3）调整齿轮副啮合间隙；");
            this.AddText(c, "4）调整主动齿轮与从动齿轮之间轮轴的位置使其不平行；");
            this.AddText(c, "5）将齿轮更换为损坏（点蚀、剥落）的齿轮；");
            c.Contents.Add(new NavigationContent(this, new S9S_CircuitStructuresChapter(), new S9S_StepChapter()));
            return c;
        }
    }
}
