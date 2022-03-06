using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Вкладки
{
    public partial class Dop : Form
    {
        public Dop()
        {
            InitializeComponent();
        }
        
        int t;
        private void OnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (OnOff.Checked)
            {
                t = 0;
            }
           
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton.Checked)
            {
                t = 1;
            }
            
        }
        private void butOkDop_Click(object sender, EventArgs e)
        {
            form1 k = new form1();

            if (t == 0)
            {

                k.Fam.Enabled = true;
                k.Name.Enabled = true;
                k.Etc.Enabled = true;
            }

            else
            {
                k.Fam.Enabled = false;
                k.Name.Enabled = false;
                k.Etc.Enabled = false;
            }
            this.Close();
            
        }

        private void butCancelDop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
