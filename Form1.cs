using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReplaceNewLines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
            // C#
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                //MessageBox.Show(sr.ReadToEnd());
                txtPreview.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void btnCommatizeIt_Click(object sender, EventArgs e)
        {
            char tab = '\u0009';
            txtCommatized.Text = txtPreview.Text.Replace(Environment.NewLine, ", ");
            txtCommatized.Text = txtCommatized.Text.Replace(tab.ToString(), "");
        }

        private void btnSaveCommatized_Click(object sender, EventArgs e)
        {
            //System.IO.Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.Stream myStream = saveFileDialog1.OpenFile())
                {
                    if (myStream != null)
                    {
                        using (System.IO.StreamWriter myWritter = new System.IO.StreamWriter(myStream, System.Text.Encoding.ASCII))
                        {
                            myWritter.Write(txtCommatized.Text);
                        }
                    }
                }
            }
        }
    }

}
