using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Drawing;

class SVGExporter : Exporter
{
    XmlWriter writer;
    public SVGExporter(XmlWriter xmlwriter)
    {
        writer = xmlwriter;
    }

    private void Finish()
    {
        string strokewidth = "1";
        string fill = "none";
        string stroke = "black";

        writer.WriteAttributeString("stroke-width", strokewidth);
        writer.WriteAttributeString("fill", fill);
        writer.WriteAttributeString("stroke", stroke);
        writer.WriteEndElement();
    }

    public override void drawElipse(int x, int y, int height, int width)
    {
        int rx = width / 2;
        int ry = height / 2;
        int cx = x + rx;
        int cy = y + ry;

        writer.WriteStartElement("ellipse");
        writer.WriteAttributeString("cx", cx.ToString());
        writer.WriteAttributeString("cy", cy.ToString());
        writer.WriteAttributeString("rx", rx.ToString());
        writer.WriteAttributeString("ry", rx.ToString());

        Finish();
    }

    public override void drawLines(List<Point> points)
    {
        writer.WriteStartElement("polyline");

        StringBuilder s = new StringBuilder();

        for (int i = 0; i < points.Count; i++)
        {
            s.Append(points[i].X.ToString() + "," + points[i].Y.ToString() + " ");
        }
        s.Append(points[0].X.ToString() + "," + points[0].Y.ToString() + " ");

        writer.WriteAttributeString("points", s.ToString());

        Finish();
    }

    /*
    XmlWriter xmlwriter;

    private void Finish()
    {
        string strokewidth = "1";
        string fill = "none";
        string stroke = "black";

        xmlwriter.WriteAttributeString("stroke-width", strokewidth);
        xmlwriter.WriteAttributeString("fill", fill);
        xmlwriter.WriteAttributeString("stroke", stroke);
        xmlwriter.WriteEndElement();
    }

    public override void makeCircle(int x, int y, int size)
    {
        int r = size / 2;
        int cx = x + r;
        int cy = y + r;

        xmlwriter.WriteStartElement("circle");
        xmlwriter.WriteAttributeString("cx", cx.ToString());
        xmlwriter.WriteAttributeString("cy", cy.ToString());
        xmlwriter.WriteAttributeString("r",r.ToString());
        Finish();
    }

    public override void makeRectangle(int x, int y, int width, int height)
    {
        xmlwriter.WriteStartElement("polyline");

        StringBuilder s = new StringBuilder();

        s.Append(x.ToString()+","+ y.ToString()+ " ");
        s.Append((x+width).ToString() + "," + y.ToString() + " ");
        s.Append((x+width).ToString() + "," + (y+height).ToString() + " ");
        s.Append(x.ToString() + "," + (y+height).ToString() + " ");
        s.Append(x.ToString() + "," + y.ToString());

        xmlwriter.WriteAttributeString("points", s.ToString());
        Finish();
    }

    public override void makeStar(int x, int y, int width, int height)
    {
        
        xmlwriter.WriteStartElement("polyline");

        StringBuilder s = new StringBuilder();

        Point[] pts = calcStar(x, y, width, height);

        for (int i = 0; i < numPoints; i++)
        {
            s.Append(pts[i].X.ToString() + "," + pts[i].Y.ToString() + " ");
        }
        s.Append(pts[0].X.ToString() + "," + pts[0].Y.ToString() + " ");

        xmlwriter.WriteAttributeString("points", s.ToString());
        Finish();
    }

    internal void setWriter(XmlWriter writer)
    {
        xmlwriter = writer;
    }*/

}

