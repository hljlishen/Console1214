using Console.Contents;
using Console.framework;
using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject9.Senior
{
    class S9S_InstrumentChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            Chapter c = new Chapter("训练器材");

            this.AddTextTitle(c, "1)训练对象");
            this.AddText(c, "液压马达、齿轮传动组件、管路及附件");
            this.AddTextTitle(c, "2)所需电气元件、液压元件、机械元件");
            this.AddText(c, "PLC1个、中间继电器2个、旋钮开关1个、连接导线若干、电磁换向阀1个、行程开关1个、接近开关1个、液压马达一个、液压软管若干、液压泵站1套、带座轴承6个、齿轮6个、支撑块14个、机械缸1个");
            List<string> headers = new List<string>() { "分类", "名称", "编号", "行迹位置", "简图" };
            List<Type> headerTypes = new List<Type>() { typeof(GridLabelXEditControl), typeof(GridLabelXEditControl), typeof(GridLabelXEditControl), typeof(GridLabelXEditControl), typeof(GridImageEditControl) };
            List<object[]> contents = new List<object[]>();
            contents.Add(new object[] { "电气元件", "PLC", "DG01", "待定", new Bitmap(@"img\9\t1\1.jpg") });
            contents.Add(new object[] { "电气元件", "中间继电器", "DG02", "待定", new Bitmap(@"img\9\t1\2.png") });
            contents.Add(new object[] { "电气元件", "旋钮开关", "DG03", "待定", new Bitmap(@"img\9\t1\3.png") });
            contents.Add(new object[] { "电气元件", "导线", "DG04", "待定", new Bitmap(@"img\9\t1\4.png") });
            contents.Add(new object[] { "液压元件", "电磁换向阀", "DG05", "待定", new Bitmap(@"img\9\t1\5.png") });
            contents.Add(new object[] { "电气元件", "行程开关", "DG06", "待定", new Bitmap(@"img\9\t1\6.png") });
            contents.Add(new object[] { "电气元件", "接近开关", "DG07", "待定", new Bitmap(@"img\9\t1\7.png") });
            contents.Add(new object[] { "液压元件", "液压马达", "DG08", "待定", new Bitmap(@"img\9\t1\8.png") });
            contents.Add(new object[] { "液压元件", "液压软管", "DG09", "待定", new Bitmap(@"img\9\t1\9.png") });
            contents.Add(new object[] { "液压设备", "泵站", "DG10", "待定", new Bitmap(@"img\9\t1\10.png") });
            contents.Add(new object[] { "机械部件", "轴承（含轴承座）", "DG011", "待定", new Bitmap(@"img\9\t1\11.png") });
            contents.Add(new object[] { "机械部件", "齿轮", "DG012", "待定", new Bitmap(@"img\9\t1\12.png") });
            contents.Add(new object[] { "机械部件", "支撑块", "DG013", "待定", new Bitmap(@"img\9\t1\13.png") });
            contents.Add(new object[] { "机械部件", "机械缸", "DG014", "待定", new Bitmap(@"img\9\t1\14.png") });

            TableContent tab = new TableContent(headers, headerTypes) { Caption = "训练器材-电气元件" };
            tab.Content.AddRange(contents);
            c.Contents.Add(tab);

            this.AddTextTitle(c, "3)电气原理图");
            this.AddPicture(c, new Bitmap(@"img\9\1.png"));

            this.AddTextTitle(c, "4)PLC梯形图");
            this.AddPicture(c, new Bitmap(@"img\9\2.png"));

            this.AddTextTitle(c, "5)使用工具");
            this.AddText(c, "六方扳手、无反弹锤、电动板手、塞尺、百分表套件、磁力表座、油脂润滑泵");

            this.AddTextTitle(c, "6)使用仪器");
            this.AddText(c, "振动传感器、噪声传感器、位移传感器");

            this.AddTextTitle(c, "7)软件工具");
            this.AddText(c, "测量分析软件");

            tab = new TableContent(headers, headerTypes) { Caption = "软件工具" };
            contents.Clear();
            contents.Add(new object[] { "工具", "六方板手", "DG01", "待定", new Bitmap(@"img\9\Senior\1.png") });
            contents.Add(new object[] { "工具", "无反弹锤", "DG02", "待定", new Bitmap(@"img\9\Senior\2.png") });
            contents.Add(new object[] { "工具", "电动扳手", "DG03", "待定", new Bitmap(@"img\9\Senior\3.png") });
            contents.Add(new object[] { "工具", "塞尺", "DG04", "待定", new Bitmap(@"img\9\Senior\4.png") });
            contents.Add(new object[] { "工具", "百分表套件", "DG05", "待定", new Bitmap(@"img\9\Senior\5.png") });
            contents.Add(new object[] { "工具", "磁力表座", "DG06", "待定", new Bitmap(@"img\9\Senior\6.png") });
            contents.Add(new object[] { "工具", "油脂润滑泵", "DG07", "待定", new Bitmap(@"img\9\Senior\7.png") });
            contents.Add(new object[] { "软件", "振动传感器", "DG08", "待定", new Bitmap(@"img\9\Senior\8.png") });
            contents.Add(new object[] { "软件", "噪声传感器", "DG09", "待定", new Bitmap(@"img\9\Senior\9.png") });
            contents.Add(new object[] { "软件", "位移传感器", "DG10", "待定", new Bitmap(@"img\9\Senior\10.png") });
            contents.Add(new object[] { "软件", "测量分析软件", "DG11", "待定", new Bitmap(@"img\9\Senior\11.png") });
            tab.Content.AddRange(contents);
            c.Contents.Add(tab);

            c.Contents.Add(new NavigationContent(this, new S9S_AimChapter(), new S9S_CircuitStructuresChapter()));
            return c;
        }
    }
}
