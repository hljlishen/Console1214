using Console.Contents;
using Console.framework;
using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject9.Intermediate
{
    class S9I_RepairChapter : IChapterBuilder
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
                new object[] { "塞尺", "待定", "工具设备", "1", "个" },
                new object[] {  "", "待定", "摆件", "1", "个"  }
            };
            TableContent tab = new TableContent(headers, types) { Caption = "故障1：齿轮异响、颤动" };
            tab.Content.AddRange(content);
            c.Contents.Add(tab);

            this.AddTextTitle(c, "故障定位：");
            this.AddText(c, "1、系统通电，启动型号1大吊臂机械缸减速传动回路，齿轮异响、颤动；\r\n2、使用塞尺对齿轮啮合间隙进行测量，定位齿轮啮合间隙过大");
            this.AddTextTitle(c,"拆卸、更换与重装：");
            this.AddText(c,"1、定位到该元件故障后，关闭系统电源；\r\n2、把齿轮安装固定在T型台的螺栓松开；\r\n3、使用无反弹锤轻微调整齿轮位置；\r\n4、使用塞尺边调整边测量，调整到啮合间隙符合标准；\r\n把齿轮螺栓重新紧固到T型台上；");
            this.AddTextTitle(c,"验证：");
            this.AddText(c,"系统通电，顺时针或逆时针转动旋钮开关SA2，型号1大吊臂机械缸减速传动正常工作。");
            this.AddText(c,"");
            this.AddText(c,"");


            tab = new TableContent(headers, types) { Caption = "故障2：齿轮异响、颤动" };
            content.Clear();
            content.Add(new object[] { "六方扳手", "待定", "工具设备", "1", "套" });
            content.Add(new object[] { "开口扳手", "待定", "工具设备", "1", "个" });
            content.Add(new object[] { "塞尺", "待定", "工具设备", "1", "个" });
            content.Add(new object[] { "", "待定", "摆件", "1", "个" });
            tab.Content.AddRange(content);
            c.Contents.Add(tab);

            this.AddTextTitle(c, "故障定位：");
            this.AddText(c, "1、系统通电，启动型号1大吊臂机械缸减速传动回路，齿轮异响、颤动；\r\n2、断开电源，定位为齿轮断齿。");
            this.AddTextTitle(c, "拆卸、更换与重装：");
            this.AddText(c, "1、定位到该元件故障后，关闭系统电源；\r\n2、把齿轮安装固定在T型台的螺栓松开；\r\n3、使用内六角松开齿轮紧固螺栓，拆下断齿齿轮；\r\n4、从元器件抽屉选取新的齿轮，安装固定新的齿轮\r\n5、使用塞尺边调整边测量，调整到啮合间隙符合标准；\r\n6、把齿轮螺栓重新紧固到T型台上；\r\n7、对新安装的齿轮进行润滑；");
            this.AddTextTitle(c, "验证：");
            this.AddText(c, "系统通电，顺时针或逆时针转动旋钮开关SA2，型号1大吊臂机械缸减速传动正常工作。");
            this.AddText(c, "");
            this.AddText(c, "");


            tab = new TableContent(headers, types) { Caption = "故障3：齿轮异响、颤动" };
            content.Clear();
            content.Add(new object[] { "六方扳手", "待定", "工具设备", "1", "套" });
            content.Add(new object[] { "开口扳手", "待定", "工具设备", "1", "个" });
            content.Add(new object[] { "塞尺", "待定", "工具设备", "1", "个" });
            content.Add(new object[] { "", "待定", "摆件", "1", "个" });
            tab.Content.AddRange(content);
            c.Contents.Add(tab);

            this.AddTextTitle(c, "故障定位：");
            this.AddText(c, "1、系统通电，启动型号1大吊臂机械缸减速传动回路，齿轮异响、颤动；\r\n2、使用百分表对主从齿轮轴进行平行度检测，定位为齿轮主从齿轮轴不平行。");
            this.AddTextTitle(c, "拆卸、更换与重装：");
            this.AddText(c, "1、定位到该元件故障后，关闭系统电源；\r\n2、把齿轮安装固定在T型台的螺栓松开；\r\n3、对主从齿轮轴平行度进行调整，调至符合标准；\r\n4、把齿轮螺栓重新紧固到T型台上；");
            this.AddTextTitle(c, "验证：");
            this.AddText(c, "系统通电，顺时针或逆时针转动旋钮开关SA2，型号1大吊臂机械缸减速传动正常工作。");
            this.AddText(c, "");
            this.AddText(c, "");

            c.Contents.Add(new NavigationContent(this, new S9I_FaultAnalysisChapter(), new S9I_EvaluationChapter()));
            return c;
        }
    }
}
