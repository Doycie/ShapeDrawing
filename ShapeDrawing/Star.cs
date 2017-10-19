using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Star : Shape
{

	private int x;
	private int y;
	private int width;
	private int height;
    

	public Star (int x, int y, int width, int height)
	{
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
        
    }

	public override void Export (Exporter exporter)
	{
        List<Point> points = new List<Point>();

        int numPoints = 5;

        double rx = width / 2;
        double ry = height / 2;
        double cx = x + rx;
        double cy = y + ry;

        double theta = -Math.PI / 2;
        double dtheta = 4 * Math.PI / numPoints;
        int i;
        for (i = 0; i < numPoints; i++)
        {
            points.Add(new Point(
                Convert.ToInt32(cx + rx * Math.Cos(theta)),
                Convert.ToInt32(cy + ry * Math.Sin(theta))));
            theta += dtheta;
        }

        exporter.drawLines(points);
    }
}


