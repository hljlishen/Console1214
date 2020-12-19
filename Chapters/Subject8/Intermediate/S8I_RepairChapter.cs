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
    class S8I_RepairChapter : IChapterBuilder
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
                new object[] { "卡尺", "待定", "工具设备", "1", "个" },
                new object[] { "链条", "待定", "摆件", "1", "个"  }
            };
            TableContent tab = new TableContent(headers, types) { Caption = "故障1：链条链轮配合不好、跳齿" };
            tab.Content.AddRange(content);
            c.Contents.Add(tab);

            this.AddTextTitle(c, "故障定位：");
            this.AddText(c, "1、系统通电，启动型号1、型号2筒弹进退链轮传动系统，观察链轮链条配好不好有跳齿现象；\r\n 2、使用卡尺对链条节距进行测量，节距伸长，定位为链条损坏。");
            this.AddTextTitle(c, "拆卸、更换与重装：");
            this.AddText(c, "1、定位到该元件故障后，关闭系统电源；\r\n2、对链条进行拆卸，使用板手把其中一个链轮从T型台上松开；\r\n3、取下损坏的链条，换上新的链条；\r\n4、安装后对链轮重新进行固定；\r\n5、对新安装链轮进行润滑；");
            this.AddTextTitle(c, "验证：");
            this.AddText(c, "系统通电，按下启动按钮SB1或SB2，型号1、型号2筒弹进退链轮传动系统正常工作。");
            this.AddText(c, "");
            this.AddText(c, "");


            tab = new TableContent(headers, types) { Caption = "故障2：链轮抖动" };
            content.Clear();
            content.Add(new object[] { "六方扳手", "待定", "工具设备", "1", "套" });
            content.Add(new object[] { "开口扳手", "待定", "工具设备", "1", "个" });
            content.Add(new object[] { "卡尺", "待定", "工具设备", "1", "个" });
            content.Add(new object[] { "链条", "待定", "摆件", "1", "个" });
            tab.Content.AddRange(content);
            c.Contents.Add(tab);

            this.AddTextTitle(c, "故障定位：");
            this.AddText(c, "1、系统通电，启动型号1、型号2筒弹进退链轮传动系统，观察链条有抖动现象；\r\n2、使用卡尺对链轮间距进行测量，间距过大，定位为链条间距过大。");
            this.AddTextTitle(c, "拆卸、更换与重装：");
            this.AddText(c, "1、定位到该故障后，关闭系统电源；\r\n2、对链条进行拆卸，使用板手把其中一个链轮从T型台上松开；\r\n3、调整链轮间距；\r\n4、调整后对链轮重新进行固定；");
            this.AddTextTitle(c, "验证：");
            this.AddText(c, "系统通电，按下启动按钮SB1或SB2，型号1、型号2筒弹进退链轮传动系统正常工作。");
            this.AddText(c, "");
            this.AddText(c, "");


            tab = new TableContent(headers, types) { Caption = "故障3：链条运动噪声大" };
            content.Clear();
            content.Add(new object[] { "六方扳手", "待定", "工具设备", "1", "套" });
            content.Add(new object[] { "开口扳手", "待定", "工具设备", "1", "个" });
            content.Add(new object[] { "卡尺", "待定", "工具设备", "1", "个" });
            content.Add(new object[] { "链条", "待定", "摆件", "1", "个" });
            tab.Content.AddRange(content);
            c.Contents.Add(tab);

            this.AddTextTitle(c, "故障定位：");
            this.AddText(c, "1、系统通电，启动型号1、型号2筒弹进退链轮传动系统，观察链条配运动噪声过大现象；\r\n2、使用卡尺对主、从链轮与T型槽基准位置进行测量，主、从链轮相对基准位置距离不相同，定位为链轮不共面。");
            this.AddTextTitle(c, "拆卸、更换与重装：");
            this.AddText(c, "1、定位到该元件故障后，关闭系统电源；\r\n2、对链条进行拆卸，使用板手把其中一个链轮从T型台上松开；\r\n3、调整链轮使主、从链轮共面；\r\n4、安装后对链轮重新进行固定；");
            this.AddTextTitle(c, "验证：");
            this.AddText(c, "系统通电，按下启动按钮SB1或SB2，型号1、型号2筒弹进退链轮传动系统正常工作。");
            this.AddText(c, "");
            this.AddText(c, "");

            c.Contents.Add(new NavigationContent(this, new S8I_FaultAnalysisChapter(), new S8I_EvaluationChapter()));
            return c;
        }
    }
}
