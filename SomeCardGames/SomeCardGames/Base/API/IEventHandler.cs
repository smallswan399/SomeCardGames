﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeCardGames.Base
{
    /// <summary>
    /// The interface for all card game event handlers.
    /// </summary>
    public interface IEventHandler
    {
        /// <summary>
        /// This is called when a card is clicked on.
        /// </summary>
        void CardWasClickedOn(Card card, MouseEventArgs e);
    }
}