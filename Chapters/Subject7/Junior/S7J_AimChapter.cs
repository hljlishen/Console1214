using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject8.Junior
{
    class S7J_AimChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("训练目标");
            this.AddText(c, "1)能够根据实训要求选取型号1、型号2发射车蜗杆传动系统相关元件进行回路的搭建；");
            this.AddText(c, "2)能够熟练使用工具对型号1、型号2发射车蜗轮蜗杆传动系统相关元件进行回路的搭建；");
            this.AddText(c, "3)能够对搭建的系统进行通电调试，确保系统能够实现实训要求；");
            c.Contents.Add(new NavigationContent(this, null, new S7J_InstrumentChapter()));
            return c;
        }
    }
}
