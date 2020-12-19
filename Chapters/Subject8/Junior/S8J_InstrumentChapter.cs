using Console.Contents;
using Console.framework;
using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject8.Junior
{
    class S8J_InstrumentChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            Chapter c = new Chapter("训练器材");

            this.AddTextTitle(c, "1)训练对象");
            this.AddText(c, "链轮传动组件、相关附件");
            this.AddTextTitle(c, "2)所需电气元件、机械部件");
            this.AddText(c, "PLC1个、三相断路器1个、中间继电器2个、变频器1个、按钮3个、三相电机一个、连接导线若干、轴承6个、齿轮4个、链轮2个、链条1条、支撑块13个。");
            List<string> headers = new List<string>() { "分类", "名称", "编号", "行迹位置", "简图" };
            List<Type> headerTypes = new List<Type>() { typeof(GridLabelXEditControl), typeof(GridLabelXEditControl), typeof(GridLabelXEditControl), typeof(GridLabelXEditControl), typeof(GridImageEditControl) };
            List<object[]> contents = new List<object[]>();
            contents.Add(new object[] { "电气元件", "PLC", "DG01", "待定", new Bitmap(@"img\9\t1\1.jpg") });
            contents.Add(new object[] { "电气元件", "断路器", "DG02", "待定", new Bitmap(@"img\8\Junior\t1\2.png") });
            contents.Add(new object[] { "电气元件", "中间继电器", "DG03", "待定", new Bitmap(@"img\9\t1\2.png") });
            contents.Add(new object[] { "电气元件", "变频器", "DG04", "待定", new Bitmap(@"img\8\Junior\t1\4.png") });
            contents.Add(new object[] { "电气元件", "按钮", "DG05", "待定", new Bitmap(@"img\8\Junior\t1\5.png") });
            contents.Add(new object[] { "电气元件", "三相电机", "DG06", "待定", new Bitmap(@"img\8\Junior\t1\6.png") });
            contents.Add(new object[] { "电气元件", "导线", "DG07", "待定", new Bitmap(@"img\9\t1\4.png") });
            contents.Add(new object[] { "机械部件", "轴承（含轴承座）", "DG08", "待定", new Bitmap(@"img\9\t1\11.png") });
            contents.Add(new object[] { "机械部件", "齿轮", "DG09", "待定", new Bitmap(@"img\9\t1\12.png") });
            contents.Add(new object[] { "机械部件", "链轮", "DG010", "待定", new Bitmap(@"img\8\Junior\t1\10.png") });
            contents.Add(new object[] { "机械部件", "链条", "DG011", "待定", new Bitmap(@"img\8\Junior\t1\11.png") });
            contents.Add(new object[] { "机械部件", "支撑块", "DG012", "待定", new Bitmap(@"img\9\t1\13.png") });
            TableContent tab = new TableContent(headers, headerTypes) { Caption = "训练器材-电气元件" };
            tab.Content.AddRange(contents);
            c.Contents.Add(tab);

            this.AddTextTitle(c, "3)电气原理图");
            this.AddPicture(c, new Bitmap(@"img\8\Junior\1.png"));

            this.AddTextTitle(c, "4)PLC梯形图");
            this.AddPicture(c, new Bitmap(@"img\8\Junior\2.png"));

            this.AddTextTitle(c, "5)使用工具");
            this.AddText(c, "电动板手、力矩扳手、无反弹锤、黄油枪。");

            tab = new TableContent(headers, headerTypes) { Caption = "训练器材-工具" };
            contents.Clear();
            contents.Add(new object[] { "工具", "电动扳手", "DG02", "待定", new Bitmap(@"img\9\t2\3.png") });
            contents.Add(new object[] { "工具", "力矩扳手", "DG03", "待定", new Bitmap(@"img\8\Junior\t2\2.png") });
            contents.Add(new object[] { "工具", "无反弹锤", "DG04", "待定", new Bitmap(@"img\9\t2\5.png") });
            contents.Add(new object[] { "工具", "黄油枪", "DG05", "待定", new Bitmap(@"img\9\t2\6.png") });
            tab.Content.AddRange(contents);
            c.Contents.Add(tab);

            c.Contents.Add(new NavigationContent(this, new S8J_AimChapter(), new S8J_StepChapter()));

            return c;
        }
    }
}
