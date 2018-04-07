using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Author: Shawn M. Crawford [sleepy]
 * sleepy3d@gmail.com
 * 03/25/2018
 */
namespace VSExcitebikeTextEditor
{
    public partial class FormSelectTrack : Form
    {
        string path = "";

        public FormSelectTrack(string romPath)
        {
            InitializeComponent();
            path = romPath;
        }

        private void FormSelectTrack_Load(object sender, EventArgs e)
        {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText()
        {
            try
            {
                Backend backend = new Backend(path);
                textBox1.Text = backend.getROMText(0xD, 0x2388, 0);
                textBox2.Text = backend.getROMText(0x10, 0x2398, 0);
                textBox3.Text = backend.getROMText(0x9, 0x23B3, 0);
                textBox4.Text = backend.getROMText(0xD, 0x23C7, 0);
                textBox5.Text = backend.getROMText(0x9, 0x23DF, 0);
                textBox6.Text = backend.getROMText(0x16, 0x23EB, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBox1.MaxLength = 0xD;
            textBox2.MaxLength = 0x10;
            textBox3.MaxLength = 0x9;
            textBox4.MaxLength = 0xD;
            textBox5.MaxLength = 0x9;
            textBox6.MaxLength = 0x16;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                Backend backend = new Backend(path);
                backend.updateROMText(0xD, textBox1.Text, 0x2388, 0);
                backend.updateROMText(0x10, textBox2.Text, 0x2398, 0);
                backend.updateROMText(0x9, textBox3.Text, 0x23B3, 0);
                backend.updateROMText(0xD, textBox4.Text, 0x23C7, 0);
                backend.updateROMText(0x9, textBox5.Text, 0x23DF, 0);
                backend.updateROMText(0x16, textBox6.Text, 0x23EB, 0);

                MessageBox.Show("Updated Text!", "VS. Excitebike Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
