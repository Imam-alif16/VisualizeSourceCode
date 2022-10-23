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
            List<Kelas> KelasCollection = new List<Kelas>();

            string filePath = String.Empty;
            string fileExt = String.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                fileExt = Path.GetExtension(filePath);
                if (fileExt.CompareTo(".txt") == 0)
                {
                    try
                    {
                        StreamReader reader = new StreamReader(filePath);
                        StringBuilder builder = new StringBuilder();
                        string line = "";

                        while ((line = reader.ReadLine()) != null)
                        {
                            if ((line.Contains("class")))
                            {
                                string[] lineArr = line.Split(' ');
                                if (!(line.Contains("extends")))
                                {
                                    var kelas = new Kelas(lineArr[1], "");
                                    KelasCollection.Add(kelas);
                                }
                                else
                                {
                                    var kelas = new Kelas(lineArr[1], lineArr[3]);
                                    KelasCollection.Add(kelas);
                                }
                            }

                            builder.AppendLine(line);
                        }


                        reader.Close();
                        richTextBox1.Text = builder.ToString();

                        int hitung = 0;
                        foreach (Kelas item in KelasCollection)
                        {
                            Console.WriteLine(++hitung);
                            Console.WriteLine("nama class : " + item.namaKelas);
                            foreach (string super in item.superKelas)
                            {
                                Console.WriteLine("superClass : " + super);
                            }

                        }

                        //dataGridView1.DataSource = KelasCollection;
                        foreach (Kelas item in KelasCollection)
                        {
                            dataGridView1.Rows.Add(item.namaKelas, item.superKelas[0]);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
