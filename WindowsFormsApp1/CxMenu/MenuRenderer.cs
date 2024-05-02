﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using CxMenu.CxMenu;
using System.Drawing.Drawing2D;

namespace CxMenu.CxRenderer
{
    public class MenuRenderer : ToolStripProfessionalRenderer
    {
        private Color primaryColor;
        private Color textColor;
        private int arrowThickness;


        public MenuRenderer(bool isMainMenu, Color primaryColor, Color textColor) :base(new MenuColorTable(isMainMenu, primaryColor))
        {
            this.primaryColor = primaryColor;
            this.textColor = textColor;
            arrowThickness = isMainMenu ? 3 : 2;
        }

        //Overrides
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.White : primaryColor;
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            base.OnRenderArrow(e);
            var graph = e.Graphics;
            var arroweSize = new Size(5, 12);
            var arrowColor = e.Item.Selected ? Color.White : primaryColor;
            var rect = new Rectangle(e.ArrowRectangle.Location.X, 
                (e.ArrowRectangle.Height - arroweSize.Height) / 2,
                arroweSize.Width, arroweSize.Height);
            using GraphicsPath path = new GraphicsPath();
            using Pen pen = new Pen(arrowColor, arrowThickness);
            {
                //drawing
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                path.AddLine( rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height );
                graph.DrawPath(pen, path);
            }
            
        }
    }
}
