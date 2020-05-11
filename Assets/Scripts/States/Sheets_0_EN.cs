using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Sheets_0_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "You cant believe you sleep in these things. Surely its ";
            story += "time somebody changed them. The pleasures of prison life ";
            story += "I guess!\n\n\r";
            story += "Press R to Return to roaming your cell";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Cell_EN();
                MonoBehaviour.print("Change state from Sheets_0 to Cell.");
            }
        }
        public override string ToString()
        {
            return "sheets_0";
        }
    }
}
