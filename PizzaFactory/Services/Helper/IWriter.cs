﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Services.Helper
{
    public interface IWriter
    {
        void Write(string data);
        void Flush();
    }
}
