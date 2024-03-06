﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Comment
    {
        public Comment() { }

        public Comment(string text, DateTime writingDate, Content content, Member writer) : this()
        {
            this.Text = text;
            this.WritingDate = writingDate;
            this.Content = content;
            this.Writer = writer;
        }
    }
}