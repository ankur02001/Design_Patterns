using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace PackageBuilderWizard
{
    public struct Prolg
    {
        public String Author { get; set; }
        public String EmailID { get; set; }
    }

    public class XMLReader
    {
        public String PkgName { get; set; }
        public String ClassName { get; set; }
        public String Struct { get; set; }
        public Prolg prlg { get; set; }
        public List<String> reqFiles { get; set; }
        public String buildProc { get; set; }
        public String testStub { get; set; }
        public String packageOps { get; set; }
        public String version { get; set; }

        public XmlDocument doc;

        public XMLReader()
        {
            doc = new XmlDocument();
            doc.Load("../../Test.xml");
            prlg = new Prolg();
            reqFiles = new List<string>();
        }
        public void parseXML()
        {
            try
            {
                XmlNode docElement = doc.DocumentElement;
                XmlNode decNode = docElement.SelectSingleNode("/Package/Declaration");

                foreach (XmlNode node in decNode.ChildNodes)
                {
                    if (node.Name == "Package")
                        this.PkgName = node.InnerText;
                    else if (node.Name == "class")
                        this.ClassName = node.InnerText;
                    else if (node.Name == "struct")
                        this.Struct = node.InnerText;
                }

                XmlNode prologNode = doc.SelectSingleNode("/Package/ManualPage/Prolog");
                Prolg p = new Prolg();
                foreach (XmlNode node in prologNode.ChildNodes)
                {
                    if (node.Name == "Author")
                        p.Author = node.InnerText;
                    else if (node.Name == "Email")
                        p.EmailID = node.InnerText;
                }
                this.prlg = p;
                XmlNode opsNode = doc.SelectSingleNode("/Package/ManualPage/PackageOps");
                foreach (XmlNode x in opsNode.ChildNodes)
                {
                    this.packageOps += x.InnerText + "  ";
                }
                XmlNode maintNode = doc.SelectSingleNode("/Package/MaintenancePage/ReqFiles");
                String reqForBuilding = "";
                foreach (XmlNode x in maintNode.ChildNodes)
                {
                    this.reqFiles.Add(x.InnerText);
                    reqForBuilding += x.InnerText + " ";
                }
                XmlNode BuildNode = doc.SelectSingleNode("/Package/MaintenancePage/BuildProc");
                this.buildProc = BuildNode.InnerText + " " + reqForBuilding;
                XmlNode verNode = doc.SelectSingleNode("/Package/MaintenancePage/Version");
                this.version = verNode.InnerText;
                XmlNode TestNode = doc.SelectSingleNode("/Package/TestStub");
                this.testStub = TestNode.InnerText;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in XML");
                Console.WriteLine(e.Message);
            }
        }
#if (TEST_XMLREADER)
        static void Main(string[] args)
        {
            XMLReader ContextValues = new XMLReader();
            ContextValues.parseXML();
        }
#endif
    }

}
