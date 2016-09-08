﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using SomeCardGames.Error;
using SomeCardGames.Utility;

namespace SomeCardGames.Base
{//Job for next time: split the base stuff we need into a dll, so i can split the Golf code into a dll.
    /// <summary>
    /// This class is used to store bitmaps for cards.
    /// </summary>
    public static class LoadedCardResources
    {
        private static List<Bitmap> CardResources = new List<Bitmap>();

        private static Bitmap Back;

        /// <summary>
        /// Loads a bunch of resources into memory.
        /// </summary>
        /// <param name="Card"></param>
        /// <returns></returns>
        public static Bitmap GetResource(int Card)
        {
            try
            {
                return CardResources.ElementAt(Card);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return null;
            }
        }

        /// <summary>
        /// Gets what the back of the cards looks like.
        /// </summary>
        /// <returns></returns>
        public static Bitmap GetBack()
        {
            try
            {
                return Back;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return null;
            }
        }

        /// <summary>
        /// Determins which resources to load based on the size of everything.
        /// </summary>
        /// <param name="ScreenSize"></param>
        public static void LoadResources()
        {
            try
            {
                Size ScreenSize = Util.GetScreenSize(VariableStorage.TheForm);
                if (ScreenSize.Height > 2560)
                {
                    LoadResourcesHighestRes();
                    return;
                }
                if (ScreenSize.Height > 1920)
                {
                    LoadResources2560Res();
                    return;
                }
                if (ScreenSize.Height <= 1920)
                {
                    LoadResources1920Res();
                    return;
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Loads resources for the 1920x resolution.
        /// </summary>
        public static void LoadResources1920Res()
        {
            try
            {
                Back = MainResources_1920x1380_.Resources.back;
                CardResources.Add(MainResources_1920x1380_.Resources._1);
                CardResources.Add(MainResources_1920x1380_.Resources._2);
                CardResources.Add(MainResources_1920x1380_.Resources._3);
                CardResources.Add(MainResources_1920x1380_.Resources._4);
                CardResources.Add(MainResources_1920x1380_.Resources._5);
                CardResources.Add(MainResources_1920x1380_.Resources._6);
                CardResources.Add(MainResources_1920x1380_.Resources._7);
                CardResources.Add(MainResources_1920x1380_.Resources._8);
                CardResources.Add(MainResources_1920x1380_.Resources._9);
                CardResources.Add(MainResources_1920x1380_.Resources._10);
                CardResources.Add(MainResources_1920x1380_.Resources._11);
                CardResources.Add(MainResources_1920x1380_.Resources._12);
                CardResources.Add(MainResources_1920x1380_.Resources._13);
                CardResources.Add(MainResources_1920x1380_.Resources._14);
                CardResources.Add(MainResources_1920x1380_.Resources._15);
                CardResources.Add(MainResources_1920x1380_.Resources._16);
                CardResources.Add(MainResources_1920x1380_.Resources._17);
                CardResources.Add(MainResources_1920x1380_.Resources._18);
                CardResources.Add(MainResources_1920x1380_.Resources._19);
                CardResources.Add(MainResources_1920x1380_.Resources._20);
                CardResources.Add(MainResources_1920x1380_.Resources._21);
                CardResources.Add(MainResources_1920x1380_.Resources._22);
                CardResources.Add(MainResources_1920x1380_.Resources._23);
                CardResources.Add(MainResources_1920x1380_.Resources._24);
                CardResources.Add(MainResources_1920x1380_.Resources._25);
                CardResources.Add(MainResources_1920x1380_.Resources._26);
                CardResources.Add(MainResources_1920x1380_.Resources._27);
                CardResources.Add(MainResources_1920x1380_.Resources._28);
                CardResources.Add(MainResources_1920x1380_.Resources._29);
                CardResources.Add(MainResources_1920x1380_.Resources._30);
                CardResources.Add(MainResources_1920x1380_.Resources._31);
                CardResources.Add(MainResources_1920x1380_.Resources._32);
                CardResources.Add(MainResources_1920x1380_.Resources._33);
                CardResources.Add(MainResources_1920x1380_.Resources._34);
                CardResources.Add(MainResources_1920x1380_.Resources._35);
                CardResources.Add(MainResources_1920x1380_.Resources._36);
                CardResources.Add(MainResources_1920x1380_.Resources._37);
                CardResources.Add(MainResources_1920x1380_.Resources._38);
                CardResources.Add(MainResources_1920x1380_.Resources._39);
                CardResources.Add(MainResources_1920x1380_.Resources._40);
                CardResources.Add(MainResources_1920x1380_.Resources._41);
                CardResources.Add(MainResources_1920x1380_.Resources._42);
                CardResources.Add(MainResources_1920x1380_.Resources._43);
                CardResources.Add(MainResources_1920x1380_.Resources._44);
                CardResources.Add(MainResources_1920x1380_.Resources._45);
                CardResources.Add(MainResources_1920x1380_.Resources._46);
                CardResources.Add(MainResources_1920x1380_.Resources._47);
                CardResources.Add(MainResources_1920x1380_.Resources._48);
                CardResources.Add(MainResources_1920x1380_.Resources._49);
                CardResources.Add(MainResources_1920x1380_.Resources._50);
                CardResources.Add(MainResources_1920x1380_.Resources._51);
                CardResources.Add(MainResources_1920x1380_.Resources._52);
                CardResources.Add(MainResources_1920x1380_.Resources._53);
                CardResources.Add(MainResources_1920x1380_.Resources._54);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Loads resources of the 2560 res.
        /// </summary>
        public static void LoadResources2560Res()
        {
            try
            {
                Back = MainResources_2560x1829_.Resources.back;
                CardResources.Add(MainResources_2560x1829_.Resources._1);
                CardResources.Add(MainResources_2560x1829_.Resources._2);
                CardResources.Add(MainResources_2560x1829_.Resources._3);
                CardResources.Add(MainResources_2560x1829_.Resources._4);
                CardResources.Add(MainResources_2560x1829_.Resources._5);
                CardResources.Add(MainResources_2560x1829_.Resources._6);
                CardResources.Add(MainResources_2560x1829_.Resources._7);
                CardResources.Add(MainResources_2560x1829_.Resources._8);
                CardResources.Add(MainResources_2560x1829_.Resources._9);
                CardResources.Add(MainResources_2560x1829_.Resources._10);
                CardResources.Add(MainResources_2560x1829_.Resources._11);
                CardResources.Add(MainResources_2560x1829_.Resources._12);
                CardResources.Add(MainResources_2560x1829_.Resources._13);
                CardResources.Add(MainResources_2560x1829_.Resources._14);
                CardResources.Add(MainResources_2560x1829_.Resources._15);
                CardResources.Add(MainResources_2560x1829_.Resources._16);
                CardResources.Add(MainResources_2560x1829_.Resources._17);
                CardResources.Add(MainResources_2560x1829_.Resources._18);
                CardResources.Add(MainResources_2560x1829_.Resources._19);
                CardResources.Add(MainResources_2560x1829_.Resources._20);
                CardResources.Add(MainResources_2560x1829_.Resources._21);
                CardResources.Add(MainResources_2560x1829_.Resources._22);
                CardResources.Add(MainResources_2560x1829_.Resources._23);
                CardResources.Add(MainResources_2560x1829_.Resources._24);
                CardResources.Add(MainResources_2560x1829_.Resources._25);
                CardResources.Add(MainResources_2560x1829_.Resources._26);
                CardResources.Add(MainResources_2560x1829_.Resources._27);
                CardResources.Add(MainResources_2560x1829_.Resources._28);
                CardResources.Add(MainResources_2560x1829_.Resources._29);
                CardResources.Add(MainResources_2560x1829_.Resources._30);
                CardResources.Add(MainResources_2560x1829_.Resources._31);
                CardResources.Add(MainResources_2560x1829_.Resources._32);
                CardResources.Add(MainResources_2560x1829_.Resources._33);
                CardResources.Add(MainResources_2560x1829_.Resources._34);
                CardResources.Add(MainResources_2560x1829_.Resources._35);
                CardResources.Add(MainResources_2560x1829_.Resources._36);
                CardResources.Add(MainResources_2560x1829_.Resources._37);
                CardResources.Add(MainResources_2560x1829_.Resources._38);
                CardResources.Add(MainResources_2560x1829_.Resources._39);
                CardResources.Add(MainResources_2560x1829_.Resources._40);
                CardResources.Add(MainResources_2560x1829_.Resources._41);
                CardResources.Add(MainResources_2560x1829_.Resources._42);
                CardResources.Add(MainResources_2560x1829_.Resources._43);
                CardResources.Add(MainResources_2560x1829_.Resources._44);
                CardResources.Add(MainResources_2560x1829_.Resources._45);
                CardResources.Add(MainResources_2560x1829_.Resources._46);
                CardResources.Add(MainResources_2560x1829_.Resources._47);
                CardResources.Add(MainResources_2560x1829_.Resources._48);
                CardResources.Add(MainResources_2560x1829_.Resources._49);
                CardResources.Add(MainResources_2560x1829_.Resources._50);
                CardResources.Add(MainResources_2560x1829_.Resources._51);
                CardResources.Add(MainResources_2560x1829_.Resources._52);
                CardResources.Add(MainResources_2560x1829_.Resources._53);
                CardResources.Add(MainResources_2560x1829_.Resources._54);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Kicks off the necessary steps to load all resources needed.
        /// </summary>
        public static void LoadResourcesHighestRes()
        {
            try
            {
                Back = MainResources.MainResources.back;
                CardResources.Add(MainResources.MainResources._1);
                CardResources.Add(MainResources.MainResources._2);
                CardResources.Add(MainResources.MainResources._3);
                CardResources.Add(MainResources.MainResources._4);
                CardResources.Add(MainResources.MainResources._5);
                CardResources.Add(MainResources.MainResources._6);
                CardResources.Add(MainResources.MainResources._7);
                CardResources.Add(MainResources.MainResources._8);
                CardResources.Add(MainResources.MainResources._9);
                CardResources.Add(MainResources.MainResources._10);
                CardResources.Add(MainResources.MainResources._11);
                CardResources.Add(MainResources.MainResources._12);
                CardResources.Add(MainResources.MainResources._13);
                CardResources.Add(MainResources.MainResources._14);
                CardResources.Add(MainResources.MainResources._15);
                CardResources.Add(MainResources.MainResources._16);
                CardResources.Add(MainResources.MainResources._17);
                CardResources.Add(MainResources.MainResources._18);
                CardResources.Add(MainResources.MainResources._19);
                CardResources.Add(MainResources.MainResources._20);
                CardResources.Add(MainResources.MainResources._21);
                CardResources.Add(MainResources.MainResources._22);
                CardResources.Add(MainResources.MainResources._23);
                CardResources.Add(MainResources.MainResources._24);
                CardResources.Add(MainResources.MainResources._25);
                CardResources.Add(MainResources.MainResources._26);
                CardResources.Add(MainResources.MainResources._27);
                CardResources.Add(MainResources.MainResources._28);
                CardResources.Add(MainResources.MainResources._29);
                CardResources.Add(MainResources.MainResources._30);
                CardResources.Add(MainResources.MainResources._31);
                CardResources.Add(MainResources.MainResources._32);
                CardResources.Add(MainResources.MainResources._33);
                CardResources.Add(MainResources.MainResources._34);
                CardResources.Add(MainResources.MainResources._35);
                CardResources.Add(MainResources.MainResources._36);
                CardResources.Add(MainResources.MainResources._37);
                CardResources.Add(MainResources.MainResources._38);
                CardResources.Add(MainResources.MainResources._39);
                CardResources.Add(MainResources.MainResources._40);
                CardResources.Add(MainResources.MainResources._41);
                CardResources.Add(MainResources.MainResources._42);
                CardResources.Add(MainResources.MainResources._43);
                CardResources.Add(MainResources.MainResources._44);
                CardResources.Add(MainResources.MainResources._45);
                CardResources.Add(MainResources.MainResources._46);
                CardResources.Add(MainResources.MainResources._47);
                CardResources.Add(MainResources.MainResources._48);
                CardResources.Add(MainResources.MainResources._49);
                CardResources.Add(MainResources.MainResources._50);
                CardResources.Add(MainResources.MainResources._51);
                CardResources.Add(MainResources.MainResources._52);
                CardResources.Add(MainResources.MainResources._53);
                CardResources.Add(MainResources.MainResources._54);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }
    }
}