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
        exporter.makeStar(x, y, width,height);
    }
}


