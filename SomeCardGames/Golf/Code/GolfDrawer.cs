﻿using System;
using System.Drawing;

using SomeCardGamesAPI.API;
using SomeCardGamesAPI.Utility;
using SomeCardGamesAPI.Error;

namespace Golf.Code
{
    /// <summary>
    /// Draws the graphics for the Golf card game.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    public class GolfDrawer : IDrawer
    {

        /// <summary>
        /// Gives us a handle to the current graphics object, used to draw.
        /// </summary>
        public Graphics Current;

        /// <summary>
        /// The logic for the game is accessible through this object.
        /// </summary>
        public GolfLogic Game;

        /// <summary>
        /// Called by the paint event on the form. Draws the current status of the golf card game.
        /// </summary>
        /// <param name="G"></param>
        public void Draw(Graphics G)
        {
            try
            {
                Current = G;

                this.DrawStackInTheMiddle();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Draws the stack of cards in the middle of the screen.
        /// </summary>
        public void DrawStackInTheMiddle()
        {
            try
            {

            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Does some startup logic.
        /// </summary>
        /// <param name="Game"></param>
        public void StartUp(object Game)
        {
            try
            {
                this.Game = (GolfLogic)Game;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}