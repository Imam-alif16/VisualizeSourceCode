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
using System.Drawing.Drawing2D;

namespace VisualizeSourceCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ClassDataType> ClassCollection = new List<ClassDataType>();

            string filePath = String.Empty;
            string fileExt = String.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder builder = new StringBuilder();
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
                                    if (!(line.Contains("extends")))
                                    {
                                        var kelas = new ClassDataType(lineArr[Array.FindIndex(lineArr, row => row.Contains("class")) + 1], "");
                                        ClassCollection.Add(kelas);
                                    }
                                    else
                                    {
                                        var kelas = new ClassDataType(lineArr[Array.FindIndex(lineArr, row => row.Contains("class")) + 1], lineArr[Array.FindIndex(lineArr, row => row.Contains("extends")) + 1]);
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


                int hitung = 0;
                foreach (ClassDataType item in ClassCollection)
                {
                    Console.WriteLine(++hitung);
                    Console.WriteLine("nama class : " + item.className);
                    foreach (string super in item.superClassList)
                    {
                        Console.WriteLine("superClass : " + super);
                    }

                }

                //ClassesData.DataSource = ClassCollection;
                foreach (var item in ClassCollection)
                {
                    if (!item.superClassList.Any())
                    {
                        dataGridView1.Rows.Add(item.className);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(item.className, item.superClassList[0]);
                    }

                }
            }
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

        private void diagramView1_Click(object sender, EventArgs e)
        {

        }

        private void diagram3_NodeCreated(object sender, MindFusion.Diagramming.NodeEventArgs e)
        {

        }

        private void diagramView1_Click_1(object sender, EventArgs e)
        {

        }

        private void diagram1_NodeCreated(object sender, MindFusion.Diagramming.NodeEventArgs e)
        {

        }
    }
}
