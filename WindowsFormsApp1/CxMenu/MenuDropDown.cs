using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using CxMenu.CxMenu;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using CxMenu.CxRenderer;

namespace CxMenu.CxDropDown
{
    public class MenuDropDown : ContextMenuStrip
    {
        private bool isMainMenu;
        private int menuItemheight = 25;
        private Color menuItemTextColor = Color.DimGray;
        private Color primaryColor = Color.White;

        private Bitmap menuItemHeaderSize;

        public MenuDropDown(IContainer container) : base(container)
        {

        }
        [Browsable(false)]
        public bool IsMainMenu { get => isMainMenu; set => isMainMenu = value; }
        [Browsable(false)]
        public int MenuItemheight { get => menuItemheight; set => menuItemheight = value; }
        [Browsable(false)]
        public Color MenuItemTextColor { get => menuItemTextColor; set => menuItemTextColor = value; }
        [Browsable(false)]
        public Color PrimaryColor { get => primaryColor; set => primaryColor = value; }


        private void LoadMenuItemAppearance()
        {
            if (isMainMenu)
            {
                menuItemHeaderSize = new Bitmap(25, 45);
                menuItemTextColor = Color.Gainsboro;
            }
            else
            {
                menuItemHeaderSize = new Bitmap(15, MenuItemheight);
            }

        
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.DesignMode == false)
            {
                LoadMenuItemAppearance();
                this.Renderer = new MenuRenderer(isMainMenu, primaryColor, menuItemTextColor);
            }
        }
    }
}
