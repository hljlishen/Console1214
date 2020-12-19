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
    class S8I_EvaluationChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            Chapter c = new Chapter("考核与评价");
            this.AddText(c, "对学员实操表进行考核评价");
            List<string> headers = new List<string>() { "评价考核标准", "评分" };
            List<Type> types = new List<Type>() { typeof(GridLabelXEditControl), typeof(GridLabelXEditControl) };
            List<object[]> content = new List<object[]>()
            {
                new object[] { "能够熟练使用振动测量仪、噪声测试仪对链轮传动系统的振动、噪声进行测量", "20" },
                new object[] { "能够使用测量工具对链条是否磨损、链轮间隙大小、链轮是否共面进行诊断", "20" },
                new object[] { "能够使用工具对故障元件进行更换，故障问题进行调整排除系统故障", "20" },
                new object[] { "使用工具对链轮链条进行装配，系统装配操作安全规范", "20" },
                new object[] { "能够安全规范对系统进行调试，确保系统恢复正常", "20" },
                new object[] { "合计", "100" }
            };
            TableContent tab = new TableContent(headers, types);
            tab.Content.AddRange(content);
            c.Contents.Add(tab);

            c.Contents.Add(new NavigationContent(this, new S8I_RepairChapter(), null));
            return c;
        }
    }
}
