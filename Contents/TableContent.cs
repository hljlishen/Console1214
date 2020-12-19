using Console.framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Console.Contents
{
    class TableContent : ContentBase
    {
        public TableContent(IEnumerable<string> columnHeaders, IEnumerable<Type> columnTypes)
        {
            ColumnHeaders = columnHeaders;
            ColumnTypes = columnTypes;
        }

        public IEnumerable<string> ColumnHeaders { get; private set; }
        public IEnumerable<Type> ColumnTypes { get; private set; }
        public List<object[]> Content { get; private set; } = new List<object[]>();
        public string Caption { get; set; } = "";
        protected override void DoAddContent(ContentBoard board)
        {
            SuperGridBuilder builder = new SuperGridBuilder();

            builder.Caption = Caption;
            //添加列
            for (int i = 0; i < ColumnHeaders.Count(); i++)
            {
                builder.AddColumn(ColumnHeaders.ElementAt(i), ColumnTypes.ElementAt(i));
            }

            //添加行
            foreach (var c in Content)
            {
                builder.AddRow(c);
            }

            board.AddTable(builder.GetInstance(), Caption);
        }
    }
}
