﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Threads
{
    public class Thread
    {
        public int Id { get; }
        public int UserId { get; set; }
        public string Title { get; set; }
    }
}
