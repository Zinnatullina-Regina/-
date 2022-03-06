using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Вкладки
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

      

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            string title = "+" + (tabControl1.TabCount + 1).ToString();
            TabPage tabPage3 = new TabPage(title);
            tabControl1.TabPages.Add(tabPage3);



        }

       

      

        private void butSettings_Click(object sender, EventArgs e)
        {
          Dop dop = new Dop();
            dop.ShowDialog();
        }

        private void butDownload_Click(object sender, EventArgs e)
        {
            string fam = Fam.Text;
            string name = Name.Text;
            string etc = Etc.Text;
            dataGridView1.Rows.Add(fam, name, etc);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Zinnatullina-Regina");
        }

        private void butDelite_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void butSelDel_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(ind);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream stream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog1.OpenFile())!= null)
                {
                    StreamWriter myW = new StreamWriter(stream);
                    try
                    {
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                string data = dataGridView1.Rows[i].Cells[j].Value.ToString().Replace("^", "****");
                                myW.Write(data + "^");
                            }
                            myW.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myW.Close();

                    }
                }
            }
            
        }

       
    }
}
