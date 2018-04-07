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
    public partial class FormDefaultRecordInitials : Form
    {
        string path = "";

        public FormDefaultRecordInitials(string romPath)
        {
            InitializeComponent();
            path = romPath;
        }

        private void FormDefaultRecordInitials_Load(object sender, EventArgs e)
        {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText()
        {
            try
            {
                Backend backend = new Backend(path);
                int offset = 0x059D;
                textBox1.Text = backend.getROMText(0x3, offset, 0);
                textBox2.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox3.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox4.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox5.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox6.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox7.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox8.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox9.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox10.Text = backend.getROMText(0x3, offset += 0x3, 0);
                offset = 0x050F;
                textBox11.Text = backend.getROMText(0x3, offset, 0);
                textBox12.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox13.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox14.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox15.Text = backend.getROMText(0x3, offset += 0x3, 0);
                offset = 0x051F;
                textBox16.Text = backend.getROMText(0x3, offset, 0);
                textBox17.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox18.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox19.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox20.Text = backend.getROMText(0x3, offset += 0x3, 0);
                offset = 0x052F;
                textBox21.Text = backend.getROMText(0x3, offset, 0);
                textBox22.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox23.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox24.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox25.Text = backend.getROMText(0x3, offset += 0x3, 0);
                offset = 0x053F;
                textBox26.Text = backend.getROMText(0x3, offset, 0);
                textBox27.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox28.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox29.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox30.Text = backend.getROMText(0x3, offset += 0x3, 0);
                offset = 0x054F;
                textBox31.Text = backend.getROMText(0x3, offset, 0);
                textBox32.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox33.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox34.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox35.Text = backend.getROMText(0x3, offset += 0x3, 0);
                offset = 0x055F;
                textBox36.Text = backend.getROMText(0x3, offset, 0);
                textBox37.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox38.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox39.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox40.Text = backend.getROMText(0x3, offset += 0x3, 0);
                offset = 0x056F;
                textBox41.Text = backend.getROMText(0x3, offset, 0);
                textBox42.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox43.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox44.Text = backend.getROMText(0x3, offset += 0x3, 0);
                textBox45.Text = backend.getROMText(0x3, offset += 0x3, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBox1.MaxLength = 0x3;
            textBox2.MaxLength = 0x3;
            textBox3.MaxLength = 0x3;
            textBox4.MaxLength = 0x3;
            textBox5.MaxLength = 0x3;
            textBox6.MaxLength = 0x3;
            textBox7.MaxLength = 0x3;
            textBox8.MaxLength = 0x3;
            textBox9.MaxLength = 0x3;
            textBox10.MaxLength = 0x3;
            textBox11.MaxLength = 0x3;
            textBox12.MaxLength = 0x3;
            textBox13.MaxLength = 0x3;
            textBox14.MaxLength = 0x3;
            textBox15.MaxLength = 0x3;
            textBox16.MaxLength = 0x3;
            textBox17.MaxLength = 0x3;
            textBox18.MaxLength = 0x3;
            textBox19.MaxLength = 0x3;
            textBox20.MaxLength = 0x3;
            textBox21.MaxLength = 0x3;
            textBox22.MaxLength = 0x3;
            textBox23.MaxLength = 0x3;
            textBox24.MaxLength = 0x3;
            textBox25.MaxLength = 0x3;
            textBox26.MaxLength = 0x3;
            textBox27.MaxLength = 0x3;
            textBox28.MaxLength = 0x3;
            textBox29.MaxLength = 0x3;
            textBox30.MaxLength = 0x3;
            textBox31.MaxLength = 0x3;
            textBox32.MaxLength = 0x3;
            textBox33.MaxLength = 0x3;
            textBox34.MaxLength = 0x3;
            textBox35.MaxLength = 0x3;
            textBox36.MaxLength = 0x3;
            textBox37.MaxLength = 0x3;
            textBox38.MaxLength = 0x3;
            textBox39.MaxLength = 0x3;
            textBox40.MaxLength = 0x3;
            textBox41.MaxLength = 0x3;
            textBox42.MaxLength = 0x3;
            textBox43.MaxLength = 0x3;
            textBox44.MaxLength = 0x3;
            textBox45.MaxLength = 0x3;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                Backend backend = new Backend(path);
                int offset = 0x059D;
                backend.updateROMText(0x3, textBox1.Text, offset, 0);
                backend.updateROMText(0x3, textBox2.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox3.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox4.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox5.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox6.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox7.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox8.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox9.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox10.Text, offset += 0x3, 0);
                offset = 0x050F;
                backend.updateROMText(0x3, textBox11.Text, offset, 0);
                backend.updateROMText(0x3, textBox12.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox13.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox14.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox15.Text, offset += 0x3, 0);
                offset = 0x051F;
                backend.updateROMText(0x3, textBox16.Text, offset, 0);
                backend.updateROMText(0x3, textBox17.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox18.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox19.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox20.Text, offset += 0x3, 0);
                offset = 0x052F;
                backend.updateROMText(0x3, textBox21.Text, offset, 0);
                backend.updateROMText(0x3, textBox22.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox23.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox24.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox25.Text, offset += 0x3, 0);
                offset = 0x053F;
                backend.updateROMText(0x3, textBox26.Text, offset, 0);
                backend.updateROMText(0x3, textBox27.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox28.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox29.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox30.Text, offset += 0x3, 0);
                offset = 0x054F;
                backend.updateROMText(0x3, textBox31.Text, offset, 0);
                backend.updateROMText(0x3, textBox32.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox33.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox34.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox35.Text, offset += 0x3, 0);
                offset = 0x055F;
                backend.updateROMText(0x3, textBox36.Text, offset, 0);
                backend.updateROMText(0x3, textBox37.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox38.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox39.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox40.Text, offset += 0x3, 0);
                offset = 0x056F;
                backend.updateROMText(0x3, textBox41.Text, offset, 0);
                backend.updateROMText(0x3, textBox42.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox43.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox44.Text, offset += 0x3, 0);
                backend.updateROMText(0x3, textBox45.Text, offset += 0x3, 0);

                MessageBox.Show("Updated Text!", "VS. Excitebike Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
