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
    public partial class FormTutorial : Form
    {
        string path = "";

        public FormTutorial(string romPath)
        {
            InitializeComponent();
            path = romPath;
        }

        private void FormTutorial_Load(object sender, EventArgs e)
        {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText()
        {
            try
            {
                Backend backend = new Backend(path);
                textBox1.Text = backend.getROMText(0x2, 0x25AE, 0);
                textBox2.Text = backend.getROMText(0x4, 0x25B1, 0);
                textBox3.Text = backend.getROMText(0x4, 0x25B6, 0);
                textBox4.Text = backend.getROMText(0x5, 0x25BD, 0);
                textBox5.Text = backend.getROMText(0x5, 0x25C3, 0);
                textBox6.Text = backend.getROMText(0x6, 0x25C9, 0);
                textBox7.Text = backend.getROMText(0x2, 0x25D3, 0);
                textBox8.Text = backend.getROMText(0x4, 0x25D6, 0);
                textBox9.Text = backend.getROMText(0x4, 0x25DB, 0);
                textBox10.Text = backend.getROMText(0x5, 0x25E2, 0);
                textBox11.Text = backend.getROMText(0x5, 0x25E8, 0);
                textBox12.Text = backend.getROMText(0x6, 0x25EE, 0);
                textBox13.Text = backend.getROMText(0x5, 0x25F8, 0);
                textBox14.Text = backend.getROMText(0x4, 0x25FE, 0);
                textBox15.Text = backend.getROMText(0x3, 0x2605, 0);
                textBox16.Text = backend.getROMText(0x3, 0x2609, 0);
                textBox17.Text = backend.getROMText(0x8, 0x260D, 0);
                textBox18.Text = backend.getROMText(0x6, 0x2619, 0);
                textBox19.Text = backend.getROMText(0x5, 0x2620, 0);
                textBox20.Text = backend.getROMText(0x2, 0x2626, 0);
                textBox21.Text = backend.getROMText(0x4, 0x262B, 0);
                textBox22.Text = backend.getROMText(0x2, 0x2630, 0);
                textBox23.Text = backend.getROMText(0x6, 0x2633, 0);
                textBox24.Text = backend.getROMText(0x5, 0x263D, 0);
                textBox25.Text = backend.getROMText(0x4, 0x2643, 0);
                textBox26.Text = backend.getROMText(0x5, 0x264A, 0);
                textBox27.Text = backend.getROMText(0x2, 0x2652, 0);
                textBox28.Text = backend.getROMText(0x7, 0x2655, 0);
                textBox29.Text = backend.getROMText(0xC, 0x2660, 0); // where is the first double qutoes? OVERHEATING”
                textBox30.Text = backend.getROMText(0x3, 0x2670, 0);
                textBox31.Text = backend.getROMText(0x4, 0x2674, 0);
                textBox32.Text = backend.getROMText(0x5, 0x2679, 0);
                textBox33.Text = backend.getROMText(0x2, 0x2681, 0);
                textBox34.Text = backend.getROMText(0x5, 0x2684, 0);
                textBox35.Text = backend.getROMText(0x4, 0x268A, 0);
                textBox36.Text = backend.getROMText(0x5, 0x2691, 0);
                textBox37.Text = backend.getROMText(0x7, 0x2697, 0);
                textBox38.Text = backend.getROMText(0xD, 0x26A2, 0);
                textBox39.Text = backend.getROMText(0x7, 0x26B3, 0);
                textBox40.Text = backend.getROMText(0x7, 0x26BE, 0);
                textBox41.Text = backend.getROMText(0x4, 0x26CA, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBox1.MaxLength = 0x2;
            textBox2.MaxLength = 0x4;
            textBox3.MaxLength = 0x4;
            textBox4.MaxLength = 0x5;
            textBox5.MaxLength = 0x5;
            textBox6.MaxLength = 0x6;
            textBox7.MaxLength = 0x2;
            textBox8.MaxLength = 0x4;
            textBox9.MaxLength = 0x4;
            textBox10.MaxLength = 0x5;
            textBox11.MaxLength = 0x5;
            textBox12.MaxLength = 0x6;
            textBox13.MaxLength = 0x5;
            textBox14.MaxLength = 0x4;
            textBox15.MaxLength = 0x3;
            textBox16.MaxLength = 0x3;
            textBox17.MaxLength = 0x8;
            textBox18.MaxLength = 0x6;
            textBox19.MaxLength = 0x5;
            textBox20.MaxLength = 0x2;
            textBox21.MaxLength = 0x4;
            textBox22.MaxLength = 0x2;
            textBox23.MaxLength = 0x6;
            textBox24.MaxLength = 0x5;
            textBox25.MaxLength = 0x4;
            textBox26.MaxLength = 0x5;
            textBox27.MaxLength = 0x2;
            textBox28.MaxLength = 0x7;
            textBox29.MaxLength = 0xB;
            textBox30.MaxLength = 0x3;
            textBox31.MaxLength = 0x4;
            textBox32.MaxLength = 0x5;
            textBox33.MaxLength = 0x2;
            textBox34.MaxLength = 0x5;
            textBox35.MaxLength = 0x4;
            textBox36.MaxLength = 0x5;
            textBox37.MaxLength = 0x7;
            textBox38.MaxLength = 0xD;
            textBox39.MaxLength = 0x7;
            textBox40.MaxLength = 0x7;
            textBox41.MaxLength = 0x4;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                Backend backend = new Backend(path);
                backend.updateROMText(0x2, textBox1.Text, 0x25AE, 1);
                backend.updateROMText(0x4, textBox2.Text, 0x25B1, 1);
                backend.updateROMText(0x4, textBox3.Text, 0x25B6, 1);
                backend.updateROMText(0x5, textBox4.Text, 0x25BD, 1);
                backend.updateROMText(0x5, textBox5.Text, 0x25C3, 1);
                backend.updateROMText(0x6, textBox6.Text, 0x25C9, 1);
                backend.updateROMText(0x2, textBox7.Text, 0x25D3, 1);
                backend.updateROMText(0x4, textBox8.Text, 0x25D6, 1);
                backend.updateROMText(0x4, textBox9.Text, 0x25DB, 1);
                backend.updateROMText(0x5, textBox10.Text, 0x25E2, 1);
                backend.updateROMText(0x5, textBox11.Text, 0x25E8, 1);
                backend.updateROMText(0x6, textBox12.Text, 0x25EE, 1);
                backend.updateROMText(0x5, textBox13.Text, 0x25F8, 1);
                backend.updateROMText(0x4, textBox14.Text, 0x25FE, 1);
                backend.updateROMText(0x3, textBox15.Text, 0x2605, 1);
                backend.updateROMText(0x3, textBox16.Text, 0x2609, 1);
                backend.updateROMText(0x8, textBox17.Text, 0x260D, 1);
                backend.updateROMText(0x6, textBox18.Text, 0x2619, 1);
                backend.updateROMText(0x5, textBox19.Text, 0x2620, 1);
                backend.updateROMText(0x2, textBox20.Text, 0x2626, 1);
                backend.updateROMText(0x4, textBox21.Text, 0x262B, 1);
                backend.updateROMText(0x2, textBox22.Text, 0x2630, 1);
                backend.updateROMText(0x6, textBox23.Text, 0x2633, 1);
                backend.updateROMText(0x5, textBox24.Text, 0x263D, 1);
                backend.updateROMText(0x4, textBox25.Text, 0x2643, 1);
                backend.updateROMText(0x5, textBox26.Text, 0x264A, 1);
                backend.updateROMText(0x2, textBox27.Text, 0x2652, 1);
                backend.updateROMText(0x7, textBox28.Text, 0x2655, 1);
                backend.updateROMText(0xC, textBox29.Text, 0x2660, 1);
                backend.updateROMText(0x3, textBox30.Text, 0x2670, 1);
                backend.updateROMText(0x4, textBox31.Text, 0x2674, 1);
                backend.updateROMText(0x5, textBox32.Text, 0x2679, 1);
                backend.updateROMText(0x2, textBox33.Text, 0x2681, 1);
                backend.updateROMText(0x5, textBox34.Text, 0x2684, 1);
                backend.updateROMText(0x4, textBox35.Text, 0x268A, 1);
                backend.updateROMText(0x5, textBox36.Text, 0x2691, 1);
                backend.updateROMText(0x7, textBox37.Text, 0x2697, 1);
                backend.updateROMText(0xD, textBox38.Text, 0x26A2, 1);
                backend.updateROMText(0x7, textBox39.Text, 0x26B3, 1);
                backend.updateROMText(0x7, textBox40.Text, 0x26BE, 1);
                backend.updateROMText(0x4, textBox41.Text, 0x26CA, 1);

                MessageBox.Show("Updated Text!", "VS. Excitebike Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
