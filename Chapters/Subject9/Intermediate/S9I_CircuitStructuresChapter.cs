using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject9.Intermediate
{
    class S9I_CircuitStructuresChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("训练回路搭建");
            this.AddText(c, "按照初级实训项目中介绍的训练步骤进行回路的搭建，回路搭建过程中根据不同的需求植入不同的故障元件，故障元件可从相应的元器件抽屉选取。");
            c.Contents.Add(new NavigationContent(this, new S9I_InstrumentChapter(), new S9I_FailModeChapter()));
            return c;
        }
    }
}
