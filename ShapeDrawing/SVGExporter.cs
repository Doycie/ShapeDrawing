using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Drawing;

class SVGExporter : Exporter
{
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
            s.Append(pts[i].X.ToString() + "," + pts[i].Y.ToString() + " ");
        }
        s.Append(pts[0].X.ToString() + "," + pts[0].Y.ToString() + " ");

        xmlwriter.WriteAttributeString("points", s.ToString());
        Finish();
    }

    internal void setWriter(XmlWriter writer)
    {
        xmlwriter = writer;
    }
}

