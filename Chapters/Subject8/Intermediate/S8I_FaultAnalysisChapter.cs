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
    class S8I_FaultAnalysisChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("故障原因分析");
            this.AddText(c, "故障定位流程图如下：");
            this.AddPicture(c, new Bitmap(@"img\8\Intermediate\3.png"));
            this.AddText(c, "链轮传动系统启动后，通过振动测量仪、噪声测试仪对链轮传动系统的振动、噪声水平，与标准值进行比对，判断振动、噪声是否超标；使用卡尺测量链条的磨损程度，使用卡尺测量主从链轮之间的轴间距，使用卡尺测量主从链轮与T型安装槽基准位置的距离，判定链轮是否共面； ");
            List<string> headers = new List<string>() { "故障现象", "故障原因" };
            List<Type> headerTypes = new List<Type>() { typeof(GridLabelXEditControl), typeof(GridLabelXEditControl) };
            List<object[]> contents = new List<object[]>();
            contents.Add(new object[] { "链条链轮配合不好、跳齿", "链条磨损" });
            contents.Add(new object[] { "链条抖动", "链条过松，间距过小" });
            contents.Add(new object[] { "链条运动噪声大", "链轮不共面" });
            TableContent tab = new TableContent(headers, headerTypes) { Caption = "故障原因分析" };
            tab.Content.AddRange(contents);
            c.Contents.Add(tab);

            c.Contents.Add(new NavigationContent(this, new S8I_FailModeChapter(), new S8I_RepairChapter()));
            return c;
        }
    }
}
