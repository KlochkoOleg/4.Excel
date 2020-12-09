using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excel
{
    public partial class Form1 : Form
    {
        ImprtData ImportD = new ImprtData();
        inValid Validator = new inValid();
        Calculare Calc = new Calculare();
        public Form1()
        {
            InitializeComponent();
            Application.ApplicationExit +=Exit;

        }
        private void Exit(object sender,EventArgs e)
        {
            Calc.Quit();
            Validator.Quit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog()
            {
                Multiselect = false,
                RestoreDirectory = true,
                Filter = "TXT(*.txt)|*.txt|JSON(*.json)|*.json|XML(*.xml)|*.xml"
            })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Ecuatii[] result;

                    if (dlg.FileName.IndexOf(".txt") != -1 || dlg.FileName.IndexOf(".TXT") != -1)
                        result = ImportD.ImportTxt(dlg.FileName);
                    else if (dlg.FileName.IndexOf(".json") != -1 || dlg.FileName.IndexOf(".JSON") != -1)
                        result = ImportD.ImportJSON(dlg.FileName);
                    else
                        result = ImportD.ImportXML(dlg.FileName);

                    result = Validator.Valid(result);

                    string temp = "";


                    for (int i = 0; i < result.Length; i++)
                        treeView1.Nodes.Add(result[i].equation);


                    if (temp.Length > 0)
                        MessageBox.Show("Error: \n" + temp);
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Super.Rows.Clear();
            int Xam = e.Node.Text.Length - e.Node.Text.Replace("X", "").Length;
            int xam = e.Node.Text.Length - e.Node.Text.Replace("x", "").Length;
            for (int i = 0; i < Xam + xam; i++)
                Super.Rows.Add("x" + (i + 1).ToString(), "");


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (treeView1.SelectedNode != null)
            {
                double[] args = new double[Super.Rows.Count];
                int i = 0;
                try
                {
                    for (; i < Super.Rows.Count; i++)
                        args[i] = double.Parse(Super.Rows[i].Cells[1].Value.ToString());
                    double result = Calc.Calc(args, treeView1.SelectedNode.Text);
                    textBox1.Text = result.ToString();
                }
                catch { }
                
                    
                

            }
        }
    }
}
