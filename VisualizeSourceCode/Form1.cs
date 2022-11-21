using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MindFusion.Diagramming;
using System.Xml;
using Path = System.IO.Path;
using MindFusion.Diagramming.Layout;

namespace VisualizeSourceCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<ClassDataType> ClassCollection = new List<ClassDataType>();
        List<string> xmlDocuments = new List<string>();
        string XMLFilePath = @"D:\Kuliah\#SEMESTER 5\Perancangan dan Pengembangan Perangkat Lunak\Repos\VisualizeSourceCode\VisualizeSourceCode\XMLDiagram.xml";

        private void button1_Click(object sender, EventArgs e)
        {

            string filePath = String.Empty;
            string fileExt = String.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder builder = new StringBuilder();
                int id = 0;
                foreach (string file in openFileDialog.FileNames)
                {
                    filePath = file;
                    fileExt = Path.GetExtension(filePath);
                    if (fileExt.CompareTo(".txt") == 0)
                    {
                        try
                        {
                            StreamReader reader = new StreamReader(filePath);

                            string line = "";


                            while ((line = reader.ReadLine()) != null)
                            {
                                if ((line.Contains("class")))
                                {

                                    string[] lineArr = line.Split(' ');
                                    id++;
                                    if (!(line.Contains("extends")))
                                    {
                                        var kelas = new ClassDataType(lineArr[Array.FindIndex(lineArr, row => row.Contains("class")) + 1], "");
                                        kelas.id = id;
                                        ClassCollection.Add(kelas);
                                    }
                                    else
                                    {
                                        var kelas = new ClassDataType(lineArr[Array.FindIndex(lineArr, row => row.Contains("class")) + 1], lineArr[Array.FindIndex(lineArr, row => row.Contains("extends")) + 1]);
                                        kelas.id = id;
                                        ClassCollection.Add(kelas);
                                    }
                                }

                                builder.AppendLine(line);

                            }

                            builder.AppendLine("----------------------------------");
                            reader.Close();
                            richTextBox1.Text = builder.ToString();


                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                }

                foreach (ClassDataType item in ClassCollection)
                {
                    Console.WriteLine(item.id);
                    Console.WriteLine("nama class : " + item.className);
                    foreach (string super in item.superClassList)
                    {
                        Console.WriteLine("superClass : " + super);
                    }
                    if (item.superClassList.Any())
                    {

                        foreach (var itemclass in ClassCollection)
                        {
                            if (item.superClassList[0] == itemclass.className)
                            {
                                item.target = itemclass.id;
                            }
                        }
                    }

                }

                //ClassesData.DataSource = ClassCollection;
                foreach (var item in ClassCollection)
                {
                    if (!item.superClassList.Any())
                    {
                        dataGridView1.Rows.Add(item.className, "", item.id, item.target);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(item.className, item.superClassList[0], item.id, item.target);
                    }

                }

                //write xml documents
                xmlDocuments.Add(@"<?xml version=""1.0"" encoding=""utf-8"" ?>");
                xmlDocuments.Add("<Graph>");
                xmlDocuments.Add("<Nodes>");
                foreach (var item in ClassCollection)
                {
                    xmlDocuments.Add($"<Node id=\"{item.id}\" name=\"{item.className}\" />");
                }
                xmlDocuments.Add("</Nodes>");
                xmlDocuments.Add("<Links>");
                foreach (var item in ClassCollection)
                {
                    if (item.superClassList.Any())
                    {
                    xmlDocuments.Add($"<Link origin=\"{item.id}\" target=\"{item.target}\" />");                        
                    }
                }
                xmlDocuments.Add("</Links>");
                xmlDocuments.Add("</Graph>");

                File.WriteAllLines(XMLFilePath, xmlDocuments);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void diagramView1_Click_1(object sender, EventArgs e)
        {

        }

        private void diagram1_NodeCreated(object sender, MindFusion.Diagramming.NodeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, DiagramNode> nodeMap = new Dictionary<string, DiagramNode>();
            RectangleF bounds = new RectangleF(0, 0, 18, 6);

            XmlDocument document = new XmlDocument();
            document.Load(XMLFilePath);

            // Load node data
            XmlNodeList nodes = document.SelectNodes("/Graph/Nodes/Node");
            foreach (XmlElement node in nodes)
            {
                ShapeNode diagramNode = diagram1.Factory.CreateShapeNode(bounds);
                nodeMap[node.GetAttribute("id")] = diagramNode;
                diagramNode.Text = node.GetAttribute("name");
            }

            // Load link data
            XmlNodeList links = document.SelectNodes("/Graph/Links/Link");
            foreach (XmlElement link in links)
            {
                diagram1.Factory.CreateDiagramLink(
                    nodeMap[link.GetAttribute("origin")],
                    nodeMap[link.GetAttribute("target")]);
            }

            // Arrange the graph
            LayeredLayout layout = new LayeredLayout();
            layout.LayerDistance = 12;
            layout.Arrange(diagram1);
        }
    }
}
