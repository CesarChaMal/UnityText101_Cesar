using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace States
{
    public interface State
    {
        string story{ get; set; }
        void change(Context context);
    }
}
