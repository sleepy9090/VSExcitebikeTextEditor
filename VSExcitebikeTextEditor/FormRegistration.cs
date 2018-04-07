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
    public partial class FormRegistration : Form
    {
        string path = "";

        public FormRegistration(string romPath)
        {
            InitializeComponent();
            path = romPath;
        }

        private void readRomText()
        {
            try
            {
                Backend backend = new Backend(path);
                textBox1.Text = backend.getROMText(0x18, 0x21AA, 0);
                textBox2.Text = backend.getROMText(0x11, 0x21ED, 0);
                textBox3.Text = backend.getROMText(0x4, 0x2201, 0);
                textBox4.Text = backend.getROMText(0x13, 0x220C, 0);
                textBox5.Text = backend.getROMText(0x13, 0x2222, 0);
                textBox6.Text = backend.getROMText(0xF, 0x2238, 0);
                textBox7.Text = backend.getROMText(0xB, 0x224E, 0);
                textBox8.Text = backend.getROMText(0x7, 0x22B0, 0);
                textBox9.Text = backend.getROMText(0x6, 0x22B8, 0);
                textBox10.Text = backend.getROMText(0xE, 0x22F7, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBox1.MaxLength = 0x18;
            textBox2.MaxLength = 0x11;
            textBox3.MaxLength = 0x4;
            textBox4.MaxLength = 0x13;
            textBox5.MaxLength = 0x13;
            textBox6.MaxLength = 0xF;
            textBox7.MaxLength = 0xB;
            textBox8.MaxLength = 0x7;
            textBox9.MaxLength = 0x6;
            textBox10.MaxLength = 0xE;
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                Backend backend = new Backend(path);
                backend.updateROMText(0x18, textBox1.Text, 0x21AA, 0);
                backend.updateROMText(0x11, textBox2.Text, 0x21ED, 0);
                backend.updateROMText(0x4, textBox3.Text, 0x2201, 0);
                backend.updateROMText(0x13, textBox4.Text, 0x220C, 0);
                backend.updateROMText(0x13, textBox5.Text, 0x2222, 0);
                backend.updateROMText(0xF, textBox6.Text, 0x2238, 0);
                backend.updateROMText(0xB, textBox7.Text, 0x224E, 0);
                backend.updateROMText(0x7, textBox8.Text, 0x22B0, 0);
                backend.updateROMText(0x6, textBox9.Text, 0x22B8, 0);
                backend.updateROMText(0xE, textBox10.Text, 0x22F7, 0);

                MessageBox.Show("Updated Text!", "VS. Excitebike Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
