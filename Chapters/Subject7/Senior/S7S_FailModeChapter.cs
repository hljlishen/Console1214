using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject8.Senoir
{
    class S7S_FailModeChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("故障实现方式");
            this.AddText(c, "将实训对象安装布置在强电+机械实训区，根据实训需求设置以下两种或两种以上故障：");
            this.AddText(c, "1)调整主动、从动链轮之间的轴间距；");
            this.AddText(c, "2)将系统中的链轮或链条更换为损坏的链轮或链条；");
            this.AddText(c, "3)调整主动、从动链轮使链轮不在同一平面；");
            this.AddText(c, "4)调整主、从齿轮轴使其不平行；");
            c.Contents.Add(new NavigationContent(this, new S7S_CircuitStructuresChapter(), new S7S_StepChapter()));
            return c;
        }
    }
}
