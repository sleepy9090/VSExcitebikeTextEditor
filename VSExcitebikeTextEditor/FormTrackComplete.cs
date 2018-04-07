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
    public partial class FormTrackComplete : Form
    {
        string path = "";

        public FormTrackComplete(string romPath)
        {
            InitializeComponent();
            path = romPath;
        }

        private void FormTrackComplete_Load(object sender, EventArgs e)
        {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText()
        {
            try
            {
                Backend backend = new Backend(path);
                textBox1.Text = backend.getROMText(0x8, 0x1CB2, 0);
                textBox2.Text = backend.getROMText(0x9, 0x1CC9, 0);
                textBox3.Text = backend.getROMText(0xA, 0x1CE2, 0);
                textBox4.Text = backend.getROMText(0x17, 0x1D02, 0);
                textBox5.Text = backend.getROMText(0x14, 0x1D1C, 0);
                textBox6.Text = backend.getROMText(0x17, 0x1D36, 0);
                textBox7.Text = backend.getROMText(0x13, 0x1D50, 0);
                textBox8.Text = backend.getROMText(0x7, 0x1D6A, 0);
                textBox9.Text = backend.getROMText(0x9, 0x1D75, 0);
                textBox10.Text = backend.getROMText(0xA, 0x1D90, 0);
                textBox11.Text = backend.getROMText(0xB, 0x1D9E, 0);
                textBox12.Text = backend.getROMText(0xE, 0x1E52, 0);
                textBox13.Text = backend.getROMText(0x4, 0x1E79, 0);
                textBox14.Text = backend.getROMText(0xA, 0x1ED5, 0);
                textBox15.Text = backend.getROMText(0xE, 0x1EE2, 0);
                textBox16.Text = backend.getROMText(0x5, 0x1F48, 0);
                textBox17.Text = backend.getROMText(0x4, 0x1FD2, 0);
                textBox18.Text = backend.getROMText(0x4, 0x2103, 0);
                textBox19.Text = backend.getROMText(0x7, 0x210A, 0);
                textBox20.Text = backend.getROMText(0x6, 0x2114, 0);
                textBox21.Text = backend.getROMText(0x4, 0x211D, 0);
                textBox22.Text = backend.getROMText(0x5, 0x2124, 0);
                textBox23.Text = backend.getROMText(0x4, 0x2174, 0);
                textBox24.Text = backend.getROMText(0x6, 0x2179, 0);
                textBox25.Text = backend.getROMText(0xE, 0x1E80, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBox1.MaxLength = 0x8;
            textBox2.MaxLength = 0x9;
            textBox3.MaxLength = 0xA;
            textBox4.MaxLength = 0x17;
            textBox5.MaxLength = 0x14;
            textBox6.MaxLength = 0x17;
            textBox7.MaxLength = 0x13;
            textBox8.MaxLength = 0x7;
            textBox9.MaxLength = 0x9;
            textBox10.MaxLength = 0xA;
            textBox11.MaxLength = 0xB;
            textBox12.MaxLength = 0xE;
            textBox13.MaxLength = 0x4;
            textBox14.MaxLength = 0xA;
            textBox15.MaxLength = 0xE;
            textBox16.MaxLength = 0x5;
            textBox17.MaxLength = 0x4;
            textBox18.MaxLength = 0x4;
            textBox19.MaxLength = 0x7;
            textBox20.MaxLength = 0x6;
            textBox21.MaxLength = 0x4;
            textBox22.MaxLength = 0x5;
            textBox23.MaxLength = 0x4;
            textBox24.MaxLength = 0x6;
            textBox25.MaxLength = 0xE;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                Backend backend = new Backend(path);
                backend.updateROMText(0x8, textBox1.Text, 0x1CB2, 0);
                backend.updateROMText(0x9, textBox2.Text, 0x1CC9, 0);
                backend.updateROMText(0xA, textBox3.Text, 0x1CE2, 0);
                backend.updateROMText(0x17, textBox4.Text, 0x1D02, 0);
                backend.updateROMText(0x14, textBox5.Text, 0x1D1C, 0);
                backend.updateROMText(0x17, textBox6.Text, 0x1D36, 0);
                backend.updateROMText(0x13, textBox7.Text, 0x1D50, 0);
                backend.updateROMText(0x7, textBox8.Text, 0x1D6A, 0);
                backend.updateROMText(0x9, textBox9.Text, 0x1D75, 0);
                backend.updateROMText(0xA, textBox10.Text, 0x1D90, 0);
                backend.updateROMText(0xB, textBox11.Text, 0x1D9E, 0);
                //backend.updateROMText(0xE, textBox12.Text, 0x1E52, 0);
                backend.updateROMText(0x4, textBox13.Text, 0x1E79, 0);
                backend.updateROMText(0xE, textBox25.Text, 0x1E80, 0);
                backend.updateROMText(0xA, textBox14.Text, 0x1ED5, 0);
                backend.updateROMText(0xE, textBox15.Text, 0x1EE2, 0);
                backend.updateROMText(0x5, textBox16.Text, 0x1F48, 0);
                backend.updateROMText(0x4, textBox17.Text, 0x1FD2, 0);
                backend.updateROMText(0x4, textBox18.Text, 0x2103, 0);
                backend.updateROMText(0x7, textBox19.Text, 0x210A, 0);
                backend.updateROMText(0x6, textBox20.Text, 0x2114, 0);
                backend.updateROMText(0x4, textBox21.Text, 0x211D, 0);
                backend.updateROMText(0x5, textBox22.Text, 0x2124, 0);
                backend.updateROMText(0x4, textBox23.Text, 0x2174, 0);
                backend.updateROMText(0x6, textBox24.Text, 0x2179, 0);

                MessageBox.Show("Updated Text!", "VS. Excitebike Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
