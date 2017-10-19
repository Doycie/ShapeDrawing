using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Rectangle : Shape
{

    private int x;
	private int y;
	private int width;
	private int height;

    public Rectangle(int x, int y, int width, int height)
    {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
    }
    
	public override void Export(Exporter exporter)
    {
        List<Point> points = new List<Point>();

        points.Add(new Point(x, y));
        points.Add(new Point(x + width, y));
        points.Add(new Point(x + width, y + height));
        points.Add(new Point(x, y + height));

        exporter.drawLines(points);
    }
}

