﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SomeCardGames.Error;

namespace SomeCardGames
{
    /// <summary>
    /// The main form, that everything is displayed on.
    /// </summary>
    public partial class Form1 : Form
    {
        Main main = new Main();

        /// <summary>
        /// The inital call to this program.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is called when the form loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            main.Startup(this);
        }

        /// <summary>
        /// Called when a item is clicked on the menu strip.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void newToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Called when the "load" button is clicked on the menu strip.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Called when the "options" button is clicked on the menu strip.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionsToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Called when the "save" button is clicked on the menu strip.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                string a = "easdklfjalskdfj;ejæE8K↔";
                Button b = new Button();
                object c = a;
                b = (Button)c;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Called when the "exit" button is clicked on the menu strip.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.main.Shutdown(0);
        }
    }
}