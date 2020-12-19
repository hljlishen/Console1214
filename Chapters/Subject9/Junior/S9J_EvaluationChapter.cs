﻿using Console.Contents;
using Console.framework;
using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;

namespace Console.Chapters.Subject9.Junior
{
    class S9J_EvaluationChapter : IChapterBuilder
    {
        public Chapter GetChapter()
        {
            Chapter c = new Chapter("考核与评价");
            this.AddText(c, "对学员实操表进行考核评价");

            List<string> headers = new List<string>() { "评价考核标准", "评分" };
            List<Type> types = new List<Type>() { typeof(GridLabelXEditControl), typeof(GridLabelXEditControl) };
            List<object[]> content = new List<object[]>()
            {
                new object[] { "能够根据实训要求选取所需工具、元件、设备等", "25" },
                new object[] { "能够对系统进行装配，使型号1大吊臂机械缸减速传动回路运行", "25" },
                new object[] { "系统装配操作安全规范", "25" },
                new object[] { "能够安全规范对系统进行调试，确保系统正常", "25" },
                new object[] { "合计", "100" }
            };
            TableContent tab = new TableContent(headers, types);
            tab.Content.AddRange(content);
            c.Contents.Add(tab);
            c.Contents.Add(new NavigationContent(this, new S9J_StepChapter(), null));
            return c;
        }
    }
}
