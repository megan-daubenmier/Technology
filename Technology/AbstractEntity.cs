﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class AbstractEntity
    {
        private int nextID = 0;
        public int ID { get; }

        public AbstractEntity()
        {
            ID = nextID;
            nextID++;
        }
    }
}
