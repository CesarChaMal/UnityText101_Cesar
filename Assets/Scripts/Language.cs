using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace States
{
    public interface Language
    {
        State state { get; set; }
        State getState(String type);
    }
}
