using Console.Contents;
using Console.framework;
using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject8.Intermediate
{
    class S7I_FaultAnalysisChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("故障原因分析");
            this.AddText(c, "故障定位流程图如下：");
            this.AddPicture(c, new Bitmap(@"img\7\Intermediate\1.png"));
            this.AddText(c, "型号1、型号2发射车蜗轮蜗杆传动系统启动后，通过振动测量仪、噪声测试仪测量蜗轮蜗杆传动系统的噪声、振动水平，与标准值进行比对，判断噪声是否超标，结合实际观察的蜗轮蜗杆运行状态，分析蜗轮蜗杆造成振动、噪声过大的原因； ");
            List<string> headers = new List<string>() { "故障现象", "故障原因" };
            List<Type> headerTypes = new List<Type>() { typeof(GridLabelXEditControl), typeof(GridLabelXEditControl) };
            List<object[]> contents = new List<object[]>();
            contents.Add(new object[] { "蜗轮蜗杆噪声、振动大", "蜗轮蜗杆主轴轴承损坏" });
            contents.Add(new object[] { "蜗轮蜗杆噪声、振动大","蜗轮蜗杆啮合间隙过大" });
            contents.Add(new object[] { "蜗轮蜗杆噪声、振动大", "蜗轮蜗杆装配不垂直" });
            TableContent tab = new TableContent(headers, headerTypes) { Caption = "故障原因分析" };
            tab.Content.AddRange(contents);
            c.Contents.Add(tab);

            c.Contents.Add(new NavigationContent(this, new S7I_FailModeChapter(), new S7I_RepairChapter()));
            return c;
        }
    }
}
