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
    class S9I_EvaluationChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            Chapter c = new Chapter("考核与评价");
            this.AddText(c, "对学员实操表进行考核评价");
            List<string> headers = new List<string>() { "评价考核标准", "评分" };
            List<Type> types = new List<Type>() { typeof(GridLabelXEditControl), typeof(GridLabelXEditControl) };
            List<object[]> content = new List<object[]>()
            {
                new object[] { "能够熟练使用振动测量仪、噪声测试仪对齿轮传动系统的振动、噪声进行测量", "20" },
                new object[] { "熟练使用测量工具对齿轮副啮合间隙进行测量、对主动齿轮轴和从动齿轮轴在高度和水平面内两个维度的平行度误差进行精确测量", "20" },
                new object[] { "能够精确计算出调整量对齿轮副啮合间隙进行调整、对齿轮轴平行度进行调整，降低振动、噪音水平", "20" },
                new object[] { "能够使用工具对调整完成的齿轮等进行装配紧固，系统装配操作安全规范", "20" },
                new object[] { "能够安全规范对系统进行调试，确保系统恢复正常", "20" },
                new object[] { "合计", "100" }
            };
            TableContent tab = new TableContent(headers, types);
            tab.Content.AddRange(content);
            c.Contents.Add(tab);

            c.Contents.Add(new NavigationContent(this, new S9I_CircuitStructuresChapter(), null));
            return c;
        }
    }
}
