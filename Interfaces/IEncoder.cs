﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcklenAveApplication.Models;

namespace AcklenAveApplication.Interfaces
{
    public interface IEncoder
    {
        string Encode(ResponseModel model);
    }
}
