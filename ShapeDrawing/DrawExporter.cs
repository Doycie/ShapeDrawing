using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


class DrawExporter : Exporter
{
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

        int numPoints = 5;
        Point[] pts = new Point[numPoints];
        double rx = width / 2;
        double ry = height / 2;
        double cx = x + rx;
        double cy = y + ry;

        double theta = -Math.PI / 2;
        double dtheta = 4 * Math.PI / numPoints;
        int i;
        for (i = 0; i < numPoints; i++)
        {
            pts[i] = new Point(
                Convert.ToInt32(cx + rx * Math.Cos(theta)),
                Convert.ToInt32(cy + ry * Math.Sin(theta)));
            theta += dtheta;
        }

        for (i = 0; i < numPoints; i++)
        {
            canvas.DrawLine(pen, pts[i].X,
                                pts[i].Y,
                                pts[(i + 1) % numPoints].X,
                                pts[(i + 1) % numPoints].Y);
        }
    }
}

