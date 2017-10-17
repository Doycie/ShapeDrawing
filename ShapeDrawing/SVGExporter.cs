using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

class SVGExporter : Exporter
{
    XmlWriter xmlwriter;

    public override void makeCircle(int x, int y, int size)
    {
        int r = size / 2;
        int cx = x + r;
        int cy = y + r;
        int strokewidth = 1;
        string fill = "none";
        string stroke = "black";

        xmlwriter.WriteStartElement("circle");
        xmlwriter.WriteAttributeString("cx", cx.ToString());
        xmlwriter.WriteAttributeString("cy", cy.ToString());
        xmlwriter.WriteAttributeString("r",r.ToString());
        xmlwriter.WriteAttributeString("stroke-width", strokewidth.ToString());
        xmlwriter.WriteAttributeString("fill", fill);
        xmlwriter.WriteAttributeString("stroke", stroke);
        xmlwriter.WriteEndElement();
    }

    public override void makeRectangle(int x, int y, int width, int height)
    {
        int strokewidth = 1;
        string fill = "none";
        string stroke = "black";
        xmlwriter.WriteStartElement("polyline");

        StringBuilder s = new StringBuilder();




        xmlwriter.WriteAttributeString("stroke-width", strokewidth.ToString());
        xmlwriter.WriteAttributeString("fill", fill);
        xmlwriter.WriteAttributeString("stroke", stroke);
        xmlwriter.WriteEndElement();
    }

    public override void makeStar(int x, int y, int width, int height)
    {

    }

    internal void setWriter(XmlWriter writer)
    {
        xmlwriter = writer;
    }
}

