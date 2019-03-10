﻿using System;

namespace LeanMobile.Algorithms
{
    public class Algorithm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public AlgorithmStatus Status { get; set; }

        public DateTime LaunchedDateTime { get; set; }
    }
}