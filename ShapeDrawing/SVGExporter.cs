using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SVGExporter : Exporter
{
    string svgOutput;

    public override void makeCircle(int x, int y, int size)
    {
        int r = size / 2;
        int cx = x + r;
        int cy = y + r;
        int strokewidth = 1;
        string fill = "none";
        string stroke = "black";
    }

    public override void makeRectangle(int x, int y, int width, int height)
    {
        throw new NotImplementedException();
    }

    public override void makeStar(int x, int y, int width, int height)
    {
        throw new NotImplementedException();
    }
}

