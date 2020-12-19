using Console.Contents;
using Console.framework;
using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject9.Intermediate
{
    class S9I_FaultAnalysisChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("故障原因分析");
            this.AddText(c, "故障定位流程图如下：");
            this.AddPicture(c, new Bitmap(@"img\9\Intermediate\FaultAnalysis.png"));
            this.AddText(c, "1)齿轮传动系统启动后，通过振动测量仪、噪声测试仪测量齿轮传动系统的振动噪声水平，与标准值进行比对，判断噪声是否超标；");
            this.AddText(c, "2)通过塞尺检测主动齿轮与从动齿轮间隙，观察齿轮的外观状况，通过百分表等工具检测主动齿轮和从动齿轮与T型槽基准位置的距离，根据测量情况分析导致齿轮传动异响、颤动的具体原因；");

            List<string> headers = new List<string>() { "故障现象", "故障原因" };
            List<Type> headerTypes = new List<Type>() { typeof(GridLabelXEditControl), typeof(GridLabelXEditControl)};
            List<object[]> contents = new List<object[]>();
            contents.Add(new object[] { "齿轮异响、颤动", "齿轮啮合间隙过大" });
            contents.Add(new object[] { "齿轮异响、颤动", "齿轮断齿" });
            contents.Add(new object[] { "齿轮异响、颤动", "主、从齿轮轴不平行" });
            TableContent tab = new TableContent(headers, headerTypes) { Caption = "故障原因分析" };
            tab.Content.AddRange(contents);
            c.Contents.Add(tab);

            c.Contents.Add(new NavigationContent(this, new S9I_FailModeChapter(), new S9I_RepairChapter()));
            return c;
        }
    }
}
