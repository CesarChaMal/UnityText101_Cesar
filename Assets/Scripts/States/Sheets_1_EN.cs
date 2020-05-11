using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Sheets_1_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "Holding a mirror in your hand doesn't make the sheets look ";
            story += "any better\n\n\r";
            story += "Press R to Return to your cell";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Cell_Mirror_EN();
                MonoBehaviour.print("Change state from Sheets_1 to Cell_Mirror.");
            }
        }
        public override string ToString()
        {
            return "sheets_1";
        }
    }
}
