using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using EolCopy.Data_Processing;

namespace EolCopy
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool prvniRadek = true;
            string[] popisky;
            List<string[]> radky = new List<string[]>();
            DataTable dt = new DataTable();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                while (sr.Peek()>=0)
                {
                    if (prvniRadek)
                    {
                        string prvni = sr.ReadLine();
                        popisky = prvni.Split(';');
                        int i = 0;
                        foreach (string sloupec in popisky)
                        {
                            dt.Columns.Add(sloupec+i++);
                        }
                        
                    }
                    radky.Add(sr.ReadLine().Split(';'));

                    prvniRadek = false;
                    
                }
                foreach (var item in radky)
                {
                    dt.Rows.Add(item);
                }
                Typ test = new Typ(openFileDialog1.FileName);
                dataGridView1.DataSource = test.Data;
                
            }
            
            
        }
    }
}
