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
    /*
    Graphics canvas;

    public DrawExporter(Graphics Canvas)
    {
        canvas = Canvas;
    }
    

    public override void makeCircle(int x, int y, int size)
    {
        Pen pen = new Pen(Color.Black);
        canvas.DrawEllipse(pen, x, y, size, size);
    }

    public override void makeRectangle(int x, int y, int width, int height)
    {
        Pen pen = new Pen(Color.Black);
        canvas.DrawLine(pen, x, y, x + width, y);
        canvas.DrawLine(pen, x + width, y, x + width, y + height);
        canvas.DrawLine(pen, x + width, y + height, x, y + height);
        canvas.DrawLine(pen, x, y + height, x, y);
    }

    public override void makeStar(int x, int y, int width, int height)

    {
        Pen pen = new Pen(Color.Black);
        
        
        Point[] pts = calcStar(x, y, width, height);

        for (int i = 0; i < numPoints; i++)
        {
            canvas.DrawLine(pen, pts[i].X,
                                pts[i].Y,
                                pts[(i + 1) % numPoints].X,
                                pts[(i + 1) % numPoints].Y);
        }
    }*/
}

