using Console.Contents;
using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject8.Intermediate
{
    class S7I_AimChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("训练目标");
            this.AddText(c, "1)能够通过振动、噪声测量仪器准确查找引起型号1、型号2发射车蜗轮蜗杆传动系统噪声、振动过大的原因；");
            this.AddText(c, "2)能够使用工具对蜗轮/蜗杆啮合间隙进行精确测量，对蜗轮/蜗杆齿磨损程度进行测量；");
            this.AddText(c, "3)能够使用工具，对蜗轮蜗杆啮合间隙进行微调，更换磨损的蜗轮/蜗杆，排除型号1、型号2发射车蜗轮蜗杆传动振动、噪声过大的故障。");
            c.Contents.Add(new NavigationContent(this, null, new S7I_InstrumentChapter()));
            return c;
        }
    }
}
