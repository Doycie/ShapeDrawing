using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


public abstract class Exporter
{
    public abstract void drawLines(List<Point> points);
    public abstract void drawElipse(int x, int y, int height, int width);
}





