﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_外设读取
{
    public class Computer
    {
        public StorageDevice SD { get; set; }

        public void Write()
        {
            SD.Write();
        }
        public void Read()
        {
            SD.Read();
        }
    }
}
