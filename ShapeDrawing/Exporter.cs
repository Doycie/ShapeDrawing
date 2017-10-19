using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


public abstract class Exporter
{
    public abstract void makeCircle(int x, int y, int size);
    public abstract void makeRectangle(int x,int y,int width, int height);
    public abstract void makeStar(int x, int y, int width, int height);

    protected Point[] calcStar(int x, int y, int width, int height)
    {
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
        return pts;
    }
    
}





