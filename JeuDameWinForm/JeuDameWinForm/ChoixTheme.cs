using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDameWinForm
{
    public partial class ChoixTheme : Form
    {

        public String selected;

        public ChoixTheme()
        {
            InitializeComponent();
            this.rbClassic.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.rbStarWars.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.rbDbz.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.rbBoo.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

       private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                selected = rb.Text;
            }
        }

       
    }
}
