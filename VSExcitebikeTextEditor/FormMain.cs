using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Author: Shawn M. Crawford [sleepy]
 * sleepy3d@gmail.com
 * 03/04/2018
 */
namespace VSExcitebikeTextEditor
{
    public partial class FormMain : Form
    {
        string path;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disableMenuItems();
        }

        #region Private methods
        private void enableMenuItems()
        {
            defaultRecordInitialsToolStripMenuItem.Enabled = true;
            hUDToolStripMenuItem.Enabled = true;
            miscToolStripMenuItem.Enabled = true;
            registrationToolStripMenuItem.Enabled = true;
            selectTrackToolStripMenuItem.Enabled = true;
            trackCompleteToolStripMenuItem.Enabled = true;
            tutorialToolStripMenuItem.Enabled = true;
        }

        private void disableMenuItems()
        {
            defaultRecordInitialsToolStripMenuItem.Enabled = false;
            hUDToolStripMenuItem.Enabled = false;
            miscToolStripMenuItem.Enabled = false;
            registrationToolStripMenuItem.Enabled = false;
            selectTrackToolStripMenuItem.Enabled = false;
            trackCompleteToolStripMenuItem.Enabled = false;
            tutorialToolStripMenuItem.Enabled = false;
        }
        #endregion

        #region Buttons
        private void buttonOpenROM_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file...";
            ofd.Filter = "nes files (*.nes)|*.nes|All files (*.*)|*.*";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                textBoxAbsoluteFilename.Text = path;

                enableMenuItems();
            }
        }
        #endregion

        #region Menu Items
        private void openROMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonOpenROM_Click(sender, e);
        }

        private void defaultRecordInitialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDefaultRecordInitials formDefaultRecordInitials = new FormDefaultRecordInitials(path);
            formDefaultRecordInitials.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void hUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHUD formHUD = new FormHUD(path);
            formHUD.ShowDialog();
        }

        private void miscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMisc formMisc = new FormMisc(path);
            formMisc.ShowDialog();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration(path);
            formRegistration.ShowDialog();
        }

        private void selectTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectTrack formSelectTrack = new FormSelectTrack(path);
            formSelectTrack.ShowDialog();
        }

        private void trackCompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrackComplete formTrackComplete = new FormTrackComplete(path);
            formTrackComplete.ShowDialog();
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTutorial formTutorial = new FormTutorial(path);
            formTutorial.ShowDialog();
        }
        #endregion
    }
}