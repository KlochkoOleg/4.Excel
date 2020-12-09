using System.IO;
using Newtonsoft.Json;
using System.Xml;

namespace excel
{
    public class ImprtData
    {
        public Ecuatii[] ImportTxt(string filepath)
        {
            string[] eqsRaw = File.ReadAllLines(filepath);
            Ecuatii[] eqs = new Ecuatii[eqsRaw.Length];
            for (int i = 0; i < eqsRaw.Length; i++)
                eqs[i] = new Ecuatii(eqsRaw[i]);

            return eqs;
        }
        public Ecuatii[] ImportJSON(string filepath)
        {
            string text = File.ReadAllText(filepath);
            Ecuatii[] eqs = JsonConvert.DeserializeObject<Ecuatii[]>(text);
            return eqs;
        }
        public Ecuatii[] ImportXML(string filepath)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filepath);
            XmlElement xRoot = xDoc.DocumentElement;

            Ecuatii[] eqs = new Ecuatii[xRoot.ChildNodes.Count];
            for (int i = 0; i < xRoot.ChildNodes.Count; i++)
                eqs[i] = new Ecuatii(xRoot.ChildNodes[i].InnerText);
            return eqs;
        }
    }
}
