using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Lock_0_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "This is one of those button locks. You have no idea what the ";
            story += "combination is. You wish you could somehow see where the dirty ";
            story += "fingerprints were, maybe that would help.\n\n\r";
            story += "Press R to Return to roaming your cell";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Cell_EN();
                MonoBehaviour.print("Change state from Lock_0 to Cell.");
            }
        }
        public override string ToString()
        {
            return "lock_0";
        }
    }
}
