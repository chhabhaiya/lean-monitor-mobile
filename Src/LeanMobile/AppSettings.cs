﻿using System;
using System.Collections.Generic;
using System.Text;
using LeanMobile.Enums;

namespace LeanMobile
{
    public class AppSettings
    {
        private static AppSettings _current;

        public static AppSettings Current => _current ?? (_current = new AppSettings());

        public AppTheme Theme { get; set; } = AppTheme.Dark;
    }
}