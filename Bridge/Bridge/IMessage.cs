﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
   public interface IMessage
    {
        void SendMessage(string to, string message);
    }
}