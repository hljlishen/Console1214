using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using System;

namespace Console
{
    public class SuperGridBuilder
    {
        private SuperGridControl Instance { get; set; } = null;
        private int currentIndex = 1;
        public string Caption { get => Instance.PrimaryGrid.Caption.Text; set => Instance.PrimaryGrid.Caption = new GridCaption(value); }

        public SuperGridBuilder()
        {
            Instance = new SuperGridControl();
            Instance.BackColor = System.Drawing.Color.White;
            Instance.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            Instance.ForeColor = System.Drawing.Color.Black;
            Instance.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            Instance.Location = new System.Drawing.Point(124, 109);
            Instance.Name = "superGridControl1";
            Instance.Size = new System.Drawing.Size(798, 711);
            Instance.TabIndex = 0;
            Instance.Text = "superGridControl1";
            Instance.PrimaryGrid.ColumnAutoSizeMode = ColumnAutoSizeMode.AllCells | ColumnAutoSizeMode.Fill;
            Instance.PrimaryGrid.DefaultRowHeight = 0;
            //Instance.PrimaryGrid.ReadOnly = true;
            Instance.PrimaryGrid.ShowRowHeaders = true;
            Instance.PrimaryGrid.ColumnHeader.AllowSelection = false;
            Instance.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            Instance.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Font = new System.Drawing.Font("宋体", 16);
            Instance.PrimaryGrid.SelectionGranularity = SelectionGranularity.Row;
            Instance.PrimaryGrid.ShowWhitespaceRowLines = false;
            Instance.PrimaryGrid.ShowRowGridIndex = false;

            Instance.BeginUpdate();
            AddColumn("序号", typeof(GridLabelXEditControl));
        }

        public void AddTextColumn(string headerText) => AddColumn(headerText, typeof(GridLabelXEditControl));

        public void AddColumn(string headerText, Type editorType)
        {
            var column = new GridColumn();
            column.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            column.EditorType = editorType;

            column.HeaderText = headerText;
            Instance.PrimaryGrid.Columns.Add(column);
        }

        public void AddImageColumn(string headerText) => AddColumn(headerText, typeof(GridImageEditControl));

        public void AddRow(object[] values)
        {
            var row = Instance.PrimaryGrid.NewRow();
            Instance.PrimaryGrid.AllowRowResize = true;
            row[0].Value = currentIndex++.ToString();

            int columnCount = Instance.PrimaryGrid.Columns.Count;
            int count = Math.Min(values.Length, columnCount);

            Instance.BeginUpdate();
            for(int i = 0; i < count; i++)
            {
                row[i+1].Value = values[i];
                if( row[i + 1].EditControl is GridImageEditControl r)
                {
                    r.ImageSizeMode = ImageSizeMode.Zoom;
                }
            }

            if(count < columnCount)
            {
                for(int i = count; i < columnCount; i++)
                {
                    row[i].Value = values[values.Length - 1];
                    if (row[i].EditControl is GridImageEditControl r)
                    {
                        r.ImageSizeMode = ImageSizeMode.Zoom;
                    }
                    if (row[i].EditControl is GridLabelXEditControl r1)
                    {
                        (r1.Controls[0] as LabelX).TextAlignment = System.Drawing.StringAlignment.Near;
                    }
                }
            }
            Instance.PrimaryGrid.Rows.Add(row);
            Instance.EndUpdate();
        }

        public SuperGridControl GetInstance()
        {
            Instance.EndUpdate();
            var height = 0;
            foreach (var col in Instance.PrimaryGrid.Rows)
            {
                height += (col as GridRow).GetMaximumRowHeight();
            }
            height += Instance.PrimaryGrid.ColumnHeader.Size.Height;
            height += Instance.PrimaryGrid.Caption.RowHeight;

            Instance.Height = height + 40;

            //var width = 0;
            //foreach (var col in Instance.PrimaryGrid.Columns)
            //{
            //    width += (col as GridColumn).GetMaximumCellSize(RowScope.AllRows, true).Width;
            //}
            //Instance.Width = width + 38;

            return Instance;
        }

        public bool EnableMerge { get => Instance.PrimaryGrid.EnableCellMerging; set => Instance.PrimaryGrid.EnableCellMerging = value; }
        public CellMergeMode CellMergeMode { get => Instance.PrimaryGrid.CellMergeMode; set => Instance.PrimaryGrid.CellMergeMode = value; }
        public CellMergeOrder CellMergeOrder { get => Instance.PrimaryGrid.CellMergeOrder; set => Instance.PrimaryGrid.CellMergeOrder = value; }
    }
}
