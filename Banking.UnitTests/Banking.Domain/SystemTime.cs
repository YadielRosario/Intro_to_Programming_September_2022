using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain;

public class SystemTime : ISystemTime
{
    public DateTime GetCurrent()
    {
        return DateTime.Now; // THE ONLY PLACE YOU ARE ALLOWED TO USE THIS.
    }
}