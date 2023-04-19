﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StaticSharpProjectMapGenerator.Models
{
    public class FileTextRange
    {
        public int Start { get; set; }

        public int StartLine { get; set; }

        public int StartColumn { get; set; }

        public int End { get; set; }

        public int EndLine { get; set; }

        public int EndColumn { get; set; }
    }
}