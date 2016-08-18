﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SomeCardGames.Error;
using SomeCardGames.Utility;

namespace SomeCardGames
{
    /// <summary>
    /// This class holds some code, to reduce clutter in the Form1 class.
    /// </summary>
    public class Main
    {
        private Form1 TheForm;

        /// <summary>
        /// Called by the form, to do some start up stuff.
        /// </summary>
        public void Startup(object Form)
        {
            this.CaptureTheForm(Form);
            this.GetScreenSize();
            this.SetupForm();
        }

        /// <summary>
        /// Called when we want to shut this program down.
        /// </summary>
        public void Shutdown(int Code)
        {
            try
            {
                Environment.Exit(Code);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Saves the form to this class.
        /// </summary>
        /// <param name="Form"></param>
        private void CaptureTheForm(object Form)
        {
            try
            {
                TheForm = (Form1)Form;
            }
            catch (Exception e)
            {
                ErrorReporter.Report(e);
            }
        }

        /// <summary>
        /// Sets up the form.
        /// </summary>
        private void SetupForm()
        {
            try
            {
                TheForm.TopMost = true;
                TheForm.FormBorderStyle = FormBorderStyle.None;
                TheForm.WindowState = FormWindowState.Maximized;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Gets the size of the moniter.
        /// </summary>
        private void GetScreenSize()
        {
            try
            {
                VariableStorage.ScreenWidth = Screen.FromControl(TheForm).WorkingArea.Width;
                VariableStorage.ScreenHeight = Screen.FromControl(TheForm).WorkingArea.Height;
            }
            catch(Exception e)
            {
                ErrorReporter.Report(e);
            }
        }
    }
}