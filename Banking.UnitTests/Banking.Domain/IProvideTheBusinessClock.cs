﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain;

public interface IProvideTheBusinessClock
{
    bool DuringBusinessHours();
}
