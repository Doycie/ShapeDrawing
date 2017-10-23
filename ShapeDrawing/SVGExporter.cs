using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Drawing;

class SVGExporter : Exporter
{
    private XmlWriter writer;
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
}

