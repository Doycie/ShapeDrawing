using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


class DrawExporter : Exporter
{
    Graphics canvas;
    Pen pen;

    public DrawExporter(Graphics g)
    {
        canvas = g;
        pen = new Pen(Color.Black);
    }
    public override void drawElipse(int x, int y, int height, int width)
    {
        canvas.DrawEllipse(pen, x, y, height, width);
    }

    public override void drawLines(List<Point> points)
    {
        for (int i = 0; i < points.Count; i++)
        {
            canvas.DrawLine(pen, points[i].X,
                                 points[i].Y,
                                 points[(i + 1) % points.Count].X,
                                 points[(i + 1) % points.Count].Y);
        }
    }
}

