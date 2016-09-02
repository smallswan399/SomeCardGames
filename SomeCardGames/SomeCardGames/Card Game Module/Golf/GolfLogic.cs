﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SomeCardGames.Base;
using SomeCardGames.Drawing.Drawers;
using SomeCardGames.Error;

namespace SomeCardGames.Card_Game_Module.Golf
{
    /// <summary>
    /// This class is the main source and entrance for the card game "Golf".
    /// </summary>
    public class GolfLogic : ICardGame
    {

        /// <summary>
        /// A list of all of the players currently in the golf game.
        /// </summary>
        public List<GolfPlayer> Players;

        public GolfDrawer Drawer;

        /// <summary>
        /// This is the deck of cards in the middle of the table.
        /// </summary>
        public Deck TheDeck;

        /// <summary>
        /// Creates and deals in all of the players for this game.
        /// </summary>
        private void DealInPlayers()
        {
            try
            {
                Players = new List<GolfPlayer>();
                int i = 0;
                int PlayersToDealIn = SomeCardGames.Properties.Settings.Default.GolfAIPlayers;

                Players.Add(this.DealInPlayer(false));

                while (i != PlayersToDealIn)
                {
                    Players.Add(this.DealInPlayer(false));
                    i++;
                }
                
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Creates a GolfPlayer object, and returns it.
        /// </summary>
        /// <param name="IsAI"></param>
        private GolfPlayer DealInPlayer(bool IsAI)
        {
            try
            {
                GolfPlayer Player;
                Card[] Cards = new Card[6];

                int i = 0;

                while (i != 6)
                {
                    Cards[i] = this.TheDeck.GetTop();
                    i++;
                }

                Player = new GolfPlayer(Cards, IsAI);

                return Player;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return null;
            }
        }

        /// <summary>
        /// This method adds as many cards to the "deck" as needed to support as many AIs as are in the game.
        /// </summary>
        private void CreateGolfDeck()
        {
            try
            {
                int Decks;
                int Players = SomeCardGames.Properties.Settings.Default.GolfAIPlayers + 1;

                double Dec = Players / 3;

                Decks = (int)Math.Round(Dec, 0);

                if (Decks < 1)
                {
                    throw new Exception(ErrorStorage.InvalidDeckCreationException);
                }

                this.TheDeck = new Deck(false, Decks);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Called to start running this card game.
        /// </summary>
        public void Start()
        {
            try
            {
                this.Drawer = new GolfDrawer();
                this.Drawer.StartUp(this);
                this.CreateGolfDeck();
                this.DealInPlayers();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Called to stop this card game.
        /// </summary>
        public void Stop()
        {

        }
    }
}