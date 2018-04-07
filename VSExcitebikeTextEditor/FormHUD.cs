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
    public partial class FormHUD : Form
    {
        string path = "";

        public FormHUD(string romPath)
        {
            InitializeComponent();
            path = romPath;
        }

        private void FormHUD_Load(object sender, EventArgs e)
        {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText()
        {
            try
            {
                Backend backend = new Backend(path);
                textBox1.Text = backend.getROMText(0x3, 0x1C33, 0);
                textBox2.Text = backend.getROMText(0x4, 0x1C4D, 0);
                textBox3.Text = backend.getROMText(0x4, 0x1C67, 0);
                textBox4.Text = backend.getROMText(0x4, 0x1C8F, 0);
                textBox5.Text = backend.getROMText(0x4, 0x1C96, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBox1.MaxLength = 0x3;
            textBox2.MaxLength = 0x4;
            textBox3.MaxLength = 0x4;
            textBox4.MaxLength = 0x4;
            textBox5.MaxLength = 0x4;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                Backend backend = new Backend(path);
                backend.updateROMText(0x3, textBox1.Text, 0x1C33, 1);
                backend.updateROMText(0x4, textBox2.Text, 0x1C4D, 1);
                backend.updateROMText(0x4, textBox3.Text, 0x1C67, 1);
                backend.updateROMText(0x4, textBox4.Text, 0x1C8F, 1);
                backend.updateROMText(0x4, textBox5.Text, 0x1C96, 1);

                MessageBox.Show("Updated Text!", "VS. Excitebike Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
