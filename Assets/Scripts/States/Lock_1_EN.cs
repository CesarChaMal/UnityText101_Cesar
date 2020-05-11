using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace States
{
    public class Lock_1_EN : State
    {
        public string story{ get; set; }

        public void change(Context context) {
            string story = "You carefully put the mirror through the bars, and turn it round ";
            story += "so you can see the lock. You can just make out fingerprints around ";
            story += "the buttons. You press the dirty buttons, and hear a click\n\n\r";
            story += "Press O to Open, or R to Return to your cell";

            this.story = story;

            if (Input.GetKeyDown(KeyCode.R)) {
                context.state = new Cell_Mirror_EN();
                MonoBehaviour.print("Change state from Lock_1 to Cell_Mirror.");
            } else if (Input.GetKeyDown(KeyCode.O)) {
                context.state = new Corridor_0_EN();
                MonoBehaviour.print("Change state from Lock_1 to Corridor_0.");
            }
        }
        public override string ToString()
        {
            return "lock_1";
        }
    }
}
