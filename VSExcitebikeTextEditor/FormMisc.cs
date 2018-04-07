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
    public partial class FormMisc : Form
    {
        string path = "";

        public FormMisc(string romPath)
        {
            InitializeComponent();
            path = romPath;
        }

        private void readRomText()
        {
            try
            {
                Backend backend = new Backend(path);
                textBox1.Text = backend.getROMText(0x7, 0x250C, 0);
                textBox2.Text = backend.getROMText(0x8, 0x255C, 0);
                textBox3.Text = backend.getROMText(0x8, 0x257B, 0);
                textBox4.Text = backend.getROMText(0x6, 0x49F6, 0);
                textBox5.Text = backend.getROMText(0x9, 0x4A04, 0);
                textBox6.Text = backend.getROMText(0x12, 0x4A48, 0);
                textBox7.Text = backend.getROMText(0x1C, 0x4A5C, 0);
                // textBox8.Text = backend.getROMText(0xF, 0x0, 0);
                // textBox9.Text = backend.getROMText(0x3, 0x0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBox1.MaxLength = 0x7;
            textBox2.MaxLength = 0x8;
            textBox3.MaxLength = 0x8;
            textBox4.MaxLength = 0x6;
            textBox5.MaxLength = 0x9;
            textBox6.MaxLength = 0x12;
            textBox7.MaxLength = 0x1C;
            textBox8.MaxLength = 0xF;
            textBox9.MaxLength = 0x3;
        }

        private void FormMisc_Load(object sender, EventArgs e)
        {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                Backend backend = new Backend(path);
                backend.updateROMText(0x7, textBox1.Text, 0x250C, 0);
                backend.updateROMText(0x8, textBox2.Text, 0x255C, 0);
                backend.updateROMText(0x8, textBox3.Text, 0x257B, 0);
                backend.updateROMText(0x6, textBox4.Text, 0x49F6, 0);
                backend.updateROMText(0x9, textBox5.Text, 0x4A04, 0);
                backend.updateROMText(0x12, textBox6.Text, 0x4A48, 0);
                backend.updateROMText(0x1C, textBox7.Text, 0x4A5C, 0);
                // backend.updateROMText(0xF, textBox8.Text, 0x0, 0);
                // backend.updateROMText(0x3, textBox9.Text, 0x0, 0);

                MessageBox.Show("Updated Text!", "VS. Excitebike Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
