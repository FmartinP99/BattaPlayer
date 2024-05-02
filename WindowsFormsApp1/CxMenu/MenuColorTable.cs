using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace CxMenu.CxMenu
{
    public class MenuColorTable : ProfessionalColorTable
    {
        private Color backColor;
        private Color edgeColor;
        private Color borderColor;
        private Color menuItemBorderColor;
        private Color menuItemSelectedColor;

        public MenuColorTable(bool isMainMenu, Color primaryColor)
        {
            if (isMainMenu)
            {
                backColor = Color.FromArgb(170, 170, 170);
                edgeColor = Color.FromArgb(70, 0, 70);
                borderColor = Color.FromArgb(90, 0, 90);
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = Color.FromArgb(150, 50, 50);
            }
            else
            {
                backColor = Color.FromArgb(170, 170, 170);
                edgeColor = Color.FromArgb(70, 0, 70);
                borderColor = Color.FromArgb(90, 0, 90);
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = Color.FromArgb(150, 50, 50);
            }
        }

        //Overrides
        public override Color ToolStripDropDownBackground
        {
            get { return backColor; }
        }

        public override Color MenuBorder
        {
            get { return borderColor; }
        }

        public override Color MenuItemBorder
        {
            get{ return menuItemBorderColor; }
        }

        public override Color MenuItemSelected 
        {
            get { return menuItemSelectedColor; }
        }

        public override Color ImageMarginGradientBegin 
        {
            get { return edgeColor; }
        }


        public override Color ImageMarginGradientMiddle
        {
            get { return edgeColor; }
        }

        public override Color ImageMarginGradientEnd
        {
            get { return edgeColor; }
        }

    }

    
}
