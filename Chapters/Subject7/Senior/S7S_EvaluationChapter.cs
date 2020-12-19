using Console.Contents;
using Console.framework;
using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Chapters.Subject8.Senoir
{
    class S7S_EvaluationChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            Chapter c = new Chapter("考核与评价");
            this.AddText(c, "对学员实操表进行考核评价");
            List<string> headers = new List<string>() { "评价考核标准", "评分" };
            List<Type> types = new List<Type>() { typeof(GridLabelXEditControl), typeof(GridLabelXEditControl) };
            List<object[]> content = new List<object[]>()
            {
                new object[] { "熟练使用振动传感器、噪声传感器对链轮传动系统的噪声、振动数据进行采集", "20" },
                new object[] { "熟练使用测量分析软件对链轮传动系统的噪声、振动进行分析", "20" },
                new object[] { "能够使用工具对传动间距进行微调或安装紧固装置；更换磨损的链轮、调整链轮使其共面、调整前后轴平行度，链条排除系统故障", "20" },
                new object[] { "使用工具对链轮链条进行装配，系统装配操作安全规范", "20" },
                new object[] { "能够安全规范对系统进行调试，确保系统恢复正常", "20" },
                new object[] { "合计", "100" }
            };
            TableContent tab = new TableContent(headers, types);
            tab.Content.AddRange(content);
            c.Contents.Add(tab);
            c.Contents.Add(new NavigationContent(this, new S7S_StepChapter(), null));
            return c;
        }
    }
}
