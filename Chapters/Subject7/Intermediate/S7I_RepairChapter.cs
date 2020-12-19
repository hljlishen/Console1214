using Console.Contents;
using Console.framework;
using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject8.Intermediate
{
    class S7I_RepairChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            var c = new Chapter("诊断与维修");
            this.AddText(c, "根据分析定位的不同的故障现象分别做出以下具体的诊断与维修措施");

            List<string> headers = new List<string>() { "名称", "型号", "分类", "数量", "单位" };
            List<Type> types = new List<Type>() { typeof(GridLabelXEditControl), typeof(GridLabelXEditControl), typeof(GridLabelXEditControl), typeof(GridLabelXEditControl), typeof(GridLabelXEditControl) };
            List<object[]> content = new List<object[]>()
            {
                new object[] { "六方扳手", "待定", "工具设备", "1", "套"  },
                new object[] {  "开口扳手", "待定", "工具设备", "1", "个"  },
                new object[] { "轴承", "待定", "摆件", "1", "个"  }
            };
            TableContent tab = new TableContent(headers, types) { Caption = "故障1：蜗轮蜗杆噪声、振动大" };
            tab.Content.AddRange(content);
            c.Contents.Add(tab);

            this.AddTextTitle(c, "故障定位：");
            this.AddText(c, "1、系统通电，启动型号1、型号2发射车蜗轮蜗杆传动系统，观察蜗轮蜗杆主轴的转动不同心；\r\n 2、拆开主轴轴承座，定位为主轴轴承损坏。");
            this.AddTextTitle(c, "拆卸、更换与重装：");
            this.AddText(c, "定位到该元件故障后，关闭系统电源；\r\n2、对轴承座进行拆卸，观察轴承状态；\r\n3、取下损坏的轴承，换上新的轴承；\r\n4、安装时对轴承以及轴承座等进行清洗；\r\n5、把轴承重新固定到轴承座上，并对轴承进行润滑；");
            this.AddTextTitle(c, "验证：");
            this.AddText(c, "系统通电，按下启动按钮SB1或SB2，型号1、型号2发射车蜗轮蜗杆传动系统正常工作。");
            this.AddText(c, "");
            this.AddText(c, "");


            tab = new TableContent(headers, types) { Caption = "故障2：蜗轮蜗杆噪声、振动大" };
            content.Clear();
            content.Add(new object[] { "六方扳手", "待定", "工具设备", "1", "套" });
            content.Add(new object[] { "开口扳手", "待定", "工具设备", "1", "个" });
            content.Add(new object[] { "塞尺", "待定", "工具设备", "1", "个" });
            tab.Content.AddRange(content);
            c.Contents.Add(tab);

            this.AddTextTitle(c, "故障定位：");
            this.AddText(c, "1、系统通电，启动型号1、型号2发射车蜗轮蜗杆传动系统，对系统进行初步观察；\r\n2、断开电源，使用塞尺检测蜗轮蜗杆啮合间隙；\r\n3、定位为蜗轮蜗杆啮合间隙过大。");
            this.AddTextTitle(c, "拆卸、更换与重装：");
            this.AddText(c, "1、定位到该元件故障后，关闭系统电源；\r\n2、对蜗轮轴承座螺栓进行拆卸；\r\n3、使用塞尺对蜗轮蜗杆啮合间隙进行调节；\r\n4、把轴承座螺栓进行紧固；");
            this.AddTextTitle(c, "验证：");
            this.AddText(c, "系统通电，按下启动按钮SB1或SB2，型号1、型号2发射车蜗轮蜗杆传动系统正常工作。");
            this.AddText(c, "");
            this.AddText(c, "");


            tab = new TableContent(headers, types) { Caption = "故障3：蜗轮蜗杆噪声、振动大" };
            content.Clear();
            content.Add(new object[] { "六方扳手", "待定", "工具设备", "1", "套" });
            content.Add(new object[] { "开口扳手", "待定", "工具设备", "1", "个" });
            tab.Content.AddRange(content);
            c.Contents.Add(tab);

            this.AddTextTitle(c, "故障定位：");
            this.AddText(c, "1、系统通电，启动型号1、型号2发射车蜗轮蜗杆传动系统，对系统进行观察；\r\n2、2、初步分析可能是蜗轮蜗杆装配不垂直造成蜗轮蜗杆振动、噪声大；\r\n3、使用工具对蜗轮蜗杆垂直度进行检测；\r\n4、定位为蜗轮蜗杆装配不垂直；");
            this.AddTextTitle(c, "拆卸、更换与重装：");
            this.AddText(c, "1、定位到该元件故障后，关闭系统电源；\r\n2、选用六方扳手拧松蜗轮蜗杆轴承座螺栓；\r\n3、对蜗轮蜗杆装配轴垂直度进行调整；\r\n4、把蜗轮蜗杆重新固定到轴承座上；");
            this.AddTextTitle(c, "验证：");
            this.AddText(c, "系统通电，按下启动按钮SB1或SB2，型号1、型号2发射车蜗轮蜗杆传动系统正常工作。");
            this.AddText(c, "");
            this.AddText(c, "");

            c.Contents.Add(new NavigationContent(this, new S7I_FaultAnalysisChapter(), new S7I_EvaluationChapter()));
            return c;
        }
    }
}
