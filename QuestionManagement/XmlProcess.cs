using Console.framework;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Windows.Forms;

namespace Console.QuestionManagement
{
    interface XmlProcess
    {
        bool CreatNewXml(string fileName,List<Inscribe> inscribes);
        bool CreatNewElement(string fileName, List<Inscribe> inscribes);
        bool DeleteElement(string fileName,int ElementId);
        bool QuestionContains(string fileName,string title);
        List<Inscribe> GetReadom(List<Inscribe> inscribes, int count);
        object[] Project_name();
        List<Inscribe> AllData(string fileName);
    }

    class XmlInscribe : XmlProcess
    {
        XmlDocument xmlDoc;
        XmlNode node;
        XmlElement xmlEle;
        Timer time = new Timer();
        public bool CreatNewElement(string fileName, List<Inscribe> inscribes)
        {
            try
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(fileName);
                var xmlElement = xmlDoc.DocumentElement;
                foreach (var inscribe in inscribes)
                {
                    node = xmlDoc.CreateNode("element", "选择题", "");
                    XmlElement xmlElement1 = (XmlElement)node;
                    xmlElement1.SetAttribute("id", $"{SelectLastElementId() + 1}");
                    XmlElement xmlText = xmlDoc.CreateElement("Text");
                    xmlText.InnerText = inscribe.Text;
                    node.AppendChild(xmlText);
                    foreach (var candidates in inscribe.Candidates)
                    {
                        XmlElement xmlCandidates = xmlDoc.CreateElement("Candidates");
                        xmlCandidates.InnerText = candidates;
                        xmlElement.AppendChild(xmlCandidates);
                        node.AppendChild(xmlCandidates);
                    }
                    foreach (var correctAnwsers in inscribe.CorrectAnwsers)
                    {
                        XmlElement xmlCorrectAnwsers = xmlDoc.CreateElement("CorrectAnwsers");
                        xmlCorrectAnwsers.InnerText = correctAnwsers;
                        xmlElement.AppendChild(xmlCorrectAnwsers);
                        node.AppendChild(xmlCorrectAnwsers);
                    }
                    xmlElement.AppendChild(node);
                }
                xmlDoc.Save(fileName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CreatNewXml(string fileName, List<Inscribe> inscribes)
        {
            try {
                int inscribesId = 0;
                xmlDoc = new XmlDocument();
                XmlDeclaration xmlDecl;
                xmlDecl = xmlDoc.CreateXmlDeclaration("1.0", "gb2312", null);
                xmlDoc.AppendChild(xmlDecl);
                xmlEle = xmlDoc.CreateElement("", "Inscribe", "");
                xmlDoc.AppendChild(xmlEle);
                XmlNode root = xmlDoc.SelectSingleNode("Inscribe");
                foreach (var inscribe in inscribes)
                {
                    XmlElement xmlElement = xmlDoc.CreateElement("选择题");
                    xmlElement.SetAttribute("id", $"{inscribesId}");
                    XmlElement xmlText = xmlDoc.CreateElement("Text");
                    xmlText.InnerText = inscribe.Text;
                    xmlElement.AppendChild(xmlText);
                    foreach (var candidates in inscribe.Candidates)
                    {
                        XmlElement xmlCandidates = xmlDoc.CreateElement("Candidates");
                        xmlCandidates.InnerText = candidates;
                        xmlElement.AppendChild(xmlCandidates);
                    }
                    foreach (var correctAnwsers in inscribe.CorrectAnwsers)
                    {
                        XmlElement xmlCorrectAnwsers = xmlDoc.CreateElement("CorrectAnwsers");
                        xmlCorrectAnwsers.InnerText = correctAnwsers;
                        xmlElement.AppendChild(xmlCorrectAnwsers);
                    }
                    root.AppendChild(xmlElement);
                    inscribesId++;
                }
                xmlDoc.Save(fileName);
                return true;
            }
            catch {
                return false;
            }
        }

        public bool DeleteElement(string fileName, int ElementId)
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);
            var root = xmlDoc.DocumentElement;
            XmlNodeList nodes = xmlDoc.SelectNodes("Inscribe/选择题");
            for (int i = 0; i < nodes.Count; i++)
            {
                XmlElement xmlElement = (XmlElement)nodes[i];
                if (int.Parse(xmlElement.GetAttribute("id")) == ElementId)
                {
                    root.RemoveChild(nodes[i]);
                    xmlDoc.Save(fileName);
                    return true;
                }
            }
            return false;
        }

        private int SelectLastElementId()
        {
            XmlNodeList nodes = xmlDoc.SelectNodes("Inscribe/选择题");
            XmlElement xmlElement = (XmlElement)nodes[nodes.Count - 1];
            return int.Parse(xmlElement.GetAttribute("id"));
        }

        public List<Inscribe> GetReadom(List<Inscribe> inscribes, int count)
        {
            Random random = new Random();
            List<Inscribe> inscribes1 = new List<Inscribe>();
            time.Interval = 20000;
            time.Tick += Time_Tick;
            while (inscribes1.Count == count)
            {
                time.Start();
                int intRandom = random.Next(count - 1);
                if (!IsContains(inscribes1, inscribes[intRandom]))
                {
                    inscribes1.Add(inscribes[intRandom]);
                }
            }
            time.Stop();
            return inscribes1;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            throw new Exception("试题数量不足");
        }

        private bool IsContains(List<Inscribe> inscribes ,Inscribe inscribe)
        {
            List<string> s = inscribes.Select(i => i.Text).ToList();
            return s.Contains(inscribe.Text);
        }

        public bool QuestionContains(string fileName, string title)
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);
            XmlNodeList nodes = xmlDoc.SelectNodes("Inscribe/选择题/Text");
            List<string> s = (from XmlNode v in nodes
                              select v.InnerText).ToList();
            return s.Contains(title) ? true : false;
        }

        public object[] Project_name()
        {
            return new object[] { "型号1、型号2启停回路故障维修实训", "型号1、型号2控制回路故障维修实训", "型号1副轨升降故障维修实训", "型号1支腿液压回路故障维修实训", "型号2辅升回路故障维修实训", "型号1推装架旋转润滑故障维修实训", "型号1、型号2发射车旋转回路故障维修", "型号1、型号2筒弹进退故障维修实训", "型号1大吊臂机械缸减速传动回路故障维修" };
        }

        public List<Inscribe> AllData(string fileName)
        {
            List<Inscribe> stuList = new List<Inscribe>();
            try {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(fileName);
            }
            catch {
                return stuList;
            }
            XmlNodeList nodes = xmlDoc.SelectNodes("Inscribe/选择题");
            for (int i = 0; i < nodes.Count; i++)
            {
                XmlElement xmlElement = (XmlElement)nodes[i];
                Inscribe inscribe = new Inscribe();
                inscribe.ElementId = int.Parse(xmlElement.GetAttribute("id"));
                node = nodes[i].SelectSingleNode("Text");
                inscribe.Text = node.InnerText;
                XmlNodeList xmlNodeList = nodes[i].SelectNodes("Candidates");
                for (int j = 0; j < xmlNodeList.Count; j++)
                {
                    inscribe.Candidates.Add(xmlNodeList[j].InnerText);
                }
                xmlNodeList = nodes[i].SelectNodes("CorrectAnwsers");
                for (int w = 0; w < xmlNodeList.Count; w++)
                {
                    inscribe.CorrectAnwsers.Add(xmlNodeList[w].InnerText);
                }
                stuList.Add(inscribe);
            }
            return stuList;
        }
    }
}