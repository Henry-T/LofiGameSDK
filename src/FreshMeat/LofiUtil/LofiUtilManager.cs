﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LofiUtil.Helpers;
using LofiUtil.Inputs;
using Microsoft.Xna.Framework.Graphics;

namespace LofiUtil
{
    public class LofiXUtilManager
    {
        #region Instance
        private static LofiXUtilManager instance;
        public static LofiXUtilManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new LofiXUtilManager();
                return instance;
            }
        }
        private LofiXUtilManager()
        {
        }
        #endregion

        #region Variables
        public GraphicsDevice GraphicsDevice;
        #endregion

        public void Update()
        {
            TimeHelper.Update();
            Keyboard.Update();
            Mouse.Update();
        }
    }
}
