using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.QuestionManagement
{
    class MyGridRadialMenuEditControl : GridRadialMenuEditControl
    {
        public MyGridRadialMenuEditControl()
        {
            SetRadialMenu();
        }

        #region SetRadialMenu

        private void SetRadialMenu()
        {
            Symbol = "\uf040";
            SymbolSize = 13;
            Diameter = 220;

            RadialMenuItem item = new RadialMenuItem();
            item.Text = "删除";
            item.Symbol = "\uf068";
            Items.Add(item);

            item = new RadialMenuItem();
            item.Text = "修改";
            item.Symbol = "\uf044";
            Items.Add(item);

        }

        #endregion

      
    }
}
