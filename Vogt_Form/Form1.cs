using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vogt_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = (textbox_f_name.Text+" "+textbox_l_name.Text);
            listbox.Items.Add(name);

            lblStatusStrip.Text = (name + " Added!");

            textbox_f_name.Clear();
            textbox_l_name.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStatusStrip.Text = "Ready!";
        }

    }
}
