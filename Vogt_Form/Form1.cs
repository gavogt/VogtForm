using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
            string name = (textbox_f_name.Text + " " + textbox_l_name.Text);
            listbox.Items.Add(name);

            lblStatusStrip.Text = (name + " Added!");

            textbox_f_name.Clear();
            textbox_l_name.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblStatusStrip.Text = "Ready!";
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(myStream, listbox.Items.ToString());
                    myStream.Close();

                    foreach(char names in listbox.Items.ToString())
                    {
                        // Why isn't string names working?
                        // Update. I mispelled breaks
                        
                    }
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            
        }
    }
}
